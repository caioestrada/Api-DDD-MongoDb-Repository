using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C.Estudo.Mongodb.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(string id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(string id);
    }
}
