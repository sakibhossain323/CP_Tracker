namespace CP_Tracker
{
    partial class FacultyForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxDesignation = new System.Windows.Forms.TextBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.buttonFaculty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Designation: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Full Name: ";
            // 
            // textboxDesignation
            // 
            this.textboxDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxDesignation.Location = new System.Drawing.Point(403, 202);
            this.textboxDesignation.Name = "textboxDesignation";
            this.textboxDesignation.Size = new System.Drawing.Size(185, 34);
            this.textboxDesignation.TabIndex = 7;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullName.Location = new System.Drawing.Point(403, 151);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(185, 34);
            this.textBoxFullName.TabIndex = 8;
            // 
            // buttonFaculty
            // 
            this.buttonFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFaculty.Location = new System.Drawing.Point(210, 308);
            this.buttonFaculty.Name = "buttonFaculty";
            this.buttonFaculty.Size = new System.Drawing.Size(374, 61);
            this.buttonFaculty.TabIndex = 9;
            this.buttonFaculty.Text = "Create Faculty Account";
            this.buttonFaculty.UseVisualStyleBackColor = true;
            this.buttonFaculty.Click += new System.EventHandler(this.buttonFaculty_Click);
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFaculty);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.textboxDesignation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FacultyForm";
            this.Text = "FacultyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxDesignation;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Button buttonFaculty;
    }
}