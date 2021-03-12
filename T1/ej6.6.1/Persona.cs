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
        public Persona(string nombre)
        {
            this.nombre = nombre;
            
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
