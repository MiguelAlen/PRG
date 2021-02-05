using System;

namespace ej5._10._9
{
    class Program
    {
        
        public static int subcadenaEn(string cadena, string subCadena)
        {
            int contador = 0;
            string s;
            if (subCadena.Length > cadena.Length) { return 0; }
            if (cadena == subCadena) { return 1; }
            else { if (cadena.Length == subCadena.Length) { return 0; } }

            int i = 0;
            while (i < cadena.Length)
            {
                s = cadena.Remove(i, 1); 
                contador += subcadenaEn(s,subCadena);
                i++;
            }
            return contador;
        }
        public static int startSubcadenaEn(string cadena, string subCadena)
        {
            int contador = 0;
            contador += subcadenaEn(cadena, subCadena);
            int dobles = cadena.Length - subCadena.Length- 1;


             return contador / (2 * dobles);
        }
        public static void Main()
        {
            Console.WriteLine("Introduce una cadena:");
            string cadena = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Introduce una subcadena");
            string subCadena = Convert.ToString(Console.ReadLine());
            Console.WriteLine("{0}", startSubcadenaEn(cadena, subCadena));
        }
    }
}
