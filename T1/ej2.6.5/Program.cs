using System;

namespace ej2._6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el alto: ");
            int y = int.Parse(Console.ReadLine());
            int x = y;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                    
                 
                }
                Console.WriteLine();
                x--;
            }

        }
    }
}
