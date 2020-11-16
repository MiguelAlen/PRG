using System;

namespace ejemplosCadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre:");
            string nombre = Convert.ToString(Console.ReadLine());
            // Pasar string a mayusculas
            nombre = nombre.ToUpper();
            Console.WriteLine("{0}", nombre);
            // Pasar string a minusculas
            nombre = nombre.ToLower();
            Console.WriteLine("{0}", nombre);
            // Insertar cadena de texto en una posicion determinada
            nombre = nombre.Insert(0, "Don ");
            Console.WriteLine("{0}", nombre);
            // Eliminar caracteres entre dos posiciones dadas
            nombre = nombre.Remove(0, 4);
            Console.WriteLine("{0}", nombre);
            // Replace(string textoASustituir, string cadenaSustituta): Sustituye una
            // cadena(todas las veces que aparezca) por otra: nombreCorregido =
            // nombre.Replace("Pepe", "Jose");
            Console.WriteLine("El arbol, la arboleda, los arboles");
            string texto = "El arbol, la arboleda, los arboles";
            Console.WriteLine("Si cambiamos ' a' por ' A' :{0}", texto.Replace(" a", " A"));

        }
    }
}
