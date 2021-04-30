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

            string valencia = @"D:\Alentado\PRG\ficheros\valencia.txt";
            string alicante = @"D:\Alentado\PRG\ficheros\alicante.txt";
            string castellon = @"D:\Alentado\PRG\ficheros\castellon.txt";

            using (StreamWriter a = File.CreateText(alicante))
            using (StreamWriter v = File.CreateText(valencia))
            using (StreamWriter c = File.CreateText(castellon))

                if (!File.Exists(path))
                {
                    try
                    {
                        fichero = File.OpenText(path);
                        do
                        {
                            linea = fichero.ReadLine();
                            if (linea != null)
                            {
                                Console.WriteLine(linea);
                                //ALICANTE
                                if (linea.Contains("Alicante") == true)
                                {
                                    using (StreamWriter al = File.AppendText(alicante))
                                    {
                                        al.WriteLine(linea);
                                    }
                                }

                                //VALENCIA
                                if (linea.Contains("Valencia") == true)
                                {
                                    using (StreamWriter val = File.AppendText(valencia))
                                    {
                                        val.WriteLine(linea);
                                    }
                                }

                                //CASTELLON
                                if (linea.Contains("Castellón") == true)
                                {
                                    using (StreamWriter cast = File.AppendText(castellon))
                                    {
                                        cast.WriteLine(linea);
                                    }
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
}
