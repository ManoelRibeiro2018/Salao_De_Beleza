using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalaoBeleza.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaoBeleza.API.Context.Configuration
{
    public class TipoServicoConfiguration : IEntityTypeConfiguration<TipoServico>
    {
        public void Configure(EntityTypeBuilder<TipoServico> builder)
        {
            builder
                .HasMany(t => t.Servicos)
                .WithMany(s => s.TipoServicos);
        }
    }
}
