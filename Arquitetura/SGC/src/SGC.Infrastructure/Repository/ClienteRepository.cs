using SGC.ApplicationCore.Entity;
using SGC.ApplicationCore.Interfaces.Repository;
using SGC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGC.Infrastructure.Repository
{
    public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ClienteContext dbcontext):base(dbcontext)
        {

        }

        public override Cliente Adicionar(Cliente entity)
        {
            var verificaResultado = "";

            //TODO :  implementa especificacao para adicionar um cliente
            //fazendo a sobrescrita de metodo - polimorfismo

            _dbContext.Set<Cliente>().Add(entity);
            _dbContext.SaveChanges();

            return entity;
        }

        public Cliente ObterPorProfissao(int clientID)
        {
            return Buscar(x => x.profissoesClientes.Any(p => p.ClienteId == clientID))
                .FirstOrDefault();
        }
    }
}
