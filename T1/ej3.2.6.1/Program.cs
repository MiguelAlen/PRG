using System;

namespace ej3._2._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el nuemero :");
            int numero = Convert.ToInt32(Console.ReadLine());
            //int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("En hexagesimal : {0}", Convert.ToString(numero, 16));
            Console.WriteLine("En binario : {0}", Convert.ToString(numero, 2));

        }
    }
}
