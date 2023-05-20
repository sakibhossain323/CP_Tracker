using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_Tracker
{
    public partial class CoderListForm : Form
    {
        public CoderListForm()
        {
            InitializeComponent();
        }

        private void linkLabelProfileBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FacultyProfileForm Form2 = new FacultyProfileForm();
            Form2.ShowDialog();
        }
    }
}
