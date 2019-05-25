using C.Estudo.Mongodb.Application.AppServices.Interfaces;
using C.Estudo.Mongodb.Application.AppServices.Services;
using C.Estudo.Mongodb.Domain.Interfaces.Context;
using C.Estudo.Mongodb.Domain.Interfaces.Repositories;
using C.Estudo.Mongodb.Domain.Interfaces.Services;
using C.Estudo.Mongodb.Domain.Interfaces.UoW;
using C.Estudo.Mongodb.Domain.Services;
using C.Estudo.Mongodb.Infra.Data.Context;
using C.Estudo.Mongodb.Infra.Data.Repositories;
using C.Estudo.Mongodb.Infra.Data.UoW;
using Microsoft.Extensions.DependencyInjection;

namespace C.Estudo.Mongodb.Infra.IoC
{
    public static class BootStrapper
    {
        public static void Register(IServiceCollection services)
        {
            // Application
            services.AddScoped<IUsuarioAppService, UsuarioAppService>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();

            // Domain
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IProdutoService, ProdutoService>();

            // Repository
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();

            // Context
            services.AddScoped<IMongoContext, MongoContext>();

            // UoW
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
