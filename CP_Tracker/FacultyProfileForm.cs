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
    public partial class FacultyProfileForm : Form
    {
        public FacultyProfileForm()
        {
            InitializeComponent();
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
