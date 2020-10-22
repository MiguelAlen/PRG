using System;

namespace _4._1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numeros = new float[5];
            Console.Write("Número 1: ");
            numeros[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número 2: ");
            numeros[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número 3: ");
            numeros[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número 4: ");
            numeros[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número 5: ");
            numeros[4] = Convert.ToInt32(Console.ReadLine());
            for (int i = 4; i >= 0; i--) { Console.WriteLine(numeros[i]); }
        }
    }
}
