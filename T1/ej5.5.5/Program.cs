using System;

namespace ej5._5._5
{
    class Program
    {
        public static int SumarCifras(string n)
        {
            //Devuelve el resultado en ASCII
            int total = 0;
            for (int i = 0; i < n.Length; i++)
            {
                total += Convert.ToInt32(n[i]) - 48;
            }
            return total;
        }
        public static void Main()
        {
            string cifra;
            Console.WriteLine("Introduzca un numero: ");
            cifra = Convert.ToString(Console.ReadLine());
            Console.WriteLine("La suma de sus digitos es: {0}", SumarCifras(cifra));
        }
    }
}
