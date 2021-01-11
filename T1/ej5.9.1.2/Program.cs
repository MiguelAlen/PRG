using System;

namespace ej5._9._1._2
{
    class Program
    {
        public static void Main()
        {
            int intento = 0;
            //int intentos = 5;
            Random r = new Random();
            int aleatorio = r.Next(1, 101);
            Console.WriteLine("Intenta acertar un número entre el 1 y el 100. Tienes 6 intentos.");
            for (int i = 0; i < 6; i++) 
            {
                intento = Convert.ToInt32(Console.ReadLine());
                if (aleatorio == intento) { Console.WriteLine("Has ganado."); break; }
            }
            if (aleatorio != intento) { Console.WriteLine("Has perdido."); }

            /*while (true) 
             {
                 intento = Convert.ToInt32(Console.ReadLine());
                 if (intentos == 0) { Console.WriteLine("Has perdido."); break; }
                 if (aleatorio == intento) { Console.WriteLine("Has ganado."); break; }
                 else { intentos--; }
             }*/
        }

    }
}
