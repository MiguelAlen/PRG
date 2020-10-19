using System;
public class Ejemplo_03_02_01a
{
    public static void Main()
    {
        int i1 = 3, i2 = 4;
        float divisionI;
        Console.WriteLine("Vamos a dividir 3 entre 4 usando enteros");
        divisionI = i1 / i2;
        Console.WriteLine("El resultado es {0}", divisionI);

        float f1 = 3, f2 = 4;
        float divisionF;
        Console.WriteLine("Vamos a dividir 3 entre 4 usando reales");
        divisionF = f1 / f2;
        Console.WriteLine("El resultado es {0}", divisionF);
    }
}