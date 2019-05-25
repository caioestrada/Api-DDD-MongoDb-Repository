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
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoAppService _produtoAppService;

        public ProdutoController(IProdutoAppService produtoAppService)
        {
            _produtoAppService = produtoAppService;
        }

        // GET: api/Usuario
        [HttpGet]
        public IEnumerable<ProdutoViewModel> Get()
        {
            return _produtoAppService.GetAll();
        }

        // GET: api/Usuario/5
        [HttpGet("{id}", Name = "GetById")]
        public ProdutoViewModel Get(string id)
        {
            var usuario = _produtoAppService.GetById(id);
            return usuario;
        }

        // POST: api/Usuario
        [HttpPost]
        public void Post([FromBody] ProdutoViewModel produtoViewModel)
        {
            _produtoAppService.Add(produtoViewModel);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _produtoAppService.Remove(id);
        }
    }
}