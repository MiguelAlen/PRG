using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej7._6._1
{
    class Matriz
    {
        int orden;
        int[,] matriz;
        public Matriz(int orden)
        {
            this.orden = orden;
            this.matriz = new int[orden, orden];
        }
        

    }
}
