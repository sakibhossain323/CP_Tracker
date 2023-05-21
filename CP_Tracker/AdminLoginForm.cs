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
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textboxUsername.Text == CP_Tracker.AdminUsername && textboxPassword.Text == CP_Tracker.AdminPasswd)
            {
                this.Hide();
                AdminProfileForm f2 = new AdminProfileForm();
                f2.Show();
            }
            else MessageBox.Show("Incorrect Username or Password!");
        }

        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
