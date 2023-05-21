using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CP_Tracker
{
    public sealed class CP_Tracker
    {
        private CP_Tracker() { }
        private static CP_Tracker instance;
        public static CP_Tracker Instance()
        {
            if (instance == null)
            {
                instance = new CP_Tracker();
            }
            return instance;
        }
        public static List<Coder> Coder_List = new List<Coder>(); //data reqired**************
        public static List<Faculty> Faculty_List = new List<Faculty>();//data reqired**************

        public static List<string> regular_topic_List = new List<string>();//data reqired**************
        public static List<string> advanced_topic_List = new List<string>();//data reqired**************

        public static string AdminUsername = "Admin";//data reqired**************
        public static string AdminPasswd = "Admin00";//data reqired**************
        static int count = 0;//data reqired**************
        static private DateTime LastDate = new DateTime(2023, 5, 13, 0, 0, 0);//data reqired**************


        // following functions for loading from the database
        public DataSet LoadDataSet(string command)
        {
            DataSet ds = new DataSet();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter(command, con);
                da.Fill(ds);
            }
            return ds;
        }

        public void Load_Coder_List(List<Coder> Coder_List)
        {
            Load_Faculty_List(CP_Tracker.Faculty_List);

            DataSet ds = LoadDataSet("SELECT * FROM Coder");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string username = row.Field<string>("username");
                string pass = row.Field<string>("passwrd");
                string name = row.Field<string>("fullname");
                string phone = row.Field<string>("phone");
                string email = row.Field<string>("email");
                string dept = row.Field<string>("department"); ;
                string cf_id = row.Field<string>("cf_id");
                int cf_rating = row.Field<int>("cf_rating");

                string avg_rating_pblm = row.Field<string>("avg_rating_pblm");
                string avg_wkly_cnt_pblm = row.Field<string>("avg_wkly_cnt_pblm");
                string str_cf_rating = row.Field<string>("str_cf_rating");
                int cur_pblm_avg_rate_week = row.Field<int>("cur_pblm_avg_rate_week");
                int cur_pblm_cnt_week = row.Field<int>("cur_pblm_cnt_week");
                string regular_skill = row.Field<string>("regular_skill");
                string advanced_skill = row.Field<string>("advanced_skill");

                Coder coder = new Coder(username, pass, name, phone, email, dept, cf_id, cf_rating,
                                        avg_rating_pblm, avg_wkly_cnt_pblm, str_cf_rating, cur_pblm_avg_rate_week,
                                        cur_pblm_cnt_week, regular_skill, advanced_skill);
                Coder_List.Add(coder);
            }
        }
        public void Load_Faculty_List(List<Faculty> Faculty_List)
        {
            DataSet ds = LoadDataSet("SELECT * FROM Faculty");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string username = row.Field<string>("username");
                string pass = row.Field<string>("passwrd");
                string name = row.Field<string>("fullname");
                string desg = row.Field<string>("designation");

                Faculty faculty = new Faculty(username, pass, name, desg);
                Faculty_List.Add(faculty);
            }
        }

        public void Load_regular_topic_List(List<string> regular_topic_List)
        {

        }

        public void Load_advanced_topic_List(List<string> advanced_topic_List)
        {

        }
        public void Load_Admin_Info(string Admin_Username, string Admin_Passwd)
        {

        }

        public void Load_count(int count)
        {

        }

        public void Load_Last_Date(DateTime last_date)
        {

        }


        // following functions update the database
        public void Update_DataSet(DataSet ds, string cmd)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, con);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(ds);
            }
        }

        public void Update_Coder_List(List<Coder> Coder_List)
        {

        }
        public void Update_Faculty_List(List<Faculty> Faculty_List)
        {
            DataSet ds = LoadDataSet("SELECT * FROM Faculty");
            
            foreach(Faculty facutly in Faculty_List)
            {
                string username = facutly.Username;

                DataRow[] matchingRows = ds.Tables[0].Select("username = '" + username + "'");
                if (matchingRows.Length > 0)
                {
                    DataRow matchedRow = matchingRows[0];
                    matchedRow["passwrd"] = facutly.Passwd;
                    matchedRow["fullname"] = facutly.Name;
                    matchedRow["designation"] = facutly.Designation;
                }
                else
                {
                    DataRow newRow = ds.Tables[0].NewRow();
                    newRow["username"] = facutly.Username;
                    newRow["passwrd"] = facutly.Passwd;
                    newRow["fullname"] = facutly.Name;
                    newRow["designation"] = facutly.Designation;

                    ds.Tables[0].Rows.Add(newRow);
                }
            }

            Update_DataSet(ds, "SELECT * FROM Faculty");
        }

        public void Update_regular_topic_List(List<string> regular_topic_List)
        {

        }

        public void Update_advanced_topic_List(List<string> advanced_topic_List)
        {

        }

        public void Update_Admin_Info(string Admin_Username, string Admin_Passwd)
        {

        }

        public void Update_count(int count)
        {

        }

        public void Update_Last_Date(DateTime last_date)
        {

        }









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
                var CP_ins = Instance();
                CP_ins.Update_Last_Date(LastDate);
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
            count++;
            var CP_ins = Instance();
            CP_ins.Update_count(count);
            return Faculty_List[count - 1].Name;
        }

        public static void sort_rating()
        {
            Coder_List.Sort((p1, p2) => p1.cf_rating.CompareTo(p2.cf_rating));
        }
        public static void sort_prblm_cnt_week()
        {
            Coder_List.Sort((p1, p2) => p1.curr_prblm_cnt_week.CompareTo(p2.curr_prblm_cnt_week));
        }
        public static void sort_prblm_avrg_rate_week()
        {
            Coder_List.Sort((p1, p2) => p1.curr_prblm_avrg_rate_week.CompareTo(p2.curr_prblm_avrg_rate_week));
        }


    }
}
