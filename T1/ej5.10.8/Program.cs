using System;

namespace ej5._10._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce dos números, A y B");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int r = 1, mcd =1;
            while (r != 0) 
            {
                mcd = B;
                r = A % B;
                A = B;
                B = r;
            }
            Console.WriteLine("El mcd és {0}.", mcd);
        }
    }
}
