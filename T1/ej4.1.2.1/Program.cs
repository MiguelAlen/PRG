using System;

namespace ej4._1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] meses1 = {31,28,31,30,31,30,31,31,30,31};
            int[] meses2 = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31 };

            Console.WriteLine("Es año bisiesto? (si o no)");
            string respuesta = Convert.ToString(Console.ReadLine());
            bool bisiesto = respuesta.Equals("si");
            
            if (bisiesto == true) 
                {
                Console.Write("Introduce el mes (1 = enero, 12 = diciembre) :");
                int mes = Convert.ToInt32(Console.ReadLine());
                mes--;

                try { Console.WriteLine("El mes tiene {0} dias.", meses2[mes]); }
                catch (Exception) { Console.WriteLine("El mes introducido no es valido"); }
            }
            else 
                {
                Console.Write("Introduce el mes (1 = enero, 12 = diciembre) :");
                int mes = Convert.ToInt32(Console.ReadLine());
                mes--;

                try { Console.WriteLine("El mes tiene {0} dias.", meses1[mes]); }
                catch (Exception) { Console.WriteLine("El mes introducido no es valido"); }
            }
            
            
        }
    }
}
