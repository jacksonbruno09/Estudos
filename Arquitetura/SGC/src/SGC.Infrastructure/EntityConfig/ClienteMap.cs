using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.Infrastructure.EntityConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder
                 .HasKey(c => c.ClienteID);

            //associacao 1 para 1
            builder.HasOne(x => x.Endereco)
                .WithOne(x => x.Cliente)
                .HasForeignKey<Endereco>(x => x.ClienteID);

           builder
                .HasMany(c => c.Contatos)
                .WithOne(c => c.Cliente)
                .HasForeignKey(c => c.ClienteID)
                .HasPrincipalKey(c => c.ClienteID)
                .OnDelete(DeleteBehavior.Restrict);


            builder
                .Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder
                .Property(e => e.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();


        }
    }
}
