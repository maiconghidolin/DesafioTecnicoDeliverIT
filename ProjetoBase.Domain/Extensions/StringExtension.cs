using System;

namespace ProjetoBase.Domain.Extensions
{
    public static class StringExtension
    {

        public static bool IsNotNullOrEmpty(this string s)
        {
            if (!String.IsNullOrEmpty(s))
                return true;
            else
                return false;
        }

        public static bool IsNullOrEmpty(this string s)
        {
            if (String.IsNullOrEmpty(s))
                return true;
            else
                return false;
        }

        public static int ToInt(this string s)
        {
            try
            {
                return Convert.ToInt32(s);
            }
            catch { return 0; }
        }

        public static decimal ToDecimal(this string s)
        {
            try { return Convert.ToDecimal(s); }
            catch { return 0; }
        }

        public static DateTime ToDate(this string s)
        {
            try { return Convert.ToDateTime(s); }
            catch { return new DateTime(); }
        }

    }
}
