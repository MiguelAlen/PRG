using System;
// --------------------------------------------
// Miguel Alentado Garcia
// Curso DAM
// Modalidad Presencial
// Práctica nº 2
// --------------------------------------------
namespace ahorcado
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra1 = "programación";
            string palabra2 = "____________";
            int errores = 0;
            char letra;
            char[,] dibujo = new char[6, 8];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    dibujo[i, j] = ' ';
                }
            }
            bool mostrar = false;
            //estructura dibujo ahorcado
            dibujo[0, 0] = '┌'; dibujo[0, 4] = '┐'; dibujo[5, 0] = '┴';
            dibujo[0, 1] = '─'; dibujo[0, 2] = '─'; dibujo[0, 3] = '─';
            dibujo[5, 1] = '─'; dibujo[5, 2] = '─'; dibujo[5, 3] = '─'; dibujo[5, 4] = '─';
            dibujo[5, 5] = '─'; dibujo[5, 6] = '─'; dibujo[5, 7] = '─';
            dibujo[1, 0] = '│'; dibujo[2, 0] = '│'; dibujo[3, 0] = '│'; dibujo[4, 0] = '│';
            Console.WriteLine("Cadena: programación");
            //6 intentos
            while (errores < 6)
            {
                //errores
                if (errores == 1) { dibujo[1, 4] = 'o'; }
                if (errores == 2) { dibujo[2, 3] = '/'; }
                if (errores == 3) { dibujo[2, 4] = '|'; }
                if (errores == 4) { dibujo[2, 5] = '\\'; }
                if (errores == 5) { dibujo[3, 3] = '/'; }
                //mostrar dibujo
                if (mostrar == true)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            Console.Write(dibujo[i, j].ToString());
                        }
                        Console.WriteLine();
                    }
                }
                //pedir letra al usuario y comprar
                //https://docs.microsoft.com/es-es/dotnet/csharp/how-to/modify-string-contents
                Console.Write("Letra:");
                letra = Convert.ToChar(Console.ReadLine());
                for (int i = 0; i < palabra1.Length; i++)
                {
                    if (palabra1[i] == letra)
                    {
                        palabra2 = palabra2.Replace(palabra2[i], letra);
                        mostrar = false;
                        Console.WriteLine("{0}", palabra2);
                        break;
                    }
                    else
                    {
                        if (i == palabra1.Length - 1)
                        {
                            errores++;
                            mostrar = true;
                        }
                    }
                }
            }
            if (errores == 6)
            {
                dibujo[3, 5] = '\\';
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Console.Write(dibujo[i, j].ToString());
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("R.I.P.La palabra era programación.");
            }
        }
    }
}
