using System;

namespace ej5._10._9
{
    class Program
    {
        public static int subcadenaEn(string cadena, string subCadena)
        {
            if (subCadena.Length > cadena.Length) { return 0; }
            string s = "";
            int contador = 0;
            if (cadena.Contains(subCadena)) { contador++; }
            else {
                for (int i = 0; i < cadena.Length; i++)
                {
                    for (int j = 0; j < subCadena.Length; j++)
                    {
                        if (cadena[i] == subCadena[j]) { s += cadena[i]; }
                    }
                }
                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (s[i] == s[i + 1])
                    {
                        contador += 2;
                    }
                }
            }
            return contador;
        }
        public static void Main()
        {
            Console.WriteLine("Introduce una cadena:");
            string cadena = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Introduce una subcadena");
            string subCadena = Convert.ToString(Console.ReadLine());
            Console.WriteLine("{0}", subcadenaEn(cadena, subCadena));
        }
    }
}
