namespace TrackerUI
{
    partial class CreateTeamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.create_tournament_title = new System.Windows.Forms.Label();
            this.selectTeamCombo = new System.Windows.Forms.ComboBox();
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.addNewMemberGroup = new System.Windows.Forms.GroupBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.cellPhoneValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teamMemberListBox = new System.Windows.Forms.ListBox();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.removeMemberButton = new System.Windows.Forms.Button();
            this.addNewMemberGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // create_tournament_title
            // 
            this.create_tournament_title.AutoSize = true;
            this.create_tournament_title.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.create_tournament_title.Location = new System.Drawing.Point(16, 13);
            this.create_tournament_title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.create_tournament_title.Name = "create_tournament_title";
            this.create_tournament_title.Size = new System.Drawing.Size(143, 34);
            this.create_tournament_title.TabIndex = 2;
            this.create_tournament_title.Text = "Create Team:";
            this.create_tournament_title.UseCompatibleTextRendering = true;
            // 
            // selectTeamCombo
            // 
            this.selectTeamCombo.FormattingEnabled = true;
            this.selectTeamCombo.Location = new System.Drawing.Point(23, 153);
            this.selectTeamCombo.Name = "selectTeamCombo";
            this.selectTeamCombo.Size = new System.Drawing.Size(272, 25);
            this.selectTeamCombo.TabIndex = 13;
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(23, 83);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(272, 23);
            this.teamNameValue.TabIndex = 12;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(19, 129);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(172, 21);
            this.selectTeamMemberLabel.TabIndex = 10;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.teamNameLabel.Location = new System.Drawing.Point(19, 59);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(103, 21);
            this.teamNameLabel.TabIndex = 11;
            this.teamNameLabel.Text = "Team Name";
            // 
            // addMemberButton
            // 
            this.addMemberButton.BackColor = System.Drawing.Color.White;
            this.addMemberButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addMemberButton.Location = new System.Drawing.Point(184, 196);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(111, 28);
            this.addMemberButton.TabIndex = 14;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = false;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            this.addMemberButton.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.addMemberButton_GiveFeedback);
            // 
            // addNewMemberGroup
            // 
            this.addNewMemberGroup.Controls.Add(this.createMemberButton);
            this.addNewMemberGroup.Controls.Add(this.cellPhoneValue);
            this.addNewMemberGroup.Controls.Add(this.label4);
            this.addNewMemberGroup.Controls.Add(this.emailValue);
            this.addNewMemberGroup.Controls.Add(this.emailLabel);
            this.addNewMemberGroup.Controls.Add(this.lastNameValue);
            this.addNewMemberGroup.Controls.Add(this.lastNameLabel);
            this.addNewMemberGroup.Controls.Add(this.firstNameValue);
            this.addNewMemberGroup.Controls.Add(this.firstNameLabel);
            this.addNewMemberGroup.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addNewMemberGroup.Location = new System.Drawing.Point(23, 246);
            this.addNewMemberGroup.Name = "addNewMemberGroup";
            this.addNewMemberGroup.Size = new System.Drawing.Size(280, 296);
            this.addNewMemberGroup.TabIndex = 15;
            this.addNewMemberGroup.TabStop = false;
            this.addNewMemberGroup.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            this.createMemberButton.BackColor = System.Drawing.Color.White;
            this.createMemberButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.createMemberButton.Location = new System.Drawing.Point(153, 242);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(111, 28);
            this.createMemberButton.TabIndex = 17;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = false;
            this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
            // 
            // cellPhoneValue
            // 
            this.cellPhoneValue.Location = new System.Drawing.Point(117, 173);
            this.cellPhoneValue.Name = "cellPhoneValue";
            this.cellPhoneValue.Size = new System.Drawing.Size(155, 29);
            this.cellPhoneValue.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "CellPhone:";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(117, 128);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(155, 29);
            this.emailValue.TabIndex = 18;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(14, 131);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(55, 21);
            this.emailLabel.TabIndex = 17;
            this.emailLabel.Text = "Email:";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(117, 81);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(155, 29);
            this.lastNameValue.TabIndex = 18;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(14, 84);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(95, 21);
            this.lastNameLabel.TabIndex = 17;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(117, 30);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(155, 29);
            this.firstNameValue.TabIndex = 18;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(14, 33);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(97, 21);
            this.firstNameLabel.TabIndex = 17;
            this.firstNameLabel.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // teamMemberListBox
            // 
            this.teamMemberListBox.FormattingEnabled = true;
            this.teamMemberListBox.ItemHeight = 17;
            this.teamMemberListBox.Location = new System.Drawing.Point(356, 68);
            this.teamMemberListBox.Name = "teamMemberListBox";
            this.teamMemberListBox.Size = new System.Drawing.Size(343, 429);
            this.teamMemberListBox.TabIndex = 17;
            // 
            // createTeamButton
            // 
            this.createTeamButton.BackColor = System.Drawing.Color.White;
            this.createTeamButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.createTeamButton.Location = new System.Drawing.Point(557, 514);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(142, 28);
            this.createTeamButton.TabIndex = 14;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = false;
            this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
            // 
            // removeMemberButton
            // 
            this.removeMemberButton.BackColor = System.Drawing.Color.White;
            this.removeMemberButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.removeMemberButton.Location = new System.Drawing.Point(582, 34);
            this.removeMemberButton.Name = "removeMemberButton";
            this.removeMemberButton.Size = new System.Drawing.Size(117, 28);
            this.removeMemberButton.TabIndex = 17;
            this.removeMemberButton.Text = "Remove Member";
            this.removeMemberButton.UseVisualStyleBackColor = false;
            this.removeMemberButton.Click += new System.EventHandler(this.removeMemberButton_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 566);
            this.Controls.Add(this.removeMemberButton);
            this.Controls.Add(this.teamMemberListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addNewMemberGroup);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamCombo);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.create_tournament_title);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addNewMemberGroup.ResumeLayout(false);
            this.addNewMemberGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label create_tournament_title;
        private System.Windows.Forms.ComboBox selectTeamCombo;
        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.GroupBox addNewMemberGroup;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.TextBox cellPhoneValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.ListBox teamMemberListBox;
        private System.Windows.Forms.Button createTeamButton;
        private System.Windows.Forms.Button removeMemberButton;
    }
}