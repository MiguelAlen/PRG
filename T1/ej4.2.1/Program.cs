using System;

namespace ej4._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[2, 10];
            Console.WriteLine("Introduce 20 numeros para llenar dos bloques de 10 numeros: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    numeros[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            // Y mostramos esos valores
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(" {0}", numeros[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
