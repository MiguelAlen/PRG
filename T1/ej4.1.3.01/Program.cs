using System;

namespace _4._1._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[6];
            int j = 0;
            Console.WriteLine("Introduce 6 números. ");
            for (int i = 1; i <= 6; i++) 
            {
                Console.Write("Número {0} :", i);
                numeros[j] = Convert.ToInt32(Console.ReadLine());
                j++;
            } 
            for (int k = 5; k >= 0; k--) 
            {
                Console.WriteLine("{0}", numeros[k]);
            }
            
        }
    }
}
