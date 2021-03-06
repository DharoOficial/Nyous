﻿using System;
using System.Collections.Generic;

namespace Nyous.Domains
{
    public partial class Localizacao
    {
        public Localizacao()
        {
            Eventos = new HashSet<Eventos>();
        }

        public int IdLocalizacao { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }

        public virtual ICollection<Eventos> Eventos { get; set; }
    }
}
