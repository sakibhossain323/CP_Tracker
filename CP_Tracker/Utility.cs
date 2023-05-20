using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Tracker
{
    public static class Utility
    {

        public static string Format(string format)
        {
            int num, sml = int.MaxValue;
            List<int> ara = new List<int>();

            for (int i = 0; i < format.Length; i++)
            {
                if (format[i] == '-')
                {
                    num = Convert.ToInt32(format.Substring(i, 2));
                    i++;
                }
                else
                {
                    num = Convert.ToInt32(format.Substring(i, 1));
                }
                sml = Math.Min(sml, num);
                ara.Add(num);
            }

            string ret = "";

            for (int i = 0; i < ara.Count; i++)
            {

                ara[i] -= sml;
                ret += Convert.ToString(ara[i]);
            }
            return ret;
        }


        public static bool VerifyPass(string password)
        {
            if (password.Length < 6)
            {
                throw new CustomException("Password should be at least 6 characters long!");
            }

            if (!ContainsLowerCase(password))
            {
                throw new CustomException("Password should contain at least one lowercase letter!");
            }

            if (!ContainsUpperCase(password))
            {
                throw new CustomException("Password should contain at least one uppercase letter!");
            }

            if (!ContainsDigit(password) && !ContainsSpecialCharacter(password))
            {
                throw new CustomException("Password should contain at least one digit or one special character!");
            }

            return true;
        }

        private static bool ContainsLowerCase(string password)
        {
            return password.Any(char.IsLower);
        }

        private static bool ContainsUpperCase(string password)
        {
            return password.Any(char.IsUpper);
        }

        private static bool ContainsDigit(string password)
        {
            return password.Any(char.IsDigit);
        }

        private static bool ContainsSpecialCharacter(string password)
        {
            return password.Any(c => !char.IsLetterOrDigit(c));
        }

    }
}
