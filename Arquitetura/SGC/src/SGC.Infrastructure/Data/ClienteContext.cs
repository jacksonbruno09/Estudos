﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SGC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.Infrastructure.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            modelBuilder.Entity<Profissao>().ToTable("Profissao");
            modelBuilder.Entity<ProfissaoCliente>().ToTable("ProfissaoCliente");

            #region Configuracoes de Cliente

            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.ClienteID);

            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.Contatos)
                .WithOne(c => c.Cliente)
                .HasForeignKey(c => c.ClienteID)
                .HasPrincipalKey(c => c.ClienteID);


            modelBuilder.Entity<Cliente>().Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            modelBuilder.Entity<Cliente>().Property(e => e.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();


            #endregion

            #region Configuracoes de Contato

            modelBuilder.Entity<Contato>()
                .HasOne(c => c.Cliente)
                .WithMany(c => c.Contatos)
                .HasForeignKey(c => c.ClienteID)
                .HasPrincipalKey(c => c.ClienteID);

            modelBuilder.Entity<Contato>().Property(e => e.nome)
           .HasColumnType("varchar(200)")
           .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.Email)
                 .HasColumnType("varchar(100)")
                 .IsRequired();


            modelBuilder.Entity<Contato>().Property(e => e.Telefone)
                 .HasColumnType("varchar(15)");
            #endregion

            #region Configuracoes de Profissoes

            modelBuilder.Entity<Profissao>().Property(p => p.CBO)
                .HasColumnType("varchar(10)")
                .IsRequired();

            modelBuilder.Entity<Profissao>().Property(p => p.Nome)
                .HasColumnType("varchar(400)")
                .IsRequired();

            modelBuilder.Entity<Profissao>().Property(p => p. Descricao)
              .HasColumnType("varchar(1000)")
              .IsRequired();
            #endregion

            #region Configuracoes de Endereco

            modelBuilder.Entity<Endereco>().Property(end => end.Bairro)
              .HasColumnType("varchar(200)")
              .IsRequired();

            modelBuilder.Entity<Endereco>().Property(end => end.CEP)
              .HasColumnType("varchar(15)")
              .IsRequired();

            modelBuilder.Entity<Endereco>().Property(end => end.Logradouro)
              .HasColumnType("varchar(200)")
              .IsRequired();

            modelBuilder.Entity<Endereco>().Property(end => end.Referencia)
              .HasColumnType("varchar(400)");

            #endregion

            #region Configuracoes de ProfisaoCliente

            modelBuilder.Entity<ProfissaoCliente>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<ProfissaoCliente>()
                .HasOne(pc => pc.Cliente)
                .WithMany(c => c.profissoesClientes)
                .HasForeignKey(c => c.ClienteId);

            modelBuilder.Entity<ProfissaoCliente>()
                .HasOne(pc => pc.Profissao)
                .WithMany(c => c.profissoesClientes)
                .HasForeignKey(c => c.ProfissaoId);
            #endregion

            #region Configuracoes de Menu
            modelBuilder.Entity<Menu>()
                .HasMany(x => x.SubMenu)
                .WithOne()
                .HasForeignKey(x => x.MenuId);
            #endregion
        }
    }
}
