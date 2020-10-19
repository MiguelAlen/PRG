using System;


namespace ej3._2._6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            for (int i = 0; i <16; i++) 
            {
                for (int j = 0; j < 16; j++) 
                {
                    string num = numero.ToString("X2");
                    Console.Write("{0} ", num);
                    numero++;
                }
                Console.Write("\n");
            }
        }
    }
}
