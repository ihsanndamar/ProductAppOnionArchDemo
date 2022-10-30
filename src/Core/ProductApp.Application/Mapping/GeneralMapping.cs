using AutoMapper;
using ProductApp.Application.DTO;
using ProductApp.Application.Features.Commands.CreateProduct;
using ProductApp.Domain.Entities;



namespace ProductApp.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product, ProductViewDTO>().ReverseMap();
            CreateMap<Product, CreateProductCommand > ().ReverseMap();
            
        }
    }
}
