using System;
// --------------------------------------------
// Miguel Alentado Garcia
// Curso DAM 1º
// Modalidad Presencial
// Práctica nº 1
// --------------------------------------------
namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora.\nOperaciones:");
            Console.WriteLine(" + para realizar la operación suma.");
            Console.WriteLine(" - para realizar la operación resta.");
            Console.WriteLine(" * para realizar la operación multiplicación.");
            Console.WriteLine(" / para realizar la operación división.");
            Console.WriteLine(" = para mostrar el resultado de la operación acumulada y reinicializar el contenido a cero.");
            Console.WriteLine(" s para salir del programa.");
            char accion;
            double contador = 0;
            Console.WriteLine(" \nIntroduzca un valor para operar:");
            double operador1 = Convert.ToDouble(Console.ReadLine());
            try
            {
                do
                {
                    accion = Convert.ToChar(Console.ReadLine());
                    if (accion == '+')
                    {
                        contador = operador1 + Convert.ToDouble(Console.ReadLine());
                    }
                    if (accion == '-')
                    {
                        contador = operador1 - Convert.ToDouble(Console.ReadLine());
                    }
                    if (accion == '*')
                    {
                        contador = operador1 * Convert.ToDouble(Console.ReadLine());
                    }
                    if (accion == '/')
                    {
                        contador = operador1 / Convert.ToDouble(Console.ReadLine());
                    }
                    if (accion == '=')
                    {
                        Console.WriteLine("El resultado es {0}", contador);
                        contador = 0;
                        Console.WriteLine(" \nIntroduzca un valor para operar:");
                        operador1 = Convert.ToDouble(Console.ReadLine());
                    }
                    if (accion == 's')
                    {
                        break;
                    }
                }
            while (accion != 's');
            }
            catch(){};
            Console.WriteLine("Fin del programa");
        }
    }
}
