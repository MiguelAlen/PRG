using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ej8._1._1
{
    class Escritor
    {
        string path = @"D:\Alentado\PRG\ficheros\";

        public void Nuevo( string nombre)
        {
            path += nombre += ".txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }
        }
        public void Ver (string nombre)
        {
            using (StreamReader sr = File.OpenText(path += nombre += ".txt"))
            {
                string contenido = "";
                while ((contenido = sr.ReadLine()) != null)
                {
                    Console.WriteLine(contenido);
                }
            }
        
        }
    }
}
