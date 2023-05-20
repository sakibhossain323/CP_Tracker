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
            this.buttonAvrgrate = new System.Windows.Forms.Button();
            this.buttonProblemCnt = new System.Windows.Forms.Button();
            this.buttonCfrating = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listboxCoder
            // 
            this.listboxCoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxCoder.FormattingEnabled = true;
            this.listboxCoder.ItemHeight = 25;
            this.listboxCoder.Location = new System.Drawing.Point(51, 42);
            this.listboxCoder.Name = "listboxCoder";
            this.listboxCoder.Size = new System.Drawing.Size(599, 354);
            this.listboxCoder.TabIndex = 7;
            // 
            // buttonAvrgrate
            // 
            this.buttonAvrgrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAvrgrate.Location = new System.Drawing.Point(666, 254);
            this.buttonAvrgrate.Name = "buttonAvrgrate";
            this.buttonAvrgrate.Size = new System.Drawing.Size(171, 75);
            this.buttonAvrgrate.TabIndex = 17;
            this.buttonAvrgrate.Text = "Avrg Rating of Solved Problems";
            this.buttonAvrgrate.UseVisualStyleBackColor = true;
            this.buttonAvrgrate.Click += new System.EventHandler(this.buttonAvrgrate_Click);
            // 
            // buttonProblemCnt
            // 
            this.buttonProblemCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProblemCnt.Location = new System.Drawing.Point(666, 171);
            this.buttonProblemCnt.Name = "buttonProblemCnt";
            this.buttonProblemCnt.Size = new System.Drawing.Size(171, 61);
            this.buttonProblemCnt.TabIndex = 18;
            this.buttonProblemCnt.Text = "Problem Count";
            this.buttonProblemCnt.UseVisualStyleBackColor = true;
            this.buttonProblemCnt.Click += new System.EventHandler(this.buttonProblemCnt_Click);
            // 
            // buttonCfrating
            // 
            this.buttonCfrating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCfrating.Location = new System.Drawing.Point(666, 86);
            this.buttonCfrating.Name = "buttonCfrating";
            this.buttonCfrating.Size = new System.Drawing.Size(171, 61);
            this.buttonCfrating.TabIndex = 19;
            this.buttonCfrating.Text = "CF Rating";
            this.buttonCfrating.UseVisualStyleBackColor = true;
            this.buttonCfrating.Click += new System.EventHandler(this.buttonCfrating_Click);
            // 
            // LeaderboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.buttonCfrating);
            this.Controls.Add(this.buttonProblemCnt);
            this.Controls.Add(this.buttonAvrgrate);
            this.Controls.Add(this.listboxCoder);
            this.Name = "LeaderboardForm";
            this.Text = "LeaderboardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listboxCoder;
        private System.Windows.Forms.Button buttonAvrgrate;
        private System.Windows.Forms.Button buttonProblemCnt;
        private System.Windows.Forms.Button buttonCfrating;
    }
}