namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.components = new System.ComponentModel.Container();
            this.viewer_title = new System.Windows.Forms.Label();
            this.tournament_name = new System.Windows.Forms.Label();
            this.round_label = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.scoreButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // viewer_title
            // 
            this.viewer_title.AutoSize = true;
            this.viewer_title.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.viewer_title.Location = new System.Drawing.Point(14, 9);
            this.viewer_title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.viewer_title.Name = "viewer_title";
            this.viewer_title.Size = new System.Drawing.Size(141, 28);
            this.viewer_title.TabIndex = 0;
            this.viewer_title.Text = "Tournament:";
            this.viewer_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // tournament_name
            // 
            this.tournament_name.AutoSize = true;
            this.tournament_name.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tournament_name.Location = new System.Drawing.Point(165, 9);
            this.tournament_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tournament_name.Name = "tournament_name";
            this.tournament_name.Size = new System.Drawing.Size(99, 28);
            this.tournament_name.TabIndex = 0;
            this.tournament_name.Text = "<None>";
            this.tournament_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // round_label
            // 
            this.round_label.AutoSize = true;
            this.round_label.Location = new System.Drawing.Point(43, 67);
            this.round_label.Name = "round_label";
            this.round_label.Size = new System.Drawing.Size(75, 27);
            this.round_label.TabIndex = 1;
            this.round_label.Text = "Round";
            this.round_label.Click += new System.EventHandler(this.round_label_Click);
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(124, 59);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(221, 35);
            this.roundDropDown.TabIndex = 2;
            this.roundDropDown.SelectedIndexChanged += new System.EventHandler(this.roundDropDown_SelectedIndexChanged);
            // 
            // unplayedOnlyCheckBox
            // 
            this.unplayedOnlyCheckBox.AutoSize = true;
            this.unplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyCheckBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.unplayedOnlyCheckBox.Location = new System.Drawing.Point(124, 100);
            this.unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            this.unplayedOnlyCheckBox.Size = new System.Drawing.Size(124, 24);
            this.unplayedOnlyCheckBox.TabIndex = 3;
            this.unplayedOnlyCheckBox.Text = "Unplayed Only";
            this.unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            this.unplayedOnlyCheckBox.CheckedChanged += new System.EventHandler(this.unplayedOnlyCheckBox_CheckedChanged);
            // 
            // matchupListBox
            // 
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 27;
            this.matchupListBox.Location = new System.Drawing.Point(48, 139);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(297, 247);
            this.matchupListBox.TabIndex = 4;
            this.matchupListBox.SelectedIndexChanged += new System.EventHandler(this.matchupListBox_SelectedIndexChanged);
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Location = new System.Drawing.Point(403, 139);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(139, 27);
            this.teamOneName.TabIndex = 1;
            this.teamOneName.Text = "<Team One>";
            this.teamOneName.Click += new System.EventHandler(this.round_label_Click);
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Location = new System.Drawing.Point(403, 249);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(140, 27);
            this.teamTwoName.TabIndex = 1;
            this.teamTwoName.Text = "<Team Two>";
            this.teamTwoName.Click += new System.EventHandler(this.round_label_Click);
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.Location = new System.Drawing.Point(403, 179);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(71, 27);
            this.teamOneScoreLabel.TabIndex = 1;
            this.teamOneScoreLabel.Text = "Score:";
            this.teamOneScoreLabel.Click += new System.EventHandler(this.round_label_Click);
            // 
            // teamOneScoreValue
            // 
            this.teamOneScoreValue.Location = new System.Drawing.Point(480, 176);
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            this.teamOneScoreValue.Size = new System.Drawing.Size(100, 34);
            this.teamOneScoreValue.TabIndex = 5;
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(403, 289);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(71, 27);
            this.teamTwoScoreLabel.TabIndex = 1;
            this.teamTwoScoreLabel.Text = "Score:";
            this.teamTwoScoreLabel.Click += new System.EventHandler(this.round_label_Click);
            // 
            // teamTwoScoreValue
            // 
            this.teamTwoScoreValue.Location = new System.Drawing.Point(480, 286);
            this.teamTwoScoreValue.Name = "teamTwoScoreValue";
            this.teamTwoScoreValue.Size = new System.Drawing.Size(100, 34);
            this.teamTwoScoreValue.TabIndex = 5;
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.scoreButton.Location = new System.Drawing.Point(614, 225);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(87, 35);
            this.scoreButton.TabIndex = 6;
            this.scoreButton.Text = "score";
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(738, 454);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.teamTwoScoreValue);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCheckBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.round_label);
            this.Controls.Add(this.tournament_name);
            this.Controls.Add(this.viewer_title);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewer_title;
        private System.Windows.Forms.Label tournament_name;
        private System.Windows.Forms.Label round_label;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckBox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label teamOneScoreLabel;
        private System.Windows.Forms.TextBox teamOneScoreValue;
        private System.Windows.Forms.Label teamTwoScoreLabel;
        private System.Windows.Forms.TextBox teamTwoScoreValue;
        internal System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}