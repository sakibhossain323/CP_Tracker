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
    public partial class AdminProfileForm : Form
    {
        public AdminProfileForm()
        {
            InitializeComponent();
        }

        private void buttonRegularSkill_Click(object sender, EventArgs e)
        {
            CP_Tracker.regular_topic_List.Add(textboxRegulerskill.Text);
            textboxRegulerskill.Clear();
        }

        private void buttonAdvancedSkill_Click(object sender, EventArgs e)
        {
            CP_Tracker.advanced_topic_List.Add(textBoxAdvancedskill.Text);
            textBoxAdvancedskill.Clear();   
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLoginForm f1 = new AdminLoginForm();
            f1.Show();
        }
    }
}
