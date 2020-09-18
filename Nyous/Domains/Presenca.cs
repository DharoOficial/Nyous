using System;
using System.Collections.Generic;

namespace Nyous.Domains
{
    public partial class Presenca
    {
        public int IdPresenca { get; set; }
        public bool? Comfirmado { get; set; }
        public int? IdEventos { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Eventos IdEventosNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
