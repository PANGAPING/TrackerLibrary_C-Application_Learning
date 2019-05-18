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
    public partial class CreateTournamentForm : Form,IPrizeRequester,ITeamRequester
    {

        List<TeamModel> availableTeams = GlobalConfig.Connection.GetAllTeams();

        List<TeamModel> selectedTeams = new List<TeamModel>();

        List<PrizeModel> selectedPrizes = new List<PrizeModel>();



        public CreateTournamentForm()
        {
            InitializeComponent();

            InitializeLists();
        }


        private void InitializeLists()
        {
            selectTeamCombo.DataSource = availableTeams;
            selectTeamCombo.DisplayMember = "TeamName";

            teamListBox.DataSource = selectedTeams;
            teamListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";   
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel selectedTeam = (TeamModel)selectTeamCombo.SelectedItem;
            if (selectedTeam != null) {
                availableTeams.Remove(selectedTeam);
                selectedTeams.Add(selectedTeam);

                selectTeamCombo.Refresh();
                teamListBox.Refresh();
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            CreatePrizeForm frm = new CreatePrizeForm(this);

            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);

            prizesListBox.Refresh();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);

            teamListBox.Refresh();
        }

        private void createNewLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void deletePlayersButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel) teamListBox.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                selectTeamCombo.Refresh();
                teamListBox.Refresh();
            }
        }

        private void delectPrizesButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;

            if (p != null) {
                selectedPrizes.Remove(p);

                prizesListBox.Refresh();
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(entryFeeValue.Text,out fee);

            if (!feeAcceptable) {
                MessageBox.Show("You need to enter a valid Entry Fee",
                        "Invalid Fee",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return;
            }

            TournamentModel tm = new TournamentModel();
            tm.TournamentName = tournamentNameValue.Text;
            tm.EntryFee = fee;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;


            TournamentLogic.CreateRounds(tm);



            //Create Tournament entry 
            //Create all of the prizes entries 
            //Create all of team entries

            GlobalConfig.Connection.CreateTournament(tm);
        }
    }
}
