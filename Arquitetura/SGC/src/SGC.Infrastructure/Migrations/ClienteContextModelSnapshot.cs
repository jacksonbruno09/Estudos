﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SGC.Infrastructure.Data;

namespace SGC.Infrastructure.Migrations
{
    [DbContext(typeof(ClienteContext))]
    partial class ClienteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SGC.ApplicationCore.Entity.Cliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("ClienteID");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SGC.ApplicationCore.Entity.Contato", b =>
                {
                    b.Property<int>("ContatoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteID");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("EnderecoID");

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("ContatoID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("EnderecoID");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("SGC.ApplicationCore.Entity.Endereco", b =>
                {
                    b.Property<int>("EnderecoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<int>("ClienteID");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Referencia")
                        .HasColumnType("varchar(400)");

                    b.HasKey("EnderecoID");

                    b.HasIndex("ClienteID")
                        .IsUnique();

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("SGC.ApplicationCore.Entity.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MenuId");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("SGC.ApplicationCore.Entity.Profissao", b =>
                {
                    b.Property<int>("ProfissaoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CBO")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(400)");

                    b.HasKey("ProfissaoID");

                    b.ToTable("Profissao");
                });

            modelBuilder.Entity("SGC.ApplicationCore.Entity.ProfissaoCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId");

                    b.Property<int>("ProfissaoId");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ProfissaoId");

                    b.ToTable("ProfissaoCliente");
                });

            modelBuilder.Entity("SGC.ApplicationCore.Entity.Contato", b =>
                {
                    b.HasOne("SGC.ApplicationCore.Entity.Cliente", "Cliente")
                        .WithMany("Contatos")
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SGC.ApplicationCore.Entity.Endereco")
                        .WithMany("Contatos")
                        .HasForeignKey("EnderecoID");
                });

            modelBuilder.Entity("SGC.ApplicationCore.Entity.Endereco", b =>
                {
                    b.HasOne("SGC.ApplicationCore.Entity.Cliente", "Cliente")
                        .WithOne("Endereco")
                        .HasForeignKey("SGC.ApplicationCore.Entity.Endereco", "ClienteID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGC.ApplicationCore.Entity.Menu", b =>
                {
                    b.HasOne("SGC.ApplicationCore.Entity.Menu")
                        .WithMany("SubMenu")
                        .HasForeignKey("MenuId");
                });

            modelBuilder.Entity("SGC.ApplicationCore.Entity.ProfissaoCliente", b =>
                {
                    b.HasOne("SGC.ApplicationCore.Entity.Cliente", "Cliente")
                        .WithMany("profissoesClientes")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SGC.ApplicationCore.Entity.Profissao", "Profissao")
                        .WithMany("profissoesClientes")
                        .HasForeignKey("ProfissaoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
