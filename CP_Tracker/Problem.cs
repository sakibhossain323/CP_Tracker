using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Tracker
{
    public class Problem
    {
        public string name;
        public int rating;
        public DateTime date;
        public Problem(string name, int rating)
        {
            this.name = name;
            this.rating = rating;
            date = DateTime.Now;
        }
    }
}
