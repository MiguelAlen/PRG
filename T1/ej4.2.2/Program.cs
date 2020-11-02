using System;

namespace ej4._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] textos = new string[2, 6];
            Console.WriteLine("Introduce 2 bloques de 6 cadenas de texto: ");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Bloque {0}", i+1);
                for (int j = 0; j < 6; j++)
                {
                    textos[i, j] = Convert.ToString(Console.ReadLine());
                }
            }
            Console.WriteLine("Cadena de texto a buscar: ");
            string buscar = Convert.ToString(Console.ReadLine());
            bool encontrado = false;
            for (int i = 0; i < 2 && encontrado == false; i++)
            {
                for (int j = 0; j < 6 && encontrado == false; j++)
                {
                    encontrado = buscar.Equals(textos[i, j]);
                }
            }
            if (encontrado == true) { Console.WriteLine("Esta presente"); }
            else { Console.WriteLine("No esta"); }
        }
    }
}
