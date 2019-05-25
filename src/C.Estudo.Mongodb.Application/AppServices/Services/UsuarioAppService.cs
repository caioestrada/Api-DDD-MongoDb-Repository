using AutoMapper;
using C.Estudo.Mongodb.Application.AppServices.Interfaces;
using C.Estudo.Mongodb.Application.ViewModels;
using C.Estudo.Mongodb.Domain.Entities;
using C.Estudo.Mongodb.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace C.Estudo.Mongodb.Application.AppServices.Services
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IMapper _mapper;

        public UsuarioAppService(IUsuarioService usuarioService, IMapper mapper)
        {
            _usuarioService = usuarioService;
            _mapper = mapper;
        }

        public void Add(UsuarioViewModel usuario)
        {
            var usuarioEntity = _mapper.Map<Usuario>(usuario);
            usuarioEntity.Id = Guid.NewGuid().ToString();
            _usuarioService.Add(usuarioEntity);
        }

        public IEnumerable<UsuarioViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<UsuarioViewModel>>(_usuarioService.GetAll());
        }

        public UsuarioViewModel GetById(string id)
        {
            return _mapper.Map<UsuarioViewModel>(_usuarioService.GetById(id));
        }

        public void Remove(string id)
        {
            _usuarioService.Remove(id);
        }

        public void Update(UsuarioViewModel usuario)
        {
            var usuarioEntity = _mapper.Map<Usuario>(usuario);
            _usuarioService.Update(usuarioEntity);
        }
    }
}
