using System;

namespace ej5._5._6
{
    class Program
    {
        public static void Triangulo(int n, char letra)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int f = i; f > 0; f--)
                {
                    Console.Write("{0}", letra);
                }
                Console.WriteLine("");
            }
        }
        public static void Main()
        {
            char letra; int ancho;
            Console.WriteLine("El ancho del triangulo: ");
            ancho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La letra que lo compone: ");
            letra = Convert.ToChar(Console.ReadLine());
            Triangulo(ancho, letra);
        }
    }
}
