using System;

namespace ej4._1._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos = { 10, 15, 12, 0, 0 };
            int capacidad = 5; // Capacidad maxima del array
            int cantidad = 3; // Número real de datos guardados
            int i; // Para recorrer los elementos
                   // Mostramos el array
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", datos[i]);
            Console.WriteLine();
            // Buscamos el dato "15"
            for (i = 0; i < cantidad; i++)
                if (datos[i] == 15)
                    Console.WriteLine("15 encontrado en la posición {0} ", i + 1);

            // Buscamos el máximo
            int maximo = datos[0];
            for (i = 1; i < cantidad; i++)
                if (datos[i] > maximo)
                    maximo = datos[i];
            Console.WriteLine("El máximo es {0} ", maximo);
            // Añadimos un dato al final
            Console.WriteLine("Añadiendo 6 al final");
            if (cantidad < capacidad)
            {
                datos[cantidad] = 6;
                cantidad++;
            }
            // Y volvemos a mostrar el array
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", datos[i]);
            Console.WriteLine();
            // Borramos el segundo dato
            Console.WriteLine("Borrando el segundo dato");
            int posicionBorrar = 1;
            for (i = posicionBorrar; i < cantidad - 1; i++)
                datos[i] = datos[i + 1];
            cantidad--;
            // Y volvemos a mostrar el array
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", datos[i]);
            Console.WriteLine();
            // Insertamos 30 en la tercera posición
            if (cantidad < capacidad)
                
 {
                Console.WriteLine("Insertando 30 en la posición 3");
                int posicionInsertar = 2;
                for (i = cantidad; i > posicionInsertar; i--)
                    datos[i] = datos[i - 1];
                datos[posicionInsertar] = 30;
                cantidad++;
            }
            // Y volvemos a mostrar el array
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", datos[i]);
            Console.WriteLine();
        }
    }
}
