using System;
using System.Drawing;
namespace _3._2._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce valor rojo (0~255) :");
            int rojo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce valor verde (0~255) :");
            int verde = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce valor azul (0~255) :");
            int azul = Convert.ToInt32(Console.ReadLine());

            string color = rojo.ToString("X2") + verde.ToString("X2") + azul.ToString("X2");


            var cc1 = System.Drawing.ColorTranslator.FromHtml("#"+color);

            Console.ForegroundColor = cc1;

            Console.WriteLine("\nEl valor hexadecimal es: {0}", color);

        }
    }
}
