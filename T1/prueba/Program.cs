using System;

namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determinante de la matriz a introducir: ");
            int n = int.Parse(Console.ReadLine().ToString());
            Console.WriteLine("Orden de matriz introducido: " + n.ToString());
            if (n > 0)
            {
                double[,] myMatrix = new double[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine("Introducir elemento [" + (i + 1) + "]" + "[" + (j + 1) + "]: ");
                        myMatrix[i, j] = double.Parse(Console.ReadLine().ToString());
                    }
                }
                Console.WriteLine("Matriz introducida: ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(myMatrix[i, j].ToString() + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
