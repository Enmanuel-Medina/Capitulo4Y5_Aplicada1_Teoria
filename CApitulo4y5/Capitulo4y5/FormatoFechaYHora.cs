using System;
using System.Collections.Generic;
using System.Text;

namespace CApitulo4y5.Capitulo4y5
{
    class FormatoFechaYHora
    {
        private string formato;

        public FormatoFechaYHora() { }

        public void correr()
        {
            formato = String.Format("Fecha:{0: h:m tt   d / M / yyy}", DateTime.Now);
            Console.WriteLine(formato);
        }
    }
}
