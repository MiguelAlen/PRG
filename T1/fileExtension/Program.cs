using System;
using System.IO;

namespace fileExtension
{
    class Program
    {
        public static void Main()
        {
            byte unByte;
            char c;
            Console.WriteLine("Introduzca el nombre del fichero");
            try
            {
                string path = Console.ReadLine();
                FileStream fichero = File.OpenRead(path);
                for (int pos = 0; pos < 8; pos++)
                {
                    unByte = (byte)fichero.ReadByte();
                    c = Convert.ToChar(unByte);
                    Console.Write(c);
                }
                Console.WriteLine();
                fichero.Close();    
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return;
            }
        }
    }
}
