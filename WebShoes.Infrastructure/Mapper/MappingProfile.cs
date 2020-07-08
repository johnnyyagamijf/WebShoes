using AutoMapper;
using WebShoes.Application.ViewModels;
using WebShoes.Core.Entities;

namespace WebShoes.Infrastructure.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<ProductEntity, ProductViewModel>().ReverseMap();
            this.CreateMap<RequestEntity, RequestViewModel>().ReverseMap();
        }
    }
}
