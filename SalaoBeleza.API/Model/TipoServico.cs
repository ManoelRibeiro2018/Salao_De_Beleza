using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaoBeleza.API.Model
{
    public class TipoServico : EntidadeBase
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }

        public TipoServico()
        {

        }
        public TipoServico(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
    }
}
