using System;

namespace ej4._1._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantos numeros va a introducir? ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            double[] numeros = new double [cantidad];
            Console.WriteLine("Introduce {0} números. ", cantidad);
            int j = 0;
            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write("Número {0} :", i);
                numeros[j] = Convert.ToInt32(Console.ReadLine());
                j++;
            }
            double media = 0;
            for (int k = 0; k < cantidad; k++) { media += numeros[k]; }
            media /= cantidad;
            Console.WriteLine("La media es: {0}", media);

        }
    }
}
