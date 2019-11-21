﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.ApplicationCore.Entity;


namespace SGC.Infrastructure.EntityConfig
{
    public class ProfissaoClienteMap : IEntityTypeConfiguration<ProfissaoCliente>
    {
        public void Configure(EntityTypeBuilder<ProfissaoCliente> builder)
        {
            builder
                .HasKey(c => c.Id);

           builder
                .HasOne(pc => pc.Cliente)
                .WithMany(c => c.profissoesClientes)
                .HasForeignKey(c => c.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(pc => pc.Profissao)
                .WithMany(c => c.profissoesClientes)
                .HasForeignKey(c => c.ProfissaoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
