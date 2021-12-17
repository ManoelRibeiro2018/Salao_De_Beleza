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
        public TipoServico  TipoServico { get; private set; }
        public Servico()
        {

        }
        public Servico(DateTime horario, string descricao, TipoServico tipoServico)
        {
            Horario = horario;
            Descricao = descricao;
            TipoServico = tipoServico;
        }
    }
}
