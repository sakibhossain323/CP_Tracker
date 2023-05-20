using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Tracker
{
    public static class CP_Tracker
    {
        public static List<Coder> Coder_List = new List<Coder>(); //data reqired**************
        public static List<Faculty> Faculty_List = new List<Faculty>();//data reqired**************

        public static List<string> regular_topic_List = new List<string>();//data reqired**************
        public static List<string> advanced_topic_List = new List<string>();//data reqired**************

        public static string AdminUsername;//data reqired**************
        public static string AdminPasswd;//data reqired**************
        static int count = 0;//data reqired**************
        static private DateTime LastDate = new DateTime(2023, 5, 13, 0, 0, 0);//data reqired**************

        public static void Tick()
        {
            TimeSpan dif = DateTime.Now - LastDate;
            if (dif.TotalDays >= 7)
            {
                foreach (var c in Coder_List)
                {
                    c.curr_prblm_cnt_week = c.Problm_cnt_week();
                    c.curr_prblm_avrg_rate_week = c.Problm_avrg_rate_week();
                    c.string_weekly_count_prblm += c.Progress_problm_cnt_week(c.curr_prblm_cnt_week);
                    c.string_avrg_rating_prblm += c.Progress_avrg_rate_week(c.curr_prblm_avrg_rate_week);
                }
                LastDate = DateTime.Now;
            }
        }


        public static bool Verify_Login(string name_, string passwd_)
        {
            foreach (Coder x in Coder_List)
            {
                if (x.Username == name_ && x.Passwd == passwd_)
                {
                    return true;
                }
            }

            foreach (Faculty x in Faculty_List)
            {
                if (x.Username == name_ && x.Passwd == passwd_)
                {
                    return true;
                }
            }
            return false;

        }


        public static bool Verify_Admin_Login(string name_, string passwd_)
        {
            if (Admin.Username == name_ && Admin.Passwd == passwd_) return true;
            return false;
        }

        public static bool VerifyUsername(string _usrname)
        {
            foreach (Faculty x in Faculty_List)
            {
                if (x.Username == _usrname) throw new CustomException("Username is already taken!");
            }
            foreach (Coder x in Coder_List)
            {
                if (x.Username == _usrname) throw new CustomException("Username is already taken!");
            }
            return true;
        }

        public static void Faculty_wants_Coder_list(string Faculty_name)
        {
            foreach (Coder x in Coder_List)
            {
                if (x.assigned_faculty == Faculty_name)
                {
                    ///write code here xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
                }
            }
        }

        public static void Faculty_wants_one_Coder_info(string Faculty_name, string Coder_name)
        {
            foreach (Coder x in Coder_List)
            {
                if (x.name == Coder_name && x.assigned_faculty == Faculty_name)
                {
                    ///write code here xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
                }
            }
        }

        public static string Get_faculty()
        {
            if (count > Faculty_List.Count - 1) count = 0;
            return Faculty_List[count++].Name;
        }
    }
}
