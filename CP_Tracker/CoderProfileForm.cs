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
    public partial class CoderProfileForm : Form
    {
        public CoderProfileForm()
        {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form2 = new LoginForm();
            form2.Show();
        }

        private void buttonShowGraph_Click(object sender, EventArgs e)
        {
            GraphForm form2 = new GraphForm();
            form2.Show();
        }

        private void buttonLeaderboard_Click(object sender, EventArgs e)
        {

        }
    }
}
