using System;
public class Ejemplo_06_05a
{
    public static void Main()
    {
        Puerta p = new Puerta();
        Console.WriteLine("Valores iniciales...");
        p.MostrarEstado();
        Console.WriteLine();
        Console.WriteLine("Vamos a abrir...");
        p.Abrir();
        p.SetAncho(80);
        p.MostrarEstado();
        Console.WriteLine();
        Console.WriteLine("Ahora el portón...");
        Porton p2 = new Porton();
        p2.SetAncho(300);
        p2.Bloquear();
        p2.MostrarEstado();
    }
}
