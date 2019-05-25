using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace C.Estudo.Mongodb.Domain.Interfaces.Context
{
    public interface IMongoContext : IDisposable
    {
        void AddCommand(Func<Task> func);
        int SaveChanges();
        IMongoCollection<T> GetCollection<T>(string name);
    }
}
