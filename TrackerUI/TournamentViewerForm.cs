using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {

        private TournamentModel tournament;

        List<int> rounds = new List<int>();

        List<MatchupModel> selectedMacthups = new List<MatchupModel>();

        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            LoadFormData();

            LoadRounds();
        }

        private void LoadFormData() {
            tournament_name.Text = tournament.TournamentName;
        }


        private void WireUpRoundsLists() {
            roundDropDown.DataSource = null;
            roundDropDown.DataSource = rounds;


        }


        private void WireUpMatchupsLists() {
            matchupListBox.DataSource = null;
            matchupListBox.DataSource = selectedMacthups;
            matchupListBox.DisplayMember = "DisplayName";
        }

        private void LoadRounds() {
            rounds.Add(1);

            int currRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRound) {
                    rounds.Add(currRound);
                    currRound += 1;
                }
            }

            WireUpRoundsLists();
        }

        private void LoadMatchups() {

            int round = (int)roundDropDown.SelectedItem;

            foreach (List<MatchupModel> matchups in tournament.Rounds) {
                if (matchups.First().MatchupRound == round) {
                    selectedMacthups.Clear();

                    foreach (MatchupModel m in matchups) {
                        if (m.Winner == null || !unplayedOnlyCheckBox.Checked) {
                            selectedMacthups.Add(m);
                        }
                    }
                    break;
                }
            }


            if (selectedMacthups.Count > 0) {
                LoadMatchup(selectedMacthups.First());
            }


            WireUpMatchupsLists();

            DisplayMatchupInfo();

        }

        private void DisplayMatchupInfo() {
            bool isVisible = (selectedMacthups.Count > 0);


            teamOneName.Visible = isVisible;
            teamOneScoreLabel.Visible = isVisible;
            teamOneScoreValue.Visible = isVisible;

            teamTwoName.Visible = isVisible;
            teamTwoScoreLabel.Visible = isVisible;
            teamTwoScoreValue.Visible = isVisible;


            scoreButton.Visible = isVisible;
            
        }


        private void LoadMatchup(MatchupModel m) {


            for (int i = 0; i < m.Entries.Count; i++) {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        teamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
                        teamOneScoreValue.Text =m.Entries[0].Score.ToString();
                        teamTwoName.Text = "<BYE>";
                        teamTwoScoreValue.Text = "0";
                    }
                    else {
                        teamOneName.Text = "Not Yet Set.";
                        teamOneScoreValue.Text = "";
                    }
                }
                else {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        teamTwoName.Text = m.Entries[1].TeamCompeting.TeamName;
                        teamTwoScoreValue.Text = m.Entries[1].Score.ToString();
                    }
                    else {
                        teamTwoName.Text = "Not Yet Set.";
                        teamTwoScoreValue.Text = "";
                    }

                }
            }

        }



        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }


        private void round_label_Click(object sender,EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup((MatchupModel)matchupListBox.SelectedItem);
        }

        private void unplayedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;

            double teamOneScore = 0;
            double teamTwoScore = 0;

            
            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(teamOneScoreValue.Text, out teamOneScore);
                        if (scoreValid)
                        {
                            m.Entries[0].Score = teamOneScore;
                        }
                        else {
                            MessageBox.Show("Please enter a valid score for team 1.");
                            return;
                        }
                    }
                }
                else
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(teamTwoScoreValue.Text, out teamTwoScore);
                        if (scoreValid)
                        {
                            m.Entries[1].Score = teamTwoScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team 2.");
                            return;
                        }
                    }
                }

                if (teamOneScore > teamTwoScore)
                {
                    // Team one wins
                    m.Winner = m.Entries[0].TeamCompeting;
                }
                else if (teamTwoScore > teamOneScore)
                {
                    m.Winner = m.Entries[1].TeamCompeting;
                }
                else {
                    MessageBox.Show("I do not handle tie games.");
                }

            }


            //Once we scored the score we can tell out what's TeamCometing of the Entry which comes from this matchup.
            foreach (List<MatchupModel> round in tournament.Rounds) {
                foreach (MatchupModel rm in round) {
                    foreach (MatchupEntryModel me in rm.Entries) {


                        if (me.ParentMatchup != null)
                        {
                            if (me.ParentMatchup.Id == m.Id)
                            {
                                me.TeamCompeting = m.Winner;
                                GlobalConfig.Connection.UpdateMatchup(rm);
                            } 
                        }

                    }
                }
            }

            LoadMatchups();

            GlobalConfig.Connection.UpdateMatchup(m);
        }
    }
}
