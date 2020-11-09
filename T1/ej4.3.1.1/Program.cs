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
            mp3 cancion;
            cancion.artista = "art";
            cancion.titulo = "tit";
            cancion.pesoKb = 222;
            cancion.duracion = 1.2f;
            Console.WriteLine("La cancion de {0} es {1}, dura {2} minutos y pesa {3}KB."
                ,cancion.artista, cancion.titulo, cancion.duracion, cancion.pesoKb);
        }
    }
}
