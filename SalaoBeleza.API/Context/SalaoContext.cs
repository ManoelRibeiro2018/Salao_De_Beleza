using Microsoft.EntityFrameworkCore;
using SalaoBeleza.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaoBeleza.API.Context
{
    public class SalaoContext : DbContext
    {
        public SalaoContext(DbContextOptions<SalaoContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<TipoServico> TipoServicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
