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
            // Compare: comparaciones caracter a caracter, si segun el codigo asci, 
            // si una comparacion resulta mayor a la otra, lo da por terminado.
            string cadena1 = "";
            string cadena2 = "";

            Console.WriteLine("Cadena 1:");
            cadena1 = Console.ReadLine();

            Console.WriteLine("Cadena 2:");
            cadena2 = Console.ReadLine();

            if (string.Compare(cadena1, cadena2, true) > 0)
            {
                Console.WriteLine("La cadena 1 es mayor que la cadena 2.");
            }
            else
            {
                if (string.Compare (cadena1, cadena2, true) < 0)
                {
                    Console.WriteLine("La cadena 2 es mayor que la cadena 1.");
                }
                else
                {
                    Console.WriteLine("Las cadenas son iguales");
                }
            }
        }
    }
}
