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
            //variables locales
            char accion;
            double contador;
            bool terminar = true;
            //menu por pantalla
            Console.WriteLine("Calculadora.\nOperaciones:");
            Console.WriteLine(" + para realizar la operación suma.");
            Console.WriteLine(" - para realizar la operación resta.");
            Console.WriteLine(" * para realizar la operación multiplicación.");
            Console.WriteLine(" / para realizar la operación división.");
            Console.WriteLine(" = para mostrar el resultado de la operación acumulada y reinicializar el contenido a cero.");
            Console.WriteLine(" s para salir del programa.");
            while (terminar)
            {
                try
                {
                    //primer valor 
                    Console.WriteLine(" \nIntroduzca un valor:");
                    contador = Convert.ToDouble(Console.ReadLine());
                    //bucle calculadora
                    do
                    {
                        Console.WriteLine("Introduzca un operador:");
                        accion = Convert.ToChar(Console.ReadLine());
                        if (accion == '+')
                        {
                            Console.WriteLine("Introduzca un valor:");
                            contador += Convert.ToDouble(Console.ReadLine());
                        }
                        if (accion == '-')
                        {
                            Console.WriteLine("Introduzca un valor:");
                            contador -= Convert.ToDouble(Console.ReadLine());
                        }
                        if (accion == '*')
                        {
                            Console.WriteLine("Introduzca un valor:");
                            contador *= Convert.ToDouble(Console.ReadLine());
                        }
                        if (accion == '/')
                        {
                            Console.WriteLine("Introduzca un valor:");
                            contador /= Convert.ToDouble(Console.ReadLine());
                        }
                        if (accion == '=')
                        {
                            Console.WriteLine("El resultado es {0}", contador);
                            Console.WriteLine(" \n\nIntroduzca un valor para operar:");
                            contador = Convert.ToDouble(Console.ReadLine());
                        }
                        if (accion == 's')
                        {
                            Console.WriteLine("El resultado es {0}", contador);
                            break;
                        }
                    }
                    while (accion != 's');
                    terminar = false;
                }
                catch (Exception errorEncontrado)
                {
                    Console.WriteLine("Ha habido un error: EL dato introducido no es valido", errorEncontrado.Message);
                }
            }
            //Cerrar la calculadora
            Console.WriteLine("FIN DEL PROGRAMA");
        }
    }
}
