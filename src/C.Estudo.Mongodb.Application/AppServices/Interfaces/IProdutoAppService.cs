using C.Estudo.Mongodb.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C.Estudo.Mongodb.Application.AppServices.Interfaces
{
    public interface IProdutoAppService
    {
        void Add(ProdutoViewModel produto);
        ProdutoViewModel GetById(string id);
        IEnumerable<ProdutoViewModel> GetAll();
        void Update(ProdutoViewModel produto);
        void Remove(string id);
    }
}
