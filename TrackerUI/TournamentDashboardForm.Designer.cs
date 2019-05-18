namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.tournamentDashBoardLabel = new System.Windows.Forms.Label();
            this.loadExistTournamentlabel = new System.Windows.Forms.Label();
            this.existingTournamentCombo = new System.Windows.Forms.ComboBox();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentDashBoardLabel
            // 
            this.tournamentDashBoardLabel.AutoSize = true;
            this.tournamentDashBoardLabel.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tournamentDashBoardLabel.Location = new System.Drawing.Point(14, 9);
            this.tournamentDashBoardLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tournamentDashBoardLabel.Name = "tournamentDashBoardLabel";
            this.tournamentDashBoardLabel.Size = new System.Drawing.Size(254, 34);
            this.tournamentDashBoardLabel.TabIndex = 2;
            this.tournamentDashBoardLabel.Text = "Tournament DashBoard";
            this.tournamentDashBoardLabel.UseCompatibleTextRendering = true;
            // 
            // loadExistTournamentlabel
            // 
            this.loadExistTournamentlabel.AutoSize = true;
            this.loadExistTournamentlabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loadExistTournamentlabel.Location = new System.Drawing.Point(132, 93);
            this.loadExistTournamentlabel.Name = "loadExistTournamentlabel";
            this.loadExistTournamentlabel.Size = new System.Drawing.Size(209, 21);
            this.loadExistTournamentlabel.TabIndex = 15;
            this.loadExistTournamentlabel.Text = "Load Existing Tournament";
            this.loadExistTournamentlabel.Click += new System.EventHandler(this.loadExistTournamentlabel_Click);
            // 
            // existingTournamentCombo
            // 
            this.existingTournamentCombo.FormattingEnabled = true;
            this.existingTournamentCombo.Location = new System.Drawing.Point(136, 117);
            this.existingTournamentCombo.Name = "existingTournamentCombo";
            this.existingTournamentCombo.Size = new System.Drawing.Size(227, 20);
            this.existingTournamentCombo.TabIndex = 16;
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.BackColor = System.Drawing.Color.White;
            this.loadTournamentButton.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loadTournamentButton.Location = new System.Drawing.Point(135, 143);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(111, 28);
            this.loadTournamentButton.TabIndex = 18;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = false;
            this.loadTournamentButton.Click += new System.EventHandler(this.loadTournamentButton_Click);
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.Color.White;
            this.createTournamentButton.Font = new System.Drawing.Font("微软雅黑", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.createTournamentButton.Location = new System.Drawing.Point(263, 143);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(100, 28);
            this.createTournamentButton.TabIndex = 18;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 181);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.existingTournamentCombo);
            this.Controls.Add(this.loadExistTournamentlabel);
            this.Controls.Add(this.tournamentDashBoardLabel);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.Load += new System.EventHandler(this.TournamentDashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentDashBoardLabel;
        private System.Windows.Forms.Label loadExistTournamentlabel;
        private System.Windows.Forms.ComboBox existingTournamentCombo;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}