using System;
using System.Collections.Generic;

namespace Nyous.Domains
{
    public partial class Categoria
    {
        public Categoria()
        {
            Eventos = new HashSet<Eventos>();
        }

        public int IdCategoria { get; set; }
        public string Titulo { get; set; }

        public virtual ICollection<Eventos> Eventos { get; set; }
    }
}
