using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej6._6._1
{
    public class Persona
    { 
        public string nombre;
        public int id;

        public Persona()
        {
            this.nombre = "";
        }
        //corregir
        public Persona(string nombre, int i)
        {
            this.nombre = n;
            
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void Saludar()
        {
            Console.WriteLine(("Hola. soy {0}"),this.nombre);
        }
        ~Persona() { }
    }
}
