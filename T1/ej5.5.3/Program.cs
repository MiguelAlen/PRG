using System;

namespace ej5._5._3
{
    class Program
    {
        public static bool EsPrimo(int n)
        {
            
            bool primo = true;
            for(int i = 2; i <= n-1; i++)
            {
                if (n%i == 0) { primo = false; }
            }
            return primo;
        }
        public static void Main()
        {
            int n;
            Console.WriteLine("Introduzca un numero: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El numero introducido es primo? {0} ", EsPrimo(n));

        }
    }
}
