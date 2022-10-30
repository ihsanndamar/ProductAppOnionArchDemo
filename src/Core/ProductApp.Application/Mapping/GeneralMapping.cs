using AutoMapper;
using ProductApp.Application.DTO;
using ProductApp.Domain.Entities;



namespace ProductApp.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product, ProductViewDTO>().ReverseMap();

        }
    }
}
