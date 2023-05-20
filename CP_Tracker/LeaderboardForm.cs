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
    public partial class LeaderboardForm : Form
    {
        public LeaderboardForm()
        {
            InitializeComponent();
        }

        private void buttonCfrating_Click(object sender, EventArgs e)
        {
            listboxCoder.Items.Clear();
            CP_Tracker.sort_rating();
            listboxCoder.Items.Add("Name \t\t\t CF Rating");
            foreach(var temp in CP_Tracker.Coder_List)
            {
                listboxCoder.Items.Add(temp.name + " \t\t " + Convert.ToString(temp.cf_rating));
            }
        }

        private void buttonProblemCnt_Click(object sender, EventArgs e)
        {
            listboxCoder.Items.Clear();
            CP_Tracker.sort_prblm_cnt_week();
            listboxCoder.Items.Add("Name \t\t Problem Count(Weekly)");
            foreach (var temp in CP_Tracker.Coder_List)
            {
                listboxCoder.Items.Add(temp.name + " \t\t " + Convert.ToString(temp.curr_prblm_cnt_week));
            }
        }

        private void buttonAvrgrate_Click(object sender, EventArgs e)
        {
            listboxCoder.Items.Clear();
            CP_Tracker.sort_prblm_avrg_rate_week();
            listboxCoder.Items.Add("Name \t\t Solved Problem Avrg Rating");
            foreach (var temp in CP_Tracker.Coder_List)
            {
                listboxCoder.Items.Add(temp.name + " \t\t " + Convert.ToString(temp.curr_prblm_avrg_rate_week));
            }
        }
    }
}
