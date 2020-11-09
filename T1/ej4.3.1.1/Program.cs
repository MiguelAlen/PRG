using System;

namespace ej4._3._1._1
{
    class Program
    {
        struct mp3
        {
            public string artista;
            public string titulo;
            public int pesoKb;
            public float duracion;
        }

        public static void Main()
        {
            mp3[] album = new mp3[100];
            int opcion;
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
                        Console.WriteLine("A que cantante pertenece?");
                        Console.WriteLine("Duracion de la canción?");
                        Console.WriteLine("Peso (en KB) de la canción?");
                        break;

                    case 2: // Mostrar todos los titulos
                        Console.WriteLine("");
                        break;

                    case 3: // Buscar cancion
                        Console.WriteLine("");
                        break;

                    default: // Otra opcion: no válida
                        Console.WriteLine("Opción desconocida!");
                        break;
                }
            } while (opcion != 4);

        }
    }
}
