namespace CP_Tracker
{
    partial class LeaderboardForm
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
            this.SuspendLayout();
            // 
            // listboxCoder
            // 
            this.listboxCoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxCoder.FormattingEnabled = true;
            this.listboxCoder.ItemHeight = 20;
            this.listboxCoder.Location = new System.Drawing.Point(101, 39);
            this.listboxCoder.Name = "listboxCoder";
            this.listboxCoder.Size = new System.Drawing.Size(599, 364);
            this.listboxCoder.TabIndex = 7;
            // 
            // LeaderboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listboxCoder);
            this.Name = "LeaderboardForm";
            this.Text = "LeaderboardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listboxCoder;
    }
}