using System;
using System.IO;

namespace ej8._1._1.consola
{

    public class Escritor
    {
        string path = @"D:\Alentado\PRG\ficheros\";
        StreamWriter sw;
        string filename;

        public Escritor(string nombre)
        {
            filename = path + nombre + ".txt";
           
            if (!File.Exists(filename))
            {
                using (sw = File.CreateText(filename))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }
            else
            {
                sw = File.AppendText(filename);
            }
        }
        ~Escritor()
        {
            sw.Close();
        }

        public void Ver()
        {
            sw.Flush();
            using (StreamReader sr = File.OpenText(filename))
            {
                string contenido = "";
                while ((contenido = sr.ReadLine()) != null)
                {
                    Console.WriteLine(contenido);
                }
            }
        }
       static void Main(String[] args)
        {

        }
    }
}
