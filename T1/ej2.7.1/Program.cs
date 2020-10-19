using System;
public class Ejemplo_02_07b
{
    public static void Main()

     {
        int edad;
        int nacimiento;
        try
           {
            Console.WriteLine("Introduzca su edad :");
            edad = Convert.ToInt32(Console.ReadLine());
           }
        catch (FormatException)
           {
            Console.WriteLine("No es un número válido");
           }
        try 
           {
            Console.WriteLine("Introduzca el año de nacimiento :");
            nacimiento = Convert.ToInt32(Console.ReadLine());
           }

        catch (FormatException)
           {
            Console.WriteLine("No es un número válido");
           }
     }
}