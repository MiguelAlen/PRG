using System;
using System.Collections.Generic;
using System.Text;

namespace ej6._2._3
{
    public class Libro : Documento
    {
        protected string autor;
        protected string ubicacion;
        protected string titulo;

        public void SetAutor(string autor)
        {
            this.autor = autor;
        }
        public string GetAutor()
        {
            return this.autor;
        }
        public void SetUbicacion(string ubicacion)
        {
            this.ubicacion = ubicacion;
        }
        public string GetUbicacion()
        {
            return this.ubicacion;
        }

        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public string GetTitulo()
        {
            return this.titulo;
        }
    }
}
