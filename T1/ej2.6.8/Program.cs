using System;

namespace ej2._6._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio;
            int efectivo;
            
            Console.WriteLine("Introduzca el precio de la compra :");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el efectivo:");
            efectivo = int.Parse(Console.ReadLine());
            Console.WriteLine("Su cambio es:");
            if (efectivo == precio) { Console.WriteLine("No hay cambio"); }
            if (efectivo < precio) { Console.WriteLine("Inserte mas efectivo"); }
            if (efectivo > precio)
            {
                efectivo -= precio;
                while (efectivo > 100) { Console.WriteLine("100"); efectivo -= 100; }
                while (efectivo > 50) { Console.WriteLine("50"); efectivo -= 50; }
                while (efectivo > 20) { Console.WriteLine("20"); efectivo -= 20; }
                while (efectivo > 10) { Console.WriteLine("10"); efectivo -= 10; }
                while (efectivo > 5) { Console.WriteLine("5"); efectivo -= 5; }
                while (efectivo > 2) { Console.WriteLine("2"); efectivo -= 2; }
                while (efectivo >= 1) { Console.WriteLine("1"); efectivo -= 1; }
            }
            

        }

    }
}
