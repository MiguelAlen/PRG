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
                        switch (accion)
                        {
                            case '+':
                                Console.WriteLine("Introduzca un valor:");
                                contador += Convert.ToDouble(Console.ReadLine());
                                break;
                            case '-':
                                Console.WriteLine("Introduzca un valor:");
                                contador -= Convert.ToDouble(Console.ReadLine());
                                break;
                            case '*':
                                Console.WriteLine("Introduzca un valor:");
                                contador *= Convert.ToDouble(Console.ReadLine());
                                break;
                            case '/':
                                Console.WriteLine("Introduzca un valor:");
                                contador /= Convert.ToDouble(Console.ReadLine());
                                break;
                            //Contador a 0*. Su valor pasa a ser el proximo valor inicial. 
                            case '=':
                                Console.WriteLine("El resultado es {0}", contador);
                                Console.WriteLine(" \nIntroduzca un valor:");
                                contador = Convert.ToDouble(Console.ReadLine());
                                break;
                            case 's':
                                Console.WriteLine("El resultado es {0}", contador);
                                break;
                            //Operacion incorrecta
                            default:
                                Console.WriteLine("--> Operación incorrecta");
                                break;
                        }
                        if (accion == 's') { break; };
                    }
                    while (accion != 's');
                    terminar = false;
                }
                //numero incorrecto
                catch (Exception errorEncontrado)
                {
                    Console.WriteLine("--> Número incorrecto", errorEncontrado.Message);
                }
            }
            //Cerrar la calculadora
            Console.WriteLine("FIN DEL PROGRAMA");
        }
    }
}
