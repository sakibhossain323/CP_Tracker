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
        public static string Username;

        public CoderProfileForm()
        {
            InitializeComponent();
            foreach (var temp in CP_Tracker.Coder_List)
            {
                if (temp.Username == Username)
                {
                    labelName.Text = temp.name + "(Level " + Convert.ToString(temp.level) + ")";
                    labelcfid.Text = temp.cf_id + " (Rating: " + Convert.ToString(temp.cf_rating) + ")";
                    labelProblemsSolved.Text = "Problems Solved This Week " + Convert.ToString(temp.curr_prblm_cnt_week);
                    labelAvrgrate.Text = "Average Rating of Solved Problems " + Convert.ToString(temp.curr_prblm_avrg_rate_week);
                    break;
                }
            }
        }

        

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form2 = new LoginForm();
            form2.Show();
        }

        private void buttonShowGraph_Click(object sender, EventArgs e)
        {
            GraphForm form3 = new GraphForm();
            form3.Show();
        }

        private void buttonLeaderboard_Click(object sender, EventArgs e)
        {
            LeaderboardForm form4 = new LeaderboardForm();
            form4.Show();
        }

        private void CoderProfileForm_Load(object sender, EventArgs e)
        {

        }
    }
}
