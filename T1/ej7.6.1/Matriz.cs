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
        public Matriz()
        {
            orden = 3;
            matriz = new int[3,3];
        }
        public int GetPosicion(int posicion1, int posicion2)
        {
            int valor = -1;
            try
            {
                valor = matriz[posicion1, posicion2];
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
            return valor;
        }
        public void Setposicion(int valor, int posicion1, int posicion2)
        {
            matriz[posicion1, posicion2] = valor;
        }
    }
}
