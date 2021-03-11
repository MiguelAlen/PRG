using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej6._6._1
{
    public class PersonaInglesa:Persona
    {
        public void TomarTe()
        {
            Console.WriteLine("Estoy tomando té");
        }
        public new void Saludar()
        {
            Console.WriteLine("Hello, I am {0}", this.nombre);
        }
    }
}
