using System;

namespace ej2._6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el numero que quiere elevar: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el exponente: ");
            int exponente = int.Parse(Console.ReadLine());
            int resultado = numero;
            
            for (int i = 1; i < exponente; i++)
            {
                resultado = resultado * numero;
            }
            if(exponente == 0) { resultado = 0; }
            Console.WriteLine("El resultado es: " + resultado) ; 
        }
    }
}
