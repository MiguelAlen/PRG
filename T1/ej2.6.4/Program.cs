using System;

namespace ej2._6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el ancho: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el alto: ");
            int y = int.Parse(Console.ReadLine());
            for(int i = 0; i < y; i++)
            {
                for(int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}
