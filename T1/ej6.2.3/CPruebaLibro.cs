﻿using System;

namespace ej6._2._3
{
    public class PruebaLibro
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            libro.SetAutor("javier");
            libro.SetTitulo("PRG");
            libro.SetUbicacion("IGF");
            libro.SetPaginas(120);
            Console.WriteLine("El autor del libro es {0}", libro.GetAutor());
            Console.WriteLine("El titulo del libro es {0}", libro.GetTitulo());
            Console.WriteLine("La ubicacion del libro es {0}", libro.GetUbicacion());
            Console.WriteLine("El libro tiene {0} páginas", libro.GetPaginas());
        }
    }
}
