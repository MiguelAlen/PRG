using System;

namespace ej4._1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] numeros = new double [4];

            Console.Write("Numero 1: ");
            numeros[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Numero 2: ");
            numeros[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Numero 3: ");
            numeros[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Numero 4: ");
            numeros[3] = Convert.ToDouble(Console.ReadLine());
            double media = 0;
            for (int i = 0; i < 4; i++) { media += numeros[i]; }
            media /= 4;
            Console.WriteLine("La media de "+ numeros +" es [0]" , media);
        }
    }
}
