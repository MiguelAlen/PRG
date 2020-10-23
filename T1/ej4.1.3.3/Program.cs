using System;

namespace ej4._1._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca 10 números reales");
            double[] numeros = new double[10];
            double media = 0;
            for(int i=0;i<10;i++)
                {
                    Console.Write("Número {0} :", i + 1);
                    numeros[i] = Convert.ToDouble(Console.ReadLine());
                    media += numeros[i];
                }
            media /= 10;
            for(int i = 0; i < 10; i++)
            {
                if (numeros[i] > media) { Console.WriteLine("El número {0} esta por encima de la media.", numeros[i]); };
            }
        }
    }
}
