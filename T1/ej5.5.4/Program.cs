using System;

namespace ej5._5._4
{
    class Program
    {
        public static int ContarLetra (string palabra, char letra)
        {
            int veces = 0;
            for (int i = 0; i < palabra.Length; i++) 
            {
                if (palabra[i] == letra) { veces++;}
            }
            return veces;
        }
        public static void Main()
        {
            string palabra; char letra;
            Console.WriteLine("Introduzca el texto: ");
            palabra = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Introduzca la letra a buscar: ");
            letra = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Aparece {0} veces.", ContarLetra(palabra, letra));
        }
    }
}
