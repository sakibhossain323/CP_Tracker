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
    public partial class FacultyForm : Form
    {
        public FacultyForm()
        {
            InitializeComponent();

        }

        private void buttonFaculty_Click(object sender, EventArgs e)
        {
            Faculty temp = new Faculty(CreateAccountForm.instance.username, CreateAccountForm.instance.password, textBoxFullName.Text, textboxDesignation.Text);
            CP_Tracker.Faculty_List.Add(temp);
            var CP_ins = CP_Tracker.Instance();
            CP_ins.Update_Faculty_List(CP_Tracker.Faculty_List);
            this.Hide();
            FacultyProfileForm.launch(CreateAccountForm.instance.username);
            FacultyProfileForm f2 = new FacultyProfileForm();
            
            f2.Show();
        }
    }
}
