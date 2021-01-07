using System;

namespace ej5._5._6
{
    class Program
    {
        public static string Triangulo(int n, char letra)
        {
            string triangulo = "";
            for (int i = 0; i < n; i++)
            {
                for (int f = 4; f > 0; f--)
                {
                    triangulo + ("{0}", letra);
                }
            }
        }
        public static void Main()
        {
            char letra; int ancho;
            Console.WriteLine("El ancho del triangulo: ");
            ancho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La letra que lo compone: ");
            Console.WriteLine("{0}", Triangulo(ancho, letra));
        }
    }
}
