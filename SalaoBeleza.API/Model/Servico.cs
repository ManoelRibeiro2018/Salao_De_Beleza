using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaoBeleza.API.Model
{
    public class Servico 
    {
        public int Id { get; set; }
        public DateTime Horario { get; private set; }
        public string Descricao { get; private set; }
        public List<TipoServico>  TipoServicos { get; private set; }
        public Usuario  Usuario { get; private set; }
        public Servico()
        {

        }
        public Servico(DateTime horario, string descricao, List<TipoServico> tipoServicos, Usuario usuario)
        {
            Horario = horario;
            Descricao = descricao;
            TipoServicos = tipoServicos;
            Usuario = usuario;
        }
    }
}
