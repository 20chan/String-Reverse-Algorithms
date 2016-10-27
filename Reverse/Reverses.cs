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

        public static string XOR(string str)
        {
            char[] chars = str.ToCharArray();
            int len = str.Length - 1;

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
            return string.Concat(_yield(str));
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

        public static unsafe string Pointer(string str)
        {
            int len = str.Length;
            char* reversed = stackalloc char[len];
            
            fixed (char* c = str)
            {
                int i = 0;
                int j = i + len - 1;
                while (i < len)
                {
                    reversed[i++] = c[j--];
                }
            }
            return new string(reversed, 0, len);
        }

        public static string Concat(string str)
        {
            return string.Concat(Enumerable.Reverse(str));
        }

        public static string StackSB(string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var c in str)
                stack.Push(c);
            StringBuilder sb = new StringBuilder();
            while (stack.Count > 0)
                sb.Append(stack.Pop());
            return sb.ToString();
        }

        public static string StackYield(string str)
        {
            return string.Concat(_stackYield(str));
        }
        
        private static IEnumerable<char> _stackYield(string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var c in str)
                stack.Push(c);
            while (stack.Count > 0)
                yield return stack.Pop();
        }

        public static string Stack(string str)
        {
            Stack<char> stack = new Stack<char>(str);
            return string.Concat(stack);
        }

        public static string Recursive(string str)
        {
            return str == "" ? "" : Recursive(string.Concat(str.Skip(1))) + str[0];
        }
    }
}
