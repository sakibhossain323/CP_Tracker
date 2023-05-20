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
        public Dictionary<string, bool> skills;

        public Coder()
        {
            this.skills = new Dictionary<string, bool>();
            foreach (string s in CP_Tracker.regular_topic_List)
            {
                skills[s] = false;
            }

            this.problem_List = new List<Problem>();

            this.assigned_faculty = CP_Tracker.Get_faculty();
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
                foreach (string s in CP_Tracker.advanced_topic_List)
                {
                    skills[s] = false;
                }
            }
        }
        public void Upadate_skill(string skill_name)
        {
            if (skills.ContainsKey(skill_name))
            {
                skills[skill_name] = true;
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
