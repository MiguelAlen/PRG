using System;

namespace ej4._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Determinante de la matriz a introducir: ");
                int n = int.Parse(Console.ReadLine().ToString());
                Console.WriteLine("Orden de matriz introducido: " + n.ToString());
                if (n > 0)
                {
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
                    Console.WriteLine("Valor del determinante: " + Determinant(myMatrix));
                    if (Determinant(myMatrix)==0) { Console.WriteLine("Matriz linealmente dependiente."); }
                    else { Console.WriteLine("Matriz linealmente independiente."); };
                }
                else
                {
                    Console.WriteLine("El orden de la matriz debe ser un valor positivo.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
        //Determinar positivo o negativo delos elementos
        static int SignOfElement(int i, int j)
        {
            if ((i + j) % 2 == 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        //Calcular submatriz
        static double[,] CreateSmallerMatrix(double[,] input, int i, int j)
        {
            int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
            double[,] output = new double[order - 1, order - 1];
            int x = 0, y = 0;
            for (int m = 0; m < order; m++, x++)
            {
                if (m != i)
                {
                    y = 0;
                    for (int n = 0; n < order; n++)
                    {
                        if (n != j)
                        {
                            output[x, y] = input[m, n];
                            y++;
                        }
                    }
                }
                else
                {
                    x--;
                }
            }
            return output;
        }
        //Valor del determinante
        static double Determinant(double[,] input)
        {
            int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
            if (order > 2)
            {
                double value = 0;
                for (int j = 0; j < order; j++)
                {
                    double[,] Temp = CreateSmallerMatrix(input, 0, j);
                    value = value + input[0, j] * (SignOfElement(0, j) * Determinant(Temp));
                }
                return value;
            }
            else if (order == 2)
            {
                return ((input[0, 0] * input[1, 1]) - (input[1, 0] * input[0, 1]));
            }
            else
            {
                return (input[0, 0]);
            }
        }
    }
}
