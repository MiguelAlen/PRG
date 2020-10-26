using System;

namespace ej4._1._3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] vectores = new int[2, 3];
            for(int i = 0; i < 2; i++) 
            {
                Console.WriteLine("Introduce el vector {0}:", i+1);
                for (int j=0; j <3; j++)
                {
                    Console.WriteLine("Componente {0}:", j + 1);
                    vectores[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int pEscalar = (vectores[0, 0] * vectores[1, 0] +
                            vectores[0, 1] * vectores[1, 1] +
                            vectores[0, 2] * vectores[1, 2]);
            Console.WriteLine("El prosucto escalar de ambos vectores es: {0}", pEscalar);
        }
    }
}
