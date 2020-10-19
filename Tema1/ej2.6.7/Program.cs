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
            for (int i = y; i > -1; i--)
            {
                for (int j = y; j > i; j--)
                {
                    Console.Write("*");
                }
                for (int j = 1; j < i+1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
                x--;
            }

        }
    }
}
