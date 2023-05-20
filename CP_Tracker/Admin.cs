using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Tracker
{
    public static class Admin
    {
        public static string Username
        {
            get
            {
                return CP_Tracker.AdminUsername;
            }
            set
            {
                if (CP_Tracker.VerifyUsername(value))
                {
                    CP_Tracker.AdminUsername = value;
                }
            }
        }

        public static string Passwd
        {
            get
            {
                return CP_Tracker.AdminPasswd;
            }
            set
            {
                if (Utility.VerifyPass(value))
                {
                    CP_Tracker.AdminPasswd = value;
                }

            }
        }
        public static void Add_regular_topic(string topic)
        {
            CP_Tracker.regular_topic_List.Add(topic);
        }

        public static void Add_advanced_topic(string topic)
        {
            CP_Tracker.advanced_topic_List.Add(topic);
        }
    }
}
