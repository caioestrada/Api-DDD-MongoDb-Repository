using AutoMapper;
using C.Estudo.Mongodb.Application.ViewModels;
using C.Estudo.Mongodb.Domain.Entities;

namespace C.Estudo.Mongodb.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UsuarioViewModel, Usuario>();
            CreateMap<ProdutoViewModel, Produto>();
        }
    }
}
