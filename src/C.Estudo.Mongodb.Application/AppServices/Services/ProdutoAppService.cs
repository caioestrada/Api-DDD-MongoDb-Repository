using AutoMapper;
using C.Estudo.Mongodb.Application.AppServices.Interfaces;
using C.Estudo.Mongodb.Application.ViewModels;
using C.Estudo.Mongodb.Domain.Entities;
using C.Estudo.Mongodb.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace C.Estudo.Mongodb.Application.AppServices.Services
{
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly IProdutoService _produtoService;
        private readonly IMapper _mapper;

        public ProdutoAppService(IProdutoService produtoService, IMapper mapper)
        {
            _produtoService = produtoService;
            _mapper = mapper;
        }

        public void Add(ProdutoViewModel produto)
        {
            var produtoEntity = _mapper.Map<Produto>(produto);
            produtoEntity.Id = Guid.NewGuid().ToString();
            _produtoService.Add(produtoEntity);
        }

        public IEnumerable<ProdutoViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<ProdutoViewModel>>(_produtoService.GetAll());
        }

        public ProdutoViewModel GetById(string id)
        {
            return _mapper.Map<ProdutoViewModel>(_produtoService.GetById(id));
        }

        public void Remove(string id)
        {
            _produtoService.Remove(id);
        }

        public void Update(ProdutoViewModel produto)
        {
            var produtoEntity = _mapper.Map<Produto>(produto);
            _produtoService.Update(produtoEntity);
        }
    }
}
