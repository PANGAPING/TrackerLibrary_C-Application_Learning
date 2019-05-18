namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.selectTeamCombo = new System.Windows.Forms.ComboBox();
            this.createNewLabel = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.teamListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.deletePlayersButton = new System.Windows.Forms.Button();
            this.delectPrizesButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // create_tournament_title
            // 
            this.create_tournament_title.AutoSize = true;
            this.create_tournament_title.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.create_tournament_title.Location = new System.Drawing.Point(14, 9);
            this.create_tournament_title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.create_tournament_title.Name = "create_tournament_title";
            this.create_tournament_title.Size = new System.Drawing.Size(213, 34);
            this.create_tournament_title.TabIndex = 1;
            this.create_tournament_title.Text = "Create Tournament:";
            this.create_tournament_title.UseCompatibleTextRendering = true;
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(37, 104);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(255, 23);
            this.tournamentNameValue.TabIndex = 7;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tournamentNameLabel.Location = new System.Drawing.Point(33, 80);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(155, 21);
            this.tournamentNameLabel.TabIndex = 6;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectTeamLabel.Location = new System.Drawing.Point(33, 168);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(102, 21);
            this.selectTeamLabel.TabIndex = 6;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // selectTeamCombo
            // 
            this.selectTeamCombo.FormattingEnabled = true;
            this.selectTeamCombo.Location = new System.Drawing.Point(37, 192);
            this.selectTeamCombo.Name = "selectTeamCombo";
            this.selectTeamCombo.Size = new System.Drawing.Size(255, 25);
            this.selectTeamCombo.TabIndex = 8;
            // 
            // createNewLabel
            // 
            this.createNewLabel.AutoSize = true;
            this.createNewLabel.BackColor = System.Drawing.Color.Transparent;
            this.createNewLabel.Location = new System.Drawing.Point(223, 172);
            this.createNewLabel.Name = "createNewLabel";
            this.createNewLabel.Size = new System.Drawing.Size(69, 21);
            this.createNewLabel.TabIndex = 9;
            this.createNewLabel.TabStop = true;
            this.createNewLabel.Text = "create new";
            this.createNewLabel.UseCompatibleTextRendering = true;
            this.createNewLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewLabel_LinkClicked);
            // 
            // addTeamButton
            // 
            this.addTeamButton.BackColor = System.Drawing.Color.White;
            this.addTeamButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addTeamButton.Location = new System.Drawing.Point(37, 326);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(111, 35);
            this.addTeamButton.TabIndex = 10;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = false;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.BackColor = System.Drawing.Color.White;
            this.createPrizeButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.createPrizeButton.Location = new System.Drawing.Point(37, 391);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(111, 35);
            this.createPrizeButton.TabIndex = 10;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = false;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // teamListBox
            // 
            this.teamListBox.FormattingEnabled = true;
            this.teamListBox.ItemHeight = 17;
            this.teamListBox.Location = new System.Drawing.Point(345, 104);
            this.teamListBox.Name = "teamListBox";
            this.teamListBox.Size = new System.Drawing.Size(265, 123);
            this.teamListBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(341, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Teams/Players";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(341, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prizes";
            // 
            // prizesListBox
            // 
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 17;
            this.prizesListBox.Location = new System.Drawing.Point(345, 285);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(265, 123);
            this.prizesListBox.TabIndex = 11;
            // 
            // deletePlayersButton
            // 
            this.deletePlayersButton.BackColor = System.Drawing.Color.White;
            this.deletePlayersButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deletePlayersButton.Location = new System.Drawing.Point(616, 143);
            this.deletePlayersButton.Name = "deletePlayersButton";
            this.deletePlayersButton.Size = new System.Drawing.Size(111, 35);
            this.deletePlayersButton.TabIndex = 10;
            this.deletePlayersButton.Text = "Delete Players";
            this.deletePlayersButton.UseVisualStyleBackColor = false;
            this.deletePlayersButton.Click += new System.EventHandler(this.deletePlayersButton_Click);
            // 
            // delectPrizesButton
            // 
            this.delectPrizesButton.BackColor = System.Drawing.Color.White;
            this.delectPrizesButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delectPrizesButton.Location = new System.Drawing.Point(616, 326);
            this.delectPrizesButton.Name = "delectPrizesButton";
            this.delectPrizesButton.Size = new System.Drawing.Size(111, 35);
            this.delectPrizesButton.TabIndex = 10;
            this.delectPrizesButton.Text = "Delect Prizes";
            this.delectPrizesButton.UseVisualStyleBackColor = false;
            this.delectPrizesButton.Click += new System.EventHandler(this.delectPrizesButton_Click);
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.Color.White;
            this.createTournamentButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.createTournamentButton.Location = new System.Drawing.Point(499, 433);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(228, 35);
            this.createTournamentButton.TabIndex = 10;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(37, 266);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(255, 23);
            this.entryFeeValue.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(33, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Entry Fee";
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 480);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.teamListBox);
            this.Controls.Add(this.delectPrizesButton);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.deletePlayersButton);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.selectTeamCombo);
            this.Controls.Add(this.createNewLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.create_tournament_title);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label create_tournament_title;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.ComboBox selectTeamCombo;
        private System.Windows.Forms.LinkLabel createNewLabel;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.ListBox teamListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button deletePlayersButton;
        private System.Windows.Forms.Button delectPrizesButton;
        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label label3;
    }
}