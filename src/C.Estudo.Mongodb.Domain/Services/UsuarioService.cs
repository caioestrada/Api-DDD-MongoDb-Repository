using C.Estudo.Mongodb.Domain.Entities;
using C.Estudo.Mongodb.Domain.Interfaces.Repositories;
using C.Estudo.Mongodb.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C.Estudo.Mongodb.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void Add(Usuario usuario)
        {
            _usuarioRepository.Add(usuario);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _usuarioRepository.GetAll();
        }

        public Usuario GetById(string id)
        {
            return _usuarioRepository.GetById(id);
        }

        public void Remove(string id)
        {
            _usuarioRepository.Remove(id);
        }

        public void Update(Usuario usuario)
        {
            _usuarioRepository.Update(usuario);
        }
    }
}
