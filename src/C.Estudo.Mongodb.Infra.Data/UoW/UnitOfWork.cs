using C.Estudo.Mongodb.Domain.Interfaces.Context;
using C.Estudo.Mongodb.Domain.Interfaces.UoW;

namespace C.Estudo.Mongodb.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IMongoContext _context;

        public UnitOfWork(IMongoContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
