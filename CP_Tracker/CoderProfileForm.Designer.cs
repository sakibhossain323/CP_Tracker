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
            this.labelcfid = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelProblemsSolved = new System.Windows.Forms.Label();
            this.labelAvrgrate = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonShowGraph = new System.Windows.Forms.Button();
            this.buttonLeaderboard = new System.Windows.Forms.Button();
            this.buttonAddSkill = new System.Windows.Forms.Button();
            this.buttonAddProblem = new System.Windows.Forms.Button();
            this.textboxRegulerskill = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxSkillName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonShowSkill = new System.Windows.Forms.Button();
            this.listBoxShowSkill = new System.Windows.Forms.ListBox();
            this.textBoxUpdaterating = new System.Windows.Forms.TextBox();
            this.buttonUpdateRating = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // labelAvrgrate
            // 
            this.labelAvrgrate.AutoSize = true;
            this.labelAvrgrate.BackColor = System.Drawing.Color.Transparent;
            this.labelAvrgrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvrgrate.Location = new System.Drawing.Point(14, 178);
            this.labelAvrgrate.Name = "labelAvrgrate";
            this.labelAvrgrate.Size = new System.Drawing.Size(463, 32);
            this.labelAvrgrate.TabIndex = 24;
            this.labelAvrgrate.Text = "Average Rating of Solved Problems";
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.Window;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Red;
            this.buttonLogout.Location = new System.Drawing.Point(619, 595);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(261, 53);
            this.buttonLogout.TabIndex = 23;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonShowGraph
            // 
            this.buttonShowGraph.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonShowGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowGraph.ForeColor = System.Drawing.Color.Teal;
            this.buttonShowGraph.Location = new System.Drawing.Point(619, 522);
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
            this.buttonLeaderboard.Location = new System.Drawing.Point(619, 449);
            this.buttonLeaderboard.Name = "buttonLeaderboard";
            this.buttonLeaderboard.Size = new System.Drawing.Size(261, 53);
            this.buttonLeaderboard.TabIndex = 26;
            this.buttonLeaderboard.Text = "Leaderboard";
            this.buttonLeaderboard.UseVisualStyleBackColor = false;
            this.buttonLeaderboard.Click += new System.EventHandler(this.buttonLeaderboard_Click);
            // 
            // buttonAddSkill
            // 
            this.buttonAddSkill.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSkill.ForeColor = System.Drawing.Color.Teal;
            this.buttonAddSkill.Location = new System.Drawing.Point(244, 475);
            this.buttonAddSkill.Name = "buttonAddSkill";
            this.buttonAddSkill.Size = new System.Drawing.Size(261, 53);
            this.buttonAddSkill.TabIndex = 27;
            this.buttonAddSkill.Text = "Add Skill";
            this.buttonAddSkill.UseVisualStyleBackColor = false;
            this.buttonAddSkill.Click += new System.EventHandler(this.buttonAddSkill_Click);
            // 
            // buttonAddProblem
            // 
            this.buttonAddProblem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProblem.ForeColor = System.Drawing.Color.Teal;
            this.buttonAddProblem.Location = new System.Drawing.Point(244, 357);
            this.buttonAddProblem.Name = "buttonAddProblem";
            this.buttonAddProblem.Size = new System.Drawing.Size(261, 53);
            this.buttonAddProblem.TabIndex = 29;
            this.buttonAddProblem.Text = "Add Problem";
            this.buttonAddProblem.UseVisualStyleBackColor = false;
            this.buttonAddProblem.Click += new System.EventHandler(this.buttonAddProblem_Click);
            // 
            // textboxRegulerskill
            // 
            this.textboxRegulerskill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxRegulerskill.Location = new System.Drawing.Point(244, 313);
            this.textboxRegulerskill.Name = "textboxRegulerskill";
            this.textboxRegulerskill.Size = new System.Drawing.Size(261, 38);
            this.textboxRegulerskill.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(244, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 38);
            this.textBox1.TabIndex = 31;
            // 
            // textBoxSkillName
            // 
            this.textBoxSkillName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSkillName.Location = new System.Drawing.Point(244, 431);
            this.textBoxSkillName.Name = "textBoxSkillName";
            this.textBoxSkillName.Size = new System.Drawing.Size(261, 38);
            this.textBoxSkillName.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Skill Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 32);
            this.label2.TabIndex = 34;
            this.label2.Text = "Problem Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 32);
            this.label3.TabIndex = 35;
            this.label3.Text = "Problem Rating";
            // 
            // buttonShowSkill
            // 
            this.buttonShowSkill.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonShowSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowSkill.ForeColor = System.Drawing.Color.Teal;
            this.buttonShowSkill.Location = new System.Drawing.Point(619, 376);
            this.buttonShowSkill.Name = "buttonShowSkill";
            this.buttonShowSkill.Size = new System.Drawing.Size(261, 53);
            this.buttonShowSkill.TabIndex = 36;
            this.buttonShowSkill.Text = "Show Skill";
            this.buttonShowSkill.UseVisualStyleBackColor = false;
            this.buttonShowSkill.Click += new System.EventHandler(this.buttonShowSkill_Click);
            // 
            // listBoxShowSkill
            // 
            this.listBoxShowSkill.FormattingEnabled = true;
            this.listBoxShowSkill.ItemHeight = 16;
            this.listBoxShowSkill.Location = new System.Drawing.Point(619, 12);
            this.listBoxShowSkill.Name = "listBoxShowSkill";
            this.listBoxShowSkill.Size = new System.Drawing.Size(261, 356);
            this.listBoxShowSkill.TabIndex = 37;
            // 
            // textBoxUpdaterating
            // 
            this.textBoxUpdaterating.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUpdaterating.Location = new System.Drawing.Point(244, 551);
            this.textBoxUpdaterating.Name = "textBoxUpdaterating";
            this.textBoxUpdaterating.Size = new System.Drawing.Size(261, 38);
            this.textBoxUpdaterating.TabIndex = 38;
            this.textBoxUpdaterating.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonUpdateRating
            // 
            this.buttonUpdateRating.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonUpdateRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateRating.ForeColor = System.Drawing.Color.Teal;
            this.buttonUpdateRating.Location = new System.Drawing.Point(244, 595);
            this.buttonUpdateRating.Name = "buttonUpdateRating";
            this.buttonUpdateRating.Size = new System.Drawing.Size(261, 53);
            this.buttonUpdateRating.TabIndex = 39;
            this.buttonUpdateRating.Text = "Update Rating";
            this.buttonUpdateRating.UseVisualStyleBackColor = false;
            this.buttonUpdateRating.Click += new System.EventHandler(this.buttonUpdateRating_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 32);
            this.label4.TabIndex = 40;
            this.label4.Text = "New CF Rating";
            // 
            // CoderProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 689);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonUpdateRating);
            this.Controls.Add(this.textBoxUpdaterating);
            this.Controls.Add(this.listBoxShowSkill);
            this.Controls.Add(this.buttonShowSkill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSkillName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textboxRegulerskill);
            this.Controls.Add(this.buttonAddProblem);
            this.Controls.Add(this.buttonAddSkill);
            this.Controls.Add(this.buttonLeaderboard);
            this.Controls.Add(this.buttonShowGraph);
            this.Controls.Add(this.labelAvrgrate);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelProblemsSolved);
            this.Controls.Add(this.labelcfid);
            this.Controls.Add(this.labelName);
            this.Name = "CoderProfileForm";
            this.Text = "CoderProfileForm";
            this.Load += new System.EventHandler(this.CoderProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelcfid;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelProblemsSolved;
        private System.Windows.Forms.Label labelAvrgrate;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonShowGraph;
        private System.Windows.Forms.Button buttonLeaderboard;
        private System.Windows.Forms.Button buttonAddSkill;
        private System.Windows.Forms.Button buttonAddProblem;
        private System.Windows.Forms.TextBox textboxRegulerskill;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxSkillName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonShowSkill;
        private System.Windows.Forms.ListBox listBoxShowSkill;
        private System.Windows.Forms.TextBox textBoxUpdaterating;
        private System.Windows.Forms.Button buttonUpdateRating;
        private System.Windows.Forms.Label label4;
    }
}