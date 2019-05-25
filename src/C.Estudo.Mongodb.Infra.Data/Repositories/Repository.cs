using C.Estudo.Mongodb.Domain.Interfaces.Context;
using C.Estudo.Mongodb.Domain.Interfaces.Repositories;
using C.Estudo.Mongodb.Domain.Interfaces.UoW;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace C.Estudo.Mongodb.Infra.Data.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly IMongoContext _context;
        protected readonly IMongoCollection<TEntity> DbSet;
        protected readonly IUnitOfWork _uow;

        protected Repository(IMongoContext context, IUnitOfWork uow)
        {
            _context = context;
            _uow = uow;
            DbSet = _context.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public virtual void Add(TEntity obj)
        {
            _context.AddCommand(async () => await DbSet.InsertOneAsync(obj));
            _uow.Commit();
        }

        public virtual TEntity GetById(string id)
        {
            var data = DbSet.Find(Builders<TEntity>.Filter.Eq("_id", id));
            return data.FirstOrDefault();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            var all = DbSet.Find(Builders<TEntity>.Filter.Empty);
            return all.ToList();
        }

        public virtual void Update(TEntity obj)
        {
            _context.AddCommand(async () =>
            {
                await DbSet.ReplaceOneAsync(Builders<TEntity>.Filter.Eq("_id", obj), obj);
            });
            _uow.Commit();
        }

        public virtual void Remove(string id)
        {
            _context.AddCommand(() => DbSet.DeleteOneAsync(Builders<TEntity>.Filter.Eq("_id", id)));
            _uow.Commit();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
