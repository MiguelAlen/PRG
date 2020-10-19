using System;

namespace ej3._1._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a+2;
            int c = -3;
            b-=3;c*=2;++c;a *= b;
            Console.WriteLine("{0},{1},{2}", a, b, c);
        }
    }
}
