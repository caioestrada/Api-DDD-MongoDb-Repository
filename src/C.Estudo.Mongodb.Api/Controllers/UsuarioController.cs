using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using C.Estudo.Mongodb.Application.AppServices.Interfaces;
using C.Estudo.Mongodb.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace C.Estudo.Mongodb.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioAppService _usuarioAppService;

        public UsuarioController(IUsuarioAppService usuarioAppService)
        {
            _usuarioAppService = usuarioAppService;
        }

        // GET: api/Usuario
        [HttpGet]
        public IEnumerable<UsuarioViewModel> Get()
        {
            return _usuarioAppService.GetAll();
        }

        // GET: api/Usuario/5
        [HttpGet("{id}", Name = "Get")]
        public UsuarioViewModel Get(string id)
        {
            return _usuarioAppService.GetById(id);
        }

        // POST: api/Usuario
        [HttpPost]
        public void Post([FromBody] UsuarioViewModel usuarioViewModel)
        {
            _usuarioAppService.Add(usuarioViewModel);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _usuarioAppService.Remove(id);
        }
    }
}
