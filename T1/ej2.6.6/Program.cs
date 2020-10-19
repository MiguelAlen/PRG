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
                    if (i == 0 || i == y-1) {Console.Write("*");}
                    else 
                    {
                        if (j == 0 || j == x - 1) { Console.Write("*"); }
                        else { Console.Write(" "); }
                    }
                }
            Console.WriteLine();
            }
            
        }
    }
}
