using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse
{
    public static class Reverses
    {
        public static string Iterator(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
                result.Append(str[i]);
            return result.ToString();
        }

        public static string XOR(string s)
        {
            char[] chars = s.ToCharArray();
            int len = s.Length - 1;

            for (int i = 0; i < len; i++, len--)
            {
                chars[i] ^= chars[len];
                chars[len] ^= chars[i];
                chars[i] ^= chars[len];
            }

            return new string(chars);
        }

        public static string Linq(string str)
        {
            return string.Join("", str.Reverse());
        }

        public static string Array(string str)
        {
            char[] chars = str.ToCharArray();
            System.Array.Reverse(chars);
            return new string(chars);
        }

        public static string Yield(string str)
        {
            return string.Join("", _yield(str));
        }

        private static IEnumerable<char> _yield(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
                yield return str[i];
        }

        public static string VisualBasic(string str)
        {
            return Microsoft.VisualBasic.Strings.StrReverse(str);
        }
    }
}
