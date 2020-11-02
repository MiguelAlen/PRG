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
            try {
                while (menu == true)
                {
                    Console.WriteLine("Menu:" +
                    "\n Introduzca número para acción" +
                    "\n 1: Añadir un dato al final" +
                    "\n 2: Añadir un dato en una posición determinada" +
                    "\n 3: Borrar un dato" +
                    "\n 4: Mostrar contenido" +
                    "\n 5: Fin"
                    );
                    int accion = Convert.ToInt32(Console.ReadLine());
                    if (accion == 1) {
                        if (cantidad < capacidad)
                        {
                            datos[cantidad] = Convert.ToString(Console.ReadLine());
                            cantidad++;
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
                    }
                    if (accion == 3) {
                        Console.WriteLine("Que posicion desaea eliminar? : ");
                        int posBorrar = Convert.ToInt32(Console.ReadLine()) - 1;
                        for (int i = posBorrar; i < datos.Length - 1; i++)
                            datos[i] = datos[i + 1];
                        cantidad--;
                        datos[cantidad + 1] = "";
                    }
                    if (accion == 4) {
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
        }
    }
}
