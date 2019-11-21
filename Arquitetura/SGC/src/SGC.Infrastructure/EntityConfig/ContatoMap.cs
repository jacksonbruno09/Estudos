using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.Infrastructure.EntityConfig
{
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {

            builder
                .HasOne(c => c.Cliente)
                .WithMany(c => c.Contatos)
                .HasForeignKey(c => c.ClienteID)
                .HasPrincipalKey(c => c.ClienteID)
                .OnDelete(DeleteBehavior.Restrict); 

            builder
               .Property(e => e.nome)
               .HasColumnType("varchar(200)")
               .IsRequired();

            builder
                .Property(e => e.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();


            builder
                .Property(e => e.Telefone)
                .HasColumnType("varchar(15)");
        }
    }
}
