using AutoMapper;
using C.Estudo.Mongodb.Application.ViewModels;
using C.Estudo.Mongodb.Domain.Entities;

namespace C.Estudo.Mongodb.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
        }
    }
}
