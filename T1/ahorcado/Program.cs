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
            // Palabra del ahorcado puesta en array, y array de '_' con tamaño de la palabra.
            string cadena = Convert.ToString(Console.ReadLine());
            char[] palabra1 = cadena.ToCharArray();
            char[] palabra2 = new char[cadena.Length];
            for (int i = 0; i < cadena.Length; i++)
            {
                palabra2[i] = '_';
            }
            // Variables locales
            int errores = 0;
            string intento = "";
            char letra;
            // Matriz de espacios para el dibujo
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
            Console.WriteLine("Cadena: {0}", cadena);
            //6 intentos
            while (errores < 6)
            {
                try
                {
                    //array2 de '_' a string
                    intento = new string(palabra2);
                    //acierto todas las letras correctas
                    if (intento == cadena) { break; }
                    //intentos fallidos
                    if (errores == 1) { dibujo[1, 4] = 'o'; }
                    if (errores == 2) { dibujo[2, 3] = '/'; }
                    if (errores == 3) { dibujo[2, 4] = '|'; }
                    if (errores == 4) { dibujo[2, 5] = '\\'; }
                    if (errores == 5) { dibujo[3, 3] = '/'; }
                    //mostrar dibujo en relacion a intentos fallidos
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
                    // variable para letras repetidas
                    int contador = 0;
                    //introducir y buscar letra. Si no se introduce un char letra, pedir de nuevo
                    Console.WriteLine("Introduce una letra:");
                    letra = Convert.ToChar(Console.ReadLine());
                    while (bool IsLetter(letra) == false)
                    {
                        Console.WriteLine("Caracter no valido. Introduce una letra:");
                        letra = Convert.ToChar(Console.ReadLine());
                    }
                    for (int i = 0; i < palabra1.Length; i++)
                    {
                        if (palabra1[i] == letra)
                        {
                            palabra2[i] = palabra1[i];
                            mostrar = false;
                            contador++;
                        }
                        if (contador == 0 && i == palabra2.Length - 1)
                        {
                            errores++;
                            mostrar = true;
                        }
                        if (contador > 0 && i == palabra2.Length - 1)
                        {
                            for (int j = 0; j < palabra2.Length; j++)
                            {
                                Console.Write("{0}", palabra2[j]);
                            }
                        }
                    }
                    Console.WriteLine("");
                }
                //si no se introduce una letra, avisar y pedirla de nuevo
                catch (Exception errorEncontrado)
                {
                    Console.WriteLine("Caracter no valido. Introduce una letra:",
                    errorEncontrado.Message);
                }
            }
            //
            if (intento == cadena)
            {
                Console.WriteLine("Enhorabuena, has ganado!!!");
            }
            else
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
                Console.WriteLine("R.I.P.La palabra era {0}.", cadena);
            }
        }
    }
}
