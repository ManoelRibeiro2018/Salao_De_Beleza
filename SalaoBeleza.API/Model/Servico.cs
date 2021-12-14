using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaoBeleza.API.Model
{
    public class Servico
    {
        public DateTime Horario { get; set; }
        public TipoServico  TipoServico { get; set; }

    }
}
