using System;

namespace ej2._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int resto;
            int i = 2;
            Console.WriteLine("Introduzca el numero que quiere como producto de su factores primos:");
            numero = int.Parse(Console.ReadLine());
            resto = numero;
            if (resto == 0 || resto == 1) { Console.WriteLine("No es ni primo ni compuesto"); }
            while (resto != 1)
            {
                if (resto != 0)
                {
                    if (resto % i == 0)
                    {
                        resto /= i;
                        Console.WriteLine(i);
                    }
                    else { i++; };

                }
                else { break; };

            }
            { Console.WriteLine("\n\n"); }

        }

    }
}
