using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaoBeleza.API.Model
{
    public class TipoServico
    {

        public int Id { get; set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; set; }

        public TipoServico()
        {

        }
        public TipoServico(string nome, string descricao, decimal preco)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
        }
    }
}
