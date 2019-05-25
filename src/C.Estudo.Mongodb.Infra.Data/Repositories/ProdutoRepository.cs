using C.Estudo.Mongodb.Domain.Entities;
using C.Estudo.Mongodb.Domain.Interfaces.Context;
using C.Estudo.Mongodb.Domain.Interfaces.Repositories;
using C.Estudo.Mongodb.Domain.Interfaces.UoW;

namespace C.Estudo.Mongodb.Infra.Data.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(IMongoContext context, IUnitOfWork uow) : base(context, uow)
        {
        }
    }
}
