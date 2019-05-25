using C.Estudo.Mongodb.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C.Estudo.Mongodb.Application.AppServices.Interfaces
{
    public interface IUsuarioAppService
    {
        void Add(UsuarioViewModel usuario);
        UsuarioViewModel GetById(string id);
        IEnumerable<UsuarioViewModel> GetAll();
        void Update(UsuarioViewModel usuario);
        void Remove(string id);
    }
}
