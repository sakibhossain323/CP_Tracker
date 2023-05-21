using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Tracker
{
    public class Coder
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

        public string name;
        public string phone_no;
        public string email;
        public string department;
        public string assigned_faculty;

        public string cf_id;
        private int Cf_rating;
        public int cf_rating
        {
            get { return Cf_rating; }
            set
            {
                Cf_rating = value;
                this.Levelup();
            }
        }
        public List<Problem> problem_List;

        public string string_avrg_rating_prblm = "";
        public string string_weekly_count_prblm = "";
        public string string_cf_rating = "";

        public int curr_prblm_avrg_rate_week = 0;
        public int curr_prblm_cnt_week = 0;

        public int level = 1;
        public string regular_skills = "";
        public string advanced_skills = "";


        public Coder(string _username, string _passwd, string _name, string _phone_no, string _email, string _department, string _cf_id, int cf_rating)
        {

            this.problem_List = new List<Problem>();

            this.assigned_faculty = CP_Tracker.Get_faculty();

            this.Levelup();

            this.Username = _username;
            this.Passwd = _passwd;
            this.name = _name;
            this.phone_no = _phone_no;
            this.email = _email;
            this.department = _department;
            this.cf_id = _cf_id;
            this.cf_rating = cf_rating;
        }

    public Coder(string _username, string _passwd, string _name, string _phone_no, string _email, string _department, string _cf_id, int _cf_rating, string _string_avrg_rating_prblm, string _string_weekly_count_prblm, string _string_cf_rating, int _curr_prblm_avrg_rate_week, int _curr_prblm_cnt_week, string _regular_skill, string _advanced_skill) :this(_username, _passwd, _name, _phone_no, _email, _department, _cf_id, _cf_rating)
    {
            this.string_cf_rating = _string_cf_rating;
            this.string_weekly_count_prblm = _string_weekly_count_prblm;
            this.string_avrg_rating_prblm = _string_avrg_rating_prblm;
            this.curr_prblm_avrg_rate_week = _curr_prblm_avrg_rate_week;
            this.curr_prblm_cnt_week = _curr_prblm_cnt_week;
            this.regular_skills = _regular_skill;
            this.advanced_skills = _advanced_skill;
    }

    public void Solved_Problem_Update(string problem_name, int problem_rating)
        {
            Problem temp = new Problem(problem_name, problem_rating);
            problem_List.Add(temp);
        }

        public void Levelup()
        {
            if (this.cf_rating >= 1400)
            {
                this.level = 2;
            }
            else this.level = 1;
        }
        public void Upadate_skill(string skill_name)
        {
            int indx = CP_Tracker.regular_topic_List.IndexOf(skill_name);
            if (indx < CP_Tracker.regular_topic_List.Count)
            {
                if (indx < this.regular_skills.Length)
                {
                    this.regular_skills = this.regular_skills.Substring(0, indx) + "1" + this.regular_skills.Substring(indx + 1);
                    return;
                }
                else
                {
                    while (indx != this.regular_skills.Length - 2) this.regular_skills += "0";
                    this.regular_skills += "1";
                    return;
                }
            }
            if(this.level == 2)
            {
                if (indx < CP_Tracker.advanced_topic_List.Count)
                {
                    indx = CP_Tracker.advanced_topic_List.IndexOf(skill_name);
                    if (indx < this.advanced_skills.Length)
                    {
                        this.advanced_skills = this.advanced_skills.Substring(0, indx) + "1" + this.advanced_skills.Substring(indx + 1);
                        return;
                    }
                    else
                    {
                        while (indx != this.advanced_skills.Length - 2) this.advanced_skills += "0";
                        this.advanced_skills += "1";
                        return;
                    }
                }
            }
        }

        public int Problm_cnt_week()
        {
            int ret = 0;
            foreach (Problem x in this.problem_List)
            {
                TimeSpan dif = x.date - DateTime.Now;
                if (dif.TotalDays <= 7)
                {
                    ret++;
                }
            }
            return ret;
        }

        public int Problm_avrg_rate_week()
        {
            int total = 0;

            foreach (Problem x in this.problem_List)
            {
                TimeSpan dif = x.date - DateTime.Now;
                if (dif.TotalDays <= 7)
                {
                    total += x.rating;
                }
            }
            this.Problm_cnt_week();

            return (int)(total / curr_prblm_cnt_week);
        }

        public string Progress_cf_rating(int _rating)
        {
            int dif = (_rating - this.cf_rating) / 100;
            this.string_cf_rating += Convert.ToString(dif);
            this.cf_rating = _rating;
            this.Levelup();
            return Utility.Format(this.string_cf_rating);
        }

        public string Progress_problm_cnt_week(int _prblm_cnt)
        {
            int dif = (this.curr_prblm_cnt_week - _prblm_cnt) / 10;
            this.string_weekly_count_prblm += Convert.ToString(dif);
            this.curr_prblm_cnt_week = _prblm_cnt;
            return Utility.Format(this.string_weekly_count_prblm);
        }
        public string Progress_avrg_rate_week(int _avrg_rate)
        {
            int dif = (this.curr_prblm_avrg_rate_week - _avrg_rate) / 100;
            this.string_avrg_rating_prblm += Convert.ToString(dif);
            this.curr_prblm_avrg_rate_week = _avrg_rate;
            return Utility.Format(this.string_avrg_rating_prblm);
        }

    }
}
