namespace CP_Tracker
{
    partial class FacultyProfileForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelDesignation = new System.Windows.Forms.Label();
            this.labelCodersAssigned = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonShowStudentList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(244, 37);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(126, 46);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Name";
            // 
            // labelDesignation
            // 
            this.labelDesignation.AutoSize = true;
            this.labelDesignation.BackColor = System.Drawing.Color.Transparent;
            this.labelDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesignation.Location = new System.Drawing.Point(247, 98);
            this.labelDesignation.Name = "labelDesignation";
            this.labelDesignation.Size = new System.Drawing.Size(166, 32);
            this.labelDesignation.TabIndex = 13;
            this.labelDesignation.Text = "Designation";
            // 
            // labelCodersAssigned
            // 
            this.labelCodersAssigned.AutoSize = true;
            this.labelCodersAssigned.BackColor = System.Drawing.Color.Transparent;
            this.labelCodersAssigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodersAssigned.Location = new System.Drawing.Point(246, 148);
            this.labelCodersAssigned.Name = "labelCodersAssigned";
            this.labelCodersAssigned.Size = new System.Drawing.Size(230, 32);
            this.labelCodersAssigned.TabIndex = 14;
            this.labelCodersAssigned.Text = "Coders Assigned";
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.Window;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Red;
            this.buttonLogout.Location = new System.Drawing.Point(235, 313);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(261, 53);
            this.buttonLogout.TabIndex = 17;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonShowStudentList
            // 
            this.buttonShowStudentList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonShowStudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowStudentList.ForeColor = System.Drawing.Color.Teal;
            this.buttonShowStudentList.Location = new System.Drawing.Point(235, 245);
            this.buttonShowStudentList.Name = "buttonShowStudentList";
            this.buttonShowStudentList.Size = new System.Drawing.Size(261, 53);
            this.buttonShowStudentList.TabIndex = 16;
            this.buttonShowStudentList.Text = "Show Student List";
            this.buttonShowStudentList.UseVisualStyleBackColor = false;
            this.buttonShowStudentList.Click += new System.EventHandler(this.buttonShowStudentList_Click);
            // 
            // FacultyProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonShowStudentList);
            this.Controls.Add(this.labelCodersAssigned);
            this.Controls.Add(this.labelDesignation);
            this.Controls.Add(this.labelName);
            this.Name = "FacultyProfileForm";
            this.Text = "FacultyProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDesignation;
        private System.Windows.Forms.Label labelCodersAssigned;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonShowStudentList;
    }
}