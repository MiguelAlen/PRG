using System;

namespace ej3._3._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe una letra :");
            char letra = Convert.ToChar(Console.ReadLine());
            if (letra == 'a' || letra == 'A' ||
                letra == 'e' || letra == 'E' ||
                letra == 'i' || letra == 'I' ||
                letra == 'o' || letra == 'O' ||
                letra == 'a' || letra == 'U') 
                { Console.WriteLine("Es una vocal");}
            else{Console.WriteLine("Es una consonante");}
        }
    }
}
