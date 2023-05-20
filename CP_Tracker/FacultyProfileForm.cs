using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_Tracker
{
    public partial class FacultyProfileForm : Form
    {
        public static string Username;
        public FacultyProfileForm()
        {
            InitializeComponent();
            foreach(var temp in CP_Tracker.Faculty_List)
            {
                if(temp.Username == Username)
                {
                    labelName.Text = temp.Name;
                    labelDesignation.Text = temp.Designation;
                    int cnt = 0;
                    foreach (Coder x in CP_Tracker.Coder_List)
                    {
                        if (x.assigned_faculty == temp.Name)
                        {
                            cnt++;
                        }
                    }
                    labelCodersAssigned.Text = "Coders Assigned: " + Convert.ToString(cnt);
                    break;
                }
            }
        }
        public static void launch(string _username)
        {
            Username = _username;
        }

        private void buttonShowStudentList_Click(object sender, EventArgs e)
        {
            this.Hide();
            CoderListForm form2 = new CoderListForm();
            form2.Show();
        }

        private void FacultyProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form2 = new LoginForm();
            form2.Show();
        }
    }
}
