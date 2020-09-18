using System;
using System.Collections.Generic;

namespace Nyous.Domains
{
    public partial class Convite
    {
        public int IdConvite { get; set; }
        public bool? Comfirmado { get; set; }
        public int? IdEventos { get; set; }
        public int? IdUsuarioEmissor { get; set; }
        public int? IdUsuarioConvidado { get; set; }

        public virtual Eventos IdEventosNavigation { get; set; }
        public virtual Usuario IdUsuarioConvidadoNavigation { get; set; }
        public virtual Usuario IdUsuarioEmissorNavigation { get; set; }
    }
}
