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
            Console.WriteLine(" \nIntroduzca un primer valor para operar:");
            int contador = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca primera operación:");
            char accion = Convert.ToChar(Console.ReadLine());
            if (accion =! '+' || '-' || '' || '' || '' || '') 
                { 
                    Console.WriteLine("Operacion no valida"); 
                }
            while (accion != 's')
            {
                if (accion == '+')
                {

                }
                if (accion == '-')
                {

                }
                if (accion == '*')
                {

                }
                if (accion == '/')
                {

                }
                if (accion == '=')
                {

                }
                if (accion == 's')
                {
                    break
                }
            }
        }
    }
}
