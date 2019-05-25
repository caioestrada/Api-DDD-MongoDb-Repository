using C.Estudo.Mongodb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C.Estudo.Mongodb.Domain.Interfaces.Services
{
    public interface IUsuarioService
    {
        void Add(Usuario usuario);
        Usuario GetById(string id);
        IEnumerable<Usuario> GetAll();
        void Update(Usuario usuario);
        void Remove(string id);
    }
}
