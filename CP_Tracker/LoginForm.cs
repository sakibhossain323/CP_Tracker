using System;
using System.CodeDom.Compiler;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


        private void buttonEnter_Click_1(object sender, EventArgs e)
        {
            
            this.Hide();
            foreach (var temp in CP_Tracker.Coder_List)
            {
                if (textboxUsername.Text == temp.Username && textboxPassword.Text == temp.Passwd)
                {
                    CoderProfileForm form2 = new CoderProfileForm();
                    form2.Show();
                    return;
                }
            }
            foreach (var temp in CP_Tracker.Faculty_List)
            {
                if(textboxUsername.Text == temp.Username && textboxPassword.Text == temp.Passwd)
                {
                    FacultyProfileForm form3 = new FacultyProfileForm();
                    form3.Show();
                    return;
                }
            }
            MessageBox.Show("Username or Password is incorrect!");
        }

        private void linkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateAccountForm newForm = new CreateAccountForm();
            newForm.Show();
        }
    }
}
