using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaoBeleza.API.Model
{
    public class TipoServico : EntidadeBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
