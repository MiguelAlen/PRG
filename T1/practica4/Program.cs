using System;
using System.IO;
namespace practica4

// --------------------------------------------
// Miguel Alentado Garcia
// Curso DAM
// Modalidad Presencial
// Práctica nº 4
// --------------------------------------------

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

            string valencia = "valencia.txt";
            string alicante = "alicante.txt";
            string castellon = "castellon.txt";

            //split
            char delimitador = '#';
            string[] campos = new string[3];

            if (File.Exists(path))
                {
                    fichero = File.OpenText(path);
                    StreamWriter a = File.CreateText(alicante);
                    StreamWriter v = File.CreateText(valencia);
                    StreamWriter c = File.CreateText(castellon);
                    try
                    {
                    
                        do //switch
                        {
                            linea = fichero.ReadLine();
                            if (linea != null)
                            {
                                campos = linea.Split(delimitador);
                                Console.WriteLine(linea + ": se ha añadido");
                                
                                //ALICANTE
                                if (campos[2] == ("Alicante"))
                                {                                                                      
                                     a.WriteLine(linea);                                    
                                }

                                //VALENCIA
                                if (campos[2] == ("Valencia"))
                                
                                {
                                    v.WriteLine(linea);
                                }                           

                                //CASTELLON
                                if (campos[2] == ("Castellón"))
                                {
                                    c.WriteLine(linea);
                                }
                            }
                        }
                        while (linea != null);
                        
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Ha ocurrido un error inesperado {0}", e);
                        Console.WriteLine("");
                    }
                
                fichero.Close();
                a.Close();
                v.Close();
                c.Close();
                }
                else{ Console.WriteLine("No se ha encontrado el archivo"); }
        }
    }
}
