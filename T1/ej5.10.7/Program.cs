using System;

namespace ej5._10._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;
            Console.WriteLine("Introduce una palabra:");
            string s = Console.ReadLine();
            int i = s.Length;
            for (int j = i - 1; j >= 0; j--)
            {
                str = str + s[j];
            }
            if (str == s)
            {
                Console.WriteLine(s + "es palindrome");
            }
            else
            {
                Console.WriteLine(s + "no es palindrome");
            }
        }
    }
}
