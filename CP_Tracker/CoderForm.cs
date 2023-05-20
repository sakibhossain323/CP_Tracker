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
    public partial class CoderForm : Form
    {
        public CoderForm()
        {
            InitializeComponent();
        }

        private void buttonCoder_Click(object sender, EventArgs e)
        {
            this.Hide();
            CoderProfileForm form2 = new CoderProfileForm();
            form2.Show();
        }
    }
}
