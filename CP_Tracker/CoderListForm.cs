using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CP_Tracker
{
    public partial class CoderListForm : Form
    {
        public CoderListForm()
        {
            InitializeComponent();
            listboxCoder.Items.Add("Coder Name\tCF Rating\t Level");
            foreach (var temp in CP_Tracker.Faculty_List)
            {
                if (temp.Username == FacultyProfileForm.Username)
                {
                    
                    foreach (Coder x in CP_Tracker.Coder_List)
                    {
                        if (x.assigned_faculty == temp.Name)
                        {
                            listboxCoder.Items.Add(x.name + "\t" + x.cf_rating + "\t " + Convert.ToString(x.level));
                        }
                    }
                    break;
                }
            }
        }

        private void linkLabelProfileBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FacultyProfileForm Form2 = new FacultyProfileForm();
            Form2.ShowDialog();
        }
    }
}
