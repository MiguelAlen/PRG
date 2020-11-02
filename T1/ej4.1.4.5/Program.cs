using System;
using System.Linq.Expressions;

namespace ej4._1._4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] datos = new string[10];
            bool menu = true;
            int capacidad = 10;
            int cantidad = 0;
            Console.WriteLine("Creada lista con 10 espacios." +
                    "\nMenu:" +
                    "\n1: Añadir un dato al final." +
                    "\n2: Añadir un dato en una posición determinada." +
                    "\n3: Borrar un dato." +
                    "\n4: Mostrar contenido." +
                    "\n5: Fin."
                    );
            try {
                while (menu == true)
                {
                    Console.WriteLine("\nIntroduzca número para acción" +
                                        "\n");
                    int accion = Convert.ToInt32(Console.ReadLine());
                    if (accion == 1) {
                        if (cantidad < capacidad)
                        {
                            Console.WriteLine("Nuevo dato a introducir: ");
                            datos[cantidad] = Convert.ToString(Console.ReadLine());
                            cantidad++;
                            Console.WriteLine("Dato a introducido. ");
                        }
                    }
                    if (accion == 2) {
                        Console.WriteLine("Nuevo dato a introducir: ");
                        string nuevo = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Insertar en que posición ?");
                        int posicionInsertar = Convert.ToInt32(Console.ReadLine()) - 1;
                        for (int i = cantidad; i > posicionInsertar; i--)
                            datos[i] = datos[i - 1];
                        datos[posicionInsertar] = nuevo;
                        cantidad++;
                        Console.WriteLine("Dato insertado.");
                    }
                    if (accion == 3) {
                        Console.WriteLine("Que posicion desaea eliminar? : ");
                        int posBorrar = Convert.ToInt32(Console.ReadLine()) - 1;
                        for (int i = posBorrar; i < datos.Length - 1; i++)
                            datos[i] = datos[i + 1];
                        cantidad--;
                        datos[cantidad + 1] = "";
                        Console.WriteLine("Dato eliminado.");
                    }
                    if (accion == 4) {
                        Console.WriteLine("Contenido: ");
                        if (cantidad == 0) { Console.WriteLine("Actualmente vacio."); }
                        for (int i = 0; i < cantidad; i++)
                            Console.Write("{0} ", datos[i]);
                        Console.WriteLine();
                    }
                    if (accion == 5) { menu = false;}
                    }
                }
            catch(Exception errorEncontrado)
            {
                Console.WriteLine("Ha habido un error: {0}",
                errorEncontrado.Message);
            }
            Console.WriteLine("Fin del programa.");
        }
    }
}
