using System;

namespace ej4._1._4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos = { 10, 15, 12, 0, 0 };
            int capacidad = 5; 
            int cantidad = 3;
            int i;
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", datos[i]);
            Console.WriteLine();
            for (i = 0; i < cantidad; i++)
                if (datos[i] == 15)
                    Console.WriteLine("15 encontrado en la posición {0} ", i + 1);
            int maximo = datos[0];
            for (i = 1; i < cantidad; i++)
                if (datos[i] > maximo)
                    maximo = datos[i];
            Console.WriteLine("El máximo es {0} ", maximo);
            Console.WriteLine("Añadiendo 6 al final");
            if (cantidad < capacidad)
            {
                datos[cantidad] = 6;
                cantidad++;
            }
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", datos[i]);
            Console.WriteLine();
            Console.WriteLine("Borrando el segundo dato");
            int posicionBorrar = 1;
            for (i = posicionBorrar; i < cantidad - 1; i++)
                datos[i] = datos[i + 1];
                cantidad--;
            datos[cantidad] = 0;
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", datos[i]);
            Console.WriteLine();
            if (cantidad < capacidad)
            {
                try 
                {
                    Console.WriteLine("Escoja un nuevo número: ");
                    int nuevo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insertar en que posición ?");
                    int posicionInsertar = Convert.ToInt32(Console.ReadLine())-1;
                    for (i = cantidad; i > posicionInsertar; i--)
                        datos[i] = datos[i - 1];
                    datos[posicionInsertar] = nuevo;
                    cantidad++;
                    for (i = 0; i < datos.Length; i++)
                        Console.Write("{0} ", datos[i]);
                    Console.WriteLine();
                    Console.WriteLine("Que posicion desaea eliminar? : ");
                    int posBorrar = Convert.ToInt32(Console.ReadLine())-1;
                    for (i = posBorrar; i < datos.Length - 1; i++)
                        datos[i] = datos[i + 1];
                    cantidad--;
                    datos[cantidad+1] = 0;
                }
                catch (Exception errorEncontrado)
                {
                    Console.WriteLine("Ha habido un error: {0}", errorEncontrado.Message);
                }
            }
            for (i = 0; i < datos.Length; i++)
                Console.Write("{0} ", datos[i]);
            Console.WriteLine();
        }
    }
}

