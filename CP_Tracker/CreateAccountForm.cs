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
    public partial class CreateAccountForm : Form
    {
        public static CreateAccountForm instance;
        public string username;
        public string password;
        public CreateAccountForm()
        {
            InitializeComponent();
            instance = this;
            
        }

        private void linkCoder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (CP_Tracker.VerifyUsername(textboxUsername.Text) && Utility.VerifyPass(textboxPassword.Text)) { 
                    username = textboxUsername.Text;
                    password = textboxPassword.Text;
                    this.Hide();
                    CoderForm Form2 = new CoderForm();
                    Form2.Show();
                }
            }
            catch(CustomException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkFaculty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (CP_Tracker.VerifyUsername(textboxUsername.Text) && Utility.VerifyPass(textboxPassword.Text))
                {
                    username = textboxUsername.Text;
                    password = textboxPassword.Text;
                    this.Hide();
                    FacultyForm Form2 = new FacultyForm();
                    Form2.Show();
                }
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textboxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
