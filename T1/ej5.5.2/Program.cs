using System;

namespace ej5._5._2
{
    class Program
    {
        public static void PedirEntero(int n)
        {
            int min = 1800, max = 2100;
            bool acierto = false;
            while (acierto)
            {
                if (min <= n || n <= max) { acierto = true; }
                else { acierto = false; }
            }
        }
        public static void Main()
        {
            int n;
            Console.WriteLine("Introduzca un numero: ");
            n = Convert.ToInt32(Console.ReadLine());


        }
    }
}
