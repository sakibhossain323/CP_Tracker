using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            Coder temp = new Coder(CreateAccountForm.instance.username, CreateAccountForm.instance.password, textboxFullName.Text, textboxPhone.Text, textboxEmail.Text, textboxDept.Text, textboxcfid.Text, Convert.ToInt32(textboxcfRating.Text));
            CP_Tracker.Coder_List.Add(temp);
            var CP_ins = CP_Tracker.Instance();
            CP_ins.Update_Coder_List(CP_Tracker.Coder_List);
            this.Hide();
            CoderProfileForm.Username = CreateAccountForm.instance.username;
            CoderProfileForm f2 = new CoderProfileForm();
            f2.Show();
        }
    }
}
