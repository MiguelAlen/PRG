using System;

namespace ej4._2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca las equaciones en forma de matriz: ");
            double[,] myMatrix = new double[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Introducir elemento [" + (i + 1) + "]" + "[" + (j + 1) + "]: ");
                    myMatrix[i, j] = double.Parse(Console.ReadLine().ToString());
                }
            }
            Console.WriteLine("\nMatriz introducida: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(myMatrix[i, j].ToString("0.0") + " ");
                }
                Console.WriteLine();
            }
           
            //PRIMERA REDUCCION POR GAUSS
            //simplificar segunda fila
            double a = myMatrix[1, 0] / myMatrix[0, 0];
            myMatrix[1, 0] = 0; 
            myMatrix[1, 1] = myMatrix[1, 1] - (a * myMatrix[0, 1]); myMatrix[1, 2] = myMatrix[1, 2] - (a * myMatrix[0, 2]);
            myMatrix[1, 3] = myMatrix[1, 3] - (a * myMatrix[0, 3]);

            //simplificar tercera fila
            double b = myMatrix[2, 0] / myMatrix[0, 0];
            myMatrix[2, 0] = 0;
            myMatrix[2, 1] = myMatrix[2, 1]- b * myMatrix[0, 1]; myMatrix[2, 2] = myMatrix[2, 2] - (b * myMatrix[0, 2]);
            myMatrix[2, 3] = myMatrix[2, 3] - (b * myMatrix[0, 3]);

            Console.WriteLine("\nEq2 - {0}Eq1 y Eq3 - {1}Eq1",a.ToString("0.0"), b.ToString("0.0"));
            Console.WriteLine("\nMatriz despues de primer gauss :");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(myMatrix[i, j].ToString("0.0") + " ");
                }
                Console.WriteLine();
            }

            //SEGUNDA REDUCCION POR GAUSS
            //aislar z
            double c = myMatrix[2, 1] / myMatrix[1, 1];
            myMatrix[2, 1] = 0;
            myMatrix[2, 2] = myMatrix[2, 2] - (c * myMatrix[1, 2]);
            myMatrix[2, 3] = myMatrix[2, 3] - (c * myMatrix[1, 3]);
            
            Console.WriteLine("\nEq3 - {0}Eq2", c.ToString("0.0"));
            Console.WriteLine("\nMatriz despues de segundo gauss :");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(myMatrix[i, j].ToString("0.#") + " ");
                }
                Console.WriteLine();
            }

            //z aislado
            double z = myMatrix[2, 3] / myMatrix[2, 2];
            //y aislado
            double y = (myMatrix[1, 3] - myMatrix[1, 2] * z) / myMatrix[1, 1];
            //x aislado
            double x = (myMatrix[0, 3] - myMatrix[0, 1] * y - myMatrix[0, 2] * z) / myMatrix[0, 0];
            //solucion
            Console.WriteLine("\nValor x = {0} ", x.ToString("0.0"));
            Console.WriteLine("Valor y = {0} ", y.ToString("0.0"));
            Console.WriteLine("Valor z = {0} ", z.ToString("0.0"));
        }
    }
}
