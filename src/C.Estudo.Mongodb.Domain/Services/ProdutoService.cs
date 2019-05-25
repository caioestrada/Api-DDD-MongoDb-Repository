using C.Estudo.Mongodb.Domain.Entities;
using C.Estudo.Mongodb.Domain.Interfaces.Repositories;
using C.Estudo.Mongodb.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C.Estudo.Mongodb.Domain.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void Add(Produto produto)
        {
            _produtoRepository.Add(produto);
        }

        public IEnumerable<Produto> GetAll()
        {
            return _produtoRepository.GetAll();
        }

        public Produto GetById(string id)
        {
            return _produtoRepository.GetById(id);
        }

        public void Remove(string id)
        {
            _produtoRepository.Remove(id);
        }

        public void Update(Produto produto)
        {
            _produtoRepository.Update(produto);
        }
    }
}
