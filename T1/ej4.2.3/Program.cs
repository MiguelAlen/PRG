using System;

namespace ej4._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creando matriz de dos bloques.");
            int[][] notas;
            notas = new int[2][];
            Console.Write("Tamaño deseado del primer bloque:");
            notas[0] = new int[Convert.ToInt32(Console.ReadLine())];
            Console.Write("Tamaño deseado del segundo bloque:");
            notas[1] = new int[Convert.ToInt32(Console.ReadLine())];
            Console.WriteLine("Introduce valores para ambos bloques.");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Bloque {0}:",i+1);
                for (int j = 0; j < notas[i].Length; j++)
                {
                    notas[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int maximo = Int32.MinValue;
            for (int i = 0; i < notas.Length; i++)
            {
                for (int j = 0; j < notas[i].Length; j++)
                {
                    if (notas[i][j] > maximo) { maximo = notas[i][j];}
                }
                Console.WriteLine("El máximo del bloque {0} es: {1}",i+1 ,maximo);
            }
            Console.WriteLine("El máximo de ambos bloques es: {0}", maximo);
        }
    }
}
