using System;

namespace C.Estudo.Mongodb.Domain.Interfaces.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
