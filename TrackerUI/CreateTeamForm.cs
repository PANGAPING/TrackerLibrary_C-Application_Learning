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
    public partial class CreateTeamForm : Form
    {

        private List<PersonModel> availableTeamMembers = new List<PersonModel>();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        private ITeamRequester callingForm;


        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();

            callingForm = caller;

            WireUpLists();
        }

        private void WireUpLists()
        {
            selectTeamCombo.DataSource = availableTeamMembers;
            selectTeamCombo.DisplayMember = "FullName";

            teamMemberListBox.DataSource = selectedTeamMembers;
            teamMemberListBox.DisplayMember = "FullName";
            
        }


        private void addMemberButton_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidationForm()) {
                PersonModel model = new PersonModel();

                model.FirstName = firstNameValue.Text;
                model.LastName = lastNameValue.Text;
                model.EmailAddress = emailValue.Text;
                model.CellPhoneNumber = cellPhoneValue.Text;


                GlobalConfig.Connection.CreatePerson(model);

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellPhoneValue.Text = "";

            }
        }


        /// <summary>
        /// Evaluate if  the create person form is valid.
        /// </summary>
        /// <returns></returns>
        private bool ValidationForm() {
            bool output = true;

            if (firstNameValue.Text.Length == 0) {
                output = false;
            }

            if (lastNameValue.Text.Length == 0) {
                output = false;
            }

            if (emailValue.Text.Length == 0) {
                output = false;
            }

            if (cellPhoneValue.Text.Length == 0) {
                output = false;
            }


            return output;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel) selectTeamCombo.SelectedItem;
            if (p!=null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                selectTeamCombo.Refresh();
                teamMemberListBox.Refresh(); 
            }
            
        }

        private void removeMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel) teamMemberListBox.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Add(p);
                selectedTeamMembers.Remove(p);

                selectTeamCombo.Refresh();
                teamMemberListBox.Refresh();
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel model = new TeamModel();
            model.TeamName = teamNameValue.Text;
            model.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(model);

            callingForm.TeamComplete(model);
            this.Close();
        }
    }
}
