using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaoBeleza.API.Model
{
    public class Servico
    {
        public DateTime Horario { get; private set; }
        public string Descricao { get; private set; }
        public List<TipoServico>  TipoServicos { get; private set; }
        public Usuario  Usuario { get; set; }
        public Servico()
        {

        }
        public Servico(DateTime horario, string descricao, List<TipoServico> tipoServicos)
        {
            Horario = horario;
            Descricao = descricao;
            TipoServicos = tipoServicos;
        }
    }
}
