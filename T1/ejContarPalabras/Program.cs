using System;

namespace ej4._4._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que te cuentas? :)");
            string frase = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Que palabra quieres saber cuantas veces has dicho? :O");
            string palabra = Convert.ToString(Console.ReadLine());
            int contador = 0;
            int posicion = frase.IndexOf(palabra);
            do
            {
                if (posicion >= 0) { contador++; posicion++; }
            }
            while (posicion != -1 && posicion < frase.Length);

            Console.WriteLine("Se ha dicho {0} veces", contador);
        }
    }
}