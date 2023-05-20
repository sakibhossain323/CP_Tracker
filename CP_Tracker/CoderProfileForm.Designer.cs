namespace CP_Tracker
{
    partial class CoderProfileForm
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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelcfid = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelProblemsSolved = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShowGraph = new System.Windows.Forms.Button();
            this.buttonLeaderboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.Window;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Red;
            this.buttonLogout.Location = new System.Drawing.Point(295, 431);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(261, 53);
            this.buttonLogout.TabIndex = 23;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelcfid
            // 
            this.labelcfid.AutoSize = true;
            this.labelcfid.BackColor = System.Drawing.Color.Transparent;
            this.labelcfid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcfid.Location = new System.Drawing.Point(15, 70);
            this.labelcfid.Name = "labelcfid";
            this.labelcfid.Size = new System.Drawing.Size(193, 32);
            this.labelcfid.TabIndex = 19;
            this.labelcfid.Text = "CF ID (Rating)";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(126, 46);
            this.labelName.TabIndex = 18;
            this.labelName.Text = "Name";
            // 
            // labelProblemsSolved
            // 
            this.labelProblemsSolved.AutoSize = true;
            this.labelProblemsSolved.BackColor = System.Drawing.Color.Transparent;
            this.labelProblemsSolved.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProblemsSolved.Location = new System.Drawing.Point(14, 128);
            this.labelProblemsSolved.Name = "labelProblemsSolved";
            this.labelProblemsSolved.Size = new System.Drawing.Size(369, 32);
            this.labelProblemsSolved.TabIndex = 20;
            this.labelProblemsSolved.Text = "Problems Solved This Week";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Average Rating of Solved Problems";
            // 
            // buttonShowGraph
            // 
            this.buttonShowGraph.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonShowGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowGraph.ForeColor = System.Drawing.Color.Teal;
            this.buttonShowGraph.Location = new System.Drawing.Point(295, 315);
            this.buttonShowGraph.Name = "buttonShowGraph";
            this.buttonShowGraph.Size = new System.Drawing.Size(261, 53);
            this.buttonShowGraph.TabIndex = 25;
            this.buttonShowGraph.Text = "Show Graph";
            this.buttonShowGraph.UseVisualStyleBackColor = false;
            this.buttonShowGraph.Click += new System.EventHandler(this.buttonShowGraph_Click);
            // 
            // buttonLeaderboard
            // 
            this.buttonLeaderboard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeaderboard.ForeColor = System.Drawing.Color.Teal;
            this.buttonLeaderboard.Location = new System.Drawing.Point(295, 374);
            this.buttonLeaderboard.Name = "buttonLeaderboard";
            this.buttonLeaderboard.Size = new System.Drawing.Size(261, 53);
            this.buttonLeaderboard.TabIndex = 26;
            this.buttonLeaderboard.Text = "Leaderboard";
            this.buttonLeaderboard.UseVisualStyleBackColor = false;
            this.buttonLeaderboard.Click += new System.EventHandler(this.buttonLeaderboard_Click);
            // 
            // CoderProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 540);
            this.Controls.Add(this.buttonLeaderboard);
            this.Controls.Add(this.buttonShowGraph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelProblemsSolved);
            this.Controls.Add(this.labelcfid);
            this.Controls.Add(this.labelName);
            this.Name = "CoderProfileForm";
            this.Text = "CoderProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelcfid;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelProblemsSolved;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShowGraph;
        private System.Windows.Forms.Button buttonLeaderboard;
    }
}