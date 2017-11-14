using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaControle.Models
{
    public class MeuEstudante
    {

        public int GruposDetalhesId { get; set; }
        public int GruposId { get; set; }
        public Usuario Estudante { get; set; }
        public double Nota { get; set; }

    }
}