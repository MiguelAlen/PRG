using System;

namespace ej4._2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca matriz de orden 3: ");
            int n = 3;
            double[,] myMatrix = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Introducir elemento [" + (i + 1) + "]" + "[" + (j + 1) + "]: ");
                    myMatrix[i, j] = double.Parse(Console.ReadLine().ToString());
                }
            }
            Console.WriteLine("Matriz introducida: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(myMatrix[i, j].ToString() + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Introducir vector solución de la matriz (eq1, eq2, eq3)");
            double[] sol = new double[3];
            for(int i =0; i < 3; i++) 
            {
                Console.WriteLine("Eq{0} :",i+1);
                sol[i] = Convert.ToDouble(Console.ReadLine());
            }
            //primer gauss
            //equacion 2
            double eq2 = myMatrix[1, 0] / myMatrix[0, 0];
            myMatrix[1, 0] = 0; 
            myMatrix[1, 1] = myMatrix[1, 1] - (eq2 * myMatrix[0, 1]); myMatrix[1, 2] = myMatrix[1, 2] - (eq2 * myMatrix[0, 2]);
            sol[1] = sol[1] - (eq2 * sol[0]);

            //equacion 3
            double eq3 = myMatrix[2, 0] / myMatrix[0, 0];
            myMatrix[2, 0] = 0;
            myMatrix[2, 1] = myMatrix[2, 1]- eq3 * myMatrix[0, 1]; myMatrix[2, 2] = myMatrix[2, 2] - (eq3 * myMatrix[0, 2]);
            sol[2] = sol[2] - (eq3 * sol[0]);
            
            
            //segundo gauss
            //equacion z
            eq3 = myMatrix[2, 1] / myMatrix[1, 1];
            myMatrix[2, 1] = 0;
            myMatrix[2, 2] = myMatrix[2, 2] - (eq3 * myMatrix[1, 2]);
            sol[2] = sol[2] - (eq3 * sol[1]);


            //z aislado
            double z = sol[2] / myMatrix[2, 2];
            //y aislado
            double y = (sol[1] - myMatrix[1, 2] * z) / myMatrix[1, 1];
            //x aislado
            double x = (sol[0] - myMatrix[0, 1] * y - myMatrix[0, 2] * z) / myMatrix[0, 0];
            //solucion
            Console.WriteLine("Valor x = {0} ", x);
            Console.WriteLine("Valor y = {0} ", y);
            Console.WriteLine("Valor z = {0} ", z);
        }
    }
}
