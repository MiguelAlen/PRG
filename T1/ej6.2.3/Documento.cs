using System;
using System.Collections.Generic;
using System.Text;

namespace ej6._2._3
{
    public class Documento
    {
        protected int paginas;

        public void SetPaginas(int paginas)
        {
            this.paginas = paginas;
        }
        public int GetPaginas()
        {
            return this.paginas;
        }
    }
}
