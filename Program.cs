using System;
using System.Linq;
using System.Text;

namespace CodeWars
{
    class Program
    {

        static void Main(string[] args)
        {

            string str = "TestController";
            Console.WriteLine(Kata.ToUnderscore(str));

        }


    }





    public static class Kata
    {
        public static string ToUnderscore(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            if (str.Length < 2)
            {
                return str;
            }
            var sb = new StringBuilder();
            sb.Append(char.ToLowerInvariant(str[0]));
            for (int i = 1; i < str.Length; ++i)
            {
                char c = str[i];
                if (char.IsUpper(c))
                {
                    sb.Append('_');
                    sb.Append(char.ToLowerInvariant(c));
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }


}

    