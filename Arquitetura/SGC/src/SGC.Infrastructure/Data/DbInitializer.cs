using SGC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGC.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ClienteContext context)
        {
            if (context.Clientes.Any())
            {
                return;
            }

            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome = "Fulano da Silva",
                    CPF = "51632866099"
                },

                new Cliente
                {
                    Nome = "Beltrano da Silva",
                    CPF = "13913951075"
                }
            };

            context.AddRange(clientes);

            var contatos = new Contato[]
            {
                new Contato
                {
                    nome = "Contato1",
                    Telefone = "99999999",
                    Email = "emailcontato1@teste.com",
                    Cliente = clientes[0]
                },
                new Contato
                {
                    nome = "Contato2",
                    Telefone = "99933333",
                    Email = "emailcontato2@teste.com",
                    Cliente = clientes[1]
                }
            };

            context.AddRange(contatos);

            context.SaveChanges();
        }
    }
}
