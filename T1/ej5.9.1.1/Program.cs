using System;

namespace ej5._9._1._1
{
    class Program
    {
        public static void Main()
        {
            Random r = new Random();
            int aleatorio = r.Next(1, 7);
            Console.WriteLine("Tiras el dado (d6): {0}", aleatorio);
        }

    }
}
