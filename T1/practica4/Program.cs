using System;
using System.IO;
namespace practica4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fichero;
            string linea;

            Console.WriteLine("Introduce el path del fichero a utilizar:");
            Console.WriteLine("Ejemplo:");
            Console.Write(@"D:\Alentado\PRG\ficheros\ejemplo.txt");
            Console.WriteLine();

            string path = Convert.ToString(Console.ReadLine());

            try 
            { 
                fichero = File.OpenText(path);
                do
                {
                    linea = fichero.ReadLine();
                    if (linea != null)
                    {
                        //ALICANTE
                        if (linea.Contains("Alicante") == true)
                        {

                        }

                        //VALENCIA
                        if (linea.Contains("Valencia") == true)
                        {

                        }

                        //CASTELLON
                        if (linea.Contains("Castellón") == true)
                        {

                        }
                    }                   
                }
                while (linea != null);
                fichero.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error inesperado {0}", e);
            }
        }
    }
}
