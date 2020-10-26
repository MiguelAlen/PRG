using System;

namespace ej._4._1._3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Introduce 4 numeros");
            int[] numeros = new int[4];
            int maximo = Int32.MinValue;// tmb se puede con Int32.MaxValue
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Introduce el numero {0}:", i + 1);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                if (maximo < numeros[i]) { maximo = numeros[i]; }
            }
            Console.WriteLine("El numero {0} es el valor mas alto.", maximo);
        }   
    }
}
