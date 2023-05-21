namespace CP_Tracker
{
    partial class AdminProfileForm
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
            this.buttonRegularSkill = new System.Windows.Forms.Button();
            this.buttonAdvancedSkill = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.textboxRegulerskill = new System.Windows.Forms.TextBox();
            this.textBoxAdvancedskill = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonRegularSkill
            // 
            this.buttonRegularSkill.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRegularSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegularSkill.ForeColor = System.Drawing.Color.Teal;
            this.buttonRegularSkill.Location = new System.Drawing.Point(27, 230);
            this.buttonRegularSkill.Name = "buttonRegularSkill";
            this.buttonRegularSkill.Size = new System.Drawing.Size(274, 53);
            this.buttonRegularSkill.TabIndex = 26;
            this.buttonRegularSkill.Text = "Add Reguler Skill";
            this.buttonRegularSkill.UseVisualStyleBackColor = false;
            this.buttonRegularSkill.Click += new System.EventHandler(this.buttonRegularSkill_Click);
            // 
            // buttonAdvancedSkill
            // 
            this.buttonAdvancedSkill.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdvancedSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdvancedSkill.ForeColor = System.Drawing.Color.Teal;
            this.buttonAdvancedSkill.Location = new System.Drawing.Point(481, 230);
            this.buttonAdvancedSkill.Name = "buttonAdvancedSkill";
            this.buttonAdvancedSkill.Size = new System.Drawing.Size(274, 53);
            this.buttonAdvancedSkill.TabIndex = 27;
            this.buttonAdvancedSkill.Text = "Add Advanced Skill";
            this.buttonAdvancedSkill.UseVisualStyleBackColor = false;
            this.buttonAdvancedSkill.Click += new System.EventHandler(this.buttonAdvancedSkill_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.Window;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Red;
            this.buttonLogout.Location = new System.Drawing.Point(269, 326);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(274, 53);
            this.buttonLogout.TabIndex = 28;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // textboxRegulerskill
            // 
            this.textboxRegulerskill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxRegulerskill.Location = new System.Drawing.Point(27, 186);
            this.textboxRegulerskill.Name = "textboxRegulerskill";
            this.textboxRegulerskill.Size = new System.Drawing.Size(274, 38);
            this.textboxRegulerskill.TabIndex = 29;
            // 
            // textBoxAdvancedskill
            // 
            this.textBoxAdvancedskill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdvancedskill.Location = new System.Drawing.Point(481, 186);
            this.textBoxAdvancedskill.Name = "textBoxAdvancedskill";
            this.textBoxAdvancedskill.Size = new System.Drawing.Size(274, 38);
            this.textBoxAdvancedskill.TabIndex = 30;
            // 
            // AdminProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAdvancedskill);
            this.Controls.Add(this.textboxRegulerskill);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonAdvancedSkill);
            this.Controls.Add(this.buttonRegularSkill);
            this.Name = "AdminProfileForm";
            this.Text = "AdminProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegularSkill;
        private System.Windows.Forms.Button buttonAdvancedSkill;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.TextBox textboxRegulerskill;
        private System.Windows.Forms.TextBox textBoxAdvancedskill;
    }
}