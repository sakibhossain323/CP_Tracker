namespace CP_Tracker
{
    partial class CoderListForm
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
            this.listboxCoder = new System.Windows.Forms.ListBox();
            this.linkLabelProfileBack = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // listboxCoder
            // 
            this.listboxCoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxCoder.FormattingEnabled = true;
            this.listboxCoder.ItemHeight = 20;
            this.listboxCoder.Location = new System.Drawing.Point(116, 45);
            this.listboxCoder.Name = "listboxCoder";
            this.listboxCoder.Size = new System.Drawing.Size(599, 324);
            this.listboxCoder.TabIndex = 1;
            // 
            // linkLabelProfileBack
            // 
            this.linkLabelProfileBack.ActiveLinkColor = System.Drawing.Color.Firebrick;
            this.linkLabelProfileBack.AutoSize = true;
            this.linkLabelProfileBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelProfileBack.LinkColor = System.Drawing.Color.Firebrick;
            this.linkLabelProfileBack.Location = new System.Drawing.Point(309, 389);
            this.linkLabelProfileBack.Name = "linkLabelProfileBack";
            this.linkLabelProfileBack.Size = new System.Drawing.Size(178, 29);
            this.linkLabelProfileBack.TabIndex = 6;
            this.linkLabelProfileBack.TabStop = true;
            this.linkLabelProfileBack.Text = "Back To Profile";
            this.linkLabelProfileBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelProfileBack_LinkClicked);
            // 
            // CoderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelProfileBack);
            this.Controls.Add(this.listboxCoder);
            this.Name = "CoderListForm";
            this.Text = "CoderListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxCoder;
        private System.Windows.Forms.LinkLabel linkLabelProfileBack;
    }
}