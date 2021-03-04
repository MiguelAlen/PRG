using System;

namespace ej6._2._2
{
     public class Juego
    {   

        public void Lanzar()
        {
            Console.WriteLine(CBienvenida.BIENVENIDA);
        }
        public void Partida()
        {
            Console.WriteLine(CPartida.PARTIDA);
        }
        static void Main(string[] args)
        {
            Juego j = new Juego();
            j.Lanzar();
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            j.Partida();
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
