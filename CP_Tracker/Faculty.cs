using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Tracker
{
    public class Faculty
    {
        private string username;
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (CP_Tracker.VerifyUsername(value))
                {
                    username = value;
                }

            }
        }

        private string passwd;
        public string Passwd
        {
            get
            {
                return passwd;
            }
            set
            {
                if (Utility.VerifyPass(value))
                {
                    passwd = value;
                }

            }
        }
        public string Name { get; set; }
        public string Designation { get; set; }

        public Faculty(string _username, string _passwd, string _name, string _des)
        {
            this.Username = _username;
            this.Passwd = _passwd;

            this.Name = _name;
            this.Designation = _des;
        }

    }
}
