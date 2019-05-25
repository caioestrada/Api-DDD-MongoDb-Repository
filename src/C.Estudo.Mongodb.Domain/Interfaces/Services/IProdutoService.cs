using C.Estudo.Mongodb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace C.Estudo.Mongodb.Domain.Interfaces.Services
{
    public interface IProdutoService
    {
        void Add(Produto produto);
        Produto GetById(string id);
        IEnumerable<Produto> GetAll();
        void Update(Produto produto);
        void Remove(string id);
    }
}
