using System;
using System.Linq;

namespace ej4._3._1._1
{
    class Program
    {
        struct mp3
        {
            public string artista;
            public string titulo;
            public int pesoKb;
            public double duracion;
        }

        public static void Main()
        {
            mp3[] album = new mp3[100];
            int opcion;
            int posicion = 0;
            do
            {
                // Menu principal, repetitivo
                Console.WriteLine();
                Console.WriteLine("Lista de reproducción.\nEscoja una opción:");
                Console.WriteLine("1.- Añadir nueva cancion");
                Console.WriteLine("2.- Mostrar los nombres de todos las canciones");
                Console.WriteLine("3.- Buscar cancion");
                Console.WriteLine("4.- Cerrar lista de reproducción");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {

                    case 1: // Añadir una nueva canción
                        Console.WriteLine("Que canción desea añadir?");
                        album[posicion].titulo = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("A que cantante pertenece?");
                        album[posicion].artista = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Duracion de la canción?");
                        album[posicion].duracion = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Peso (en KB) de la canción?");
                        album[posicion].pesoKb = Convert.ToInt32(Console.ReadLine());
                        posicion++;
                        break;

                    case 2: // Mostrar todos los titulos
                        for(int i = 0; i < posicion; i++)
                        {
                            Console.WriteLine("{0}", album[i].titulo);
                        }
                        break;

                    case 3: // Buscar cancion
                        Console.WriteLine("Nombre de la canción?");
                        string buscar = Convert.ToString(Console.ReadLine());
                        bool encontrado = false;
                        for (int i = 0; i < posicion; i++)
                        {
                            if (buscar == album[i].titulo) { encontrado = true; }
                        }
                        if (encontrado==true) { Console.WriteLine("La cancion buscada es la numero {0}", posicion + 1); }
                        else {Console.WriteLine("La canción no está en el album"); }
                        break;

                    default: // Otra opcion: no válida
                        Console.WriteLine("Opción desconocida!");
                        break;
                }
            } while (opcion != 4);

        }
    }
}
