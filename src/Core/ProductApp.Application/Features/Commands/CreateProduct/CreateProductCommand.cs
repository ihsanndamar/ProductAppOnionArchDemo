using AutoMapper;
using MediatR;
using ProductApp.Application.DTO;
using ProductApp.Application.Features.Queries.GetAllProducts;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;
using ProductApp.Domain.Entities;

namespace ProductApp.Application.Features.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<ServiceResponse<Guid>>
    {
        public String Name { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }
        
        


        
        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand,ServiceResponse<Guid>> 
        {
            private readonly IProductRepository productRepository;
            private readonly IMapper mapper;

            public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
            {
                this.productRepository = productRepository;
                this.mapper = mapper;
            }



            public async Task<ServiceResponse<Guid>> Handle(CreateProductCommand command, CancellationToken cancellationToken)
            {
                Product product = mapper.Map<Product>(command);
                await productRepository.AddAsync(product);
                return new ServiceResponse<Guid>(product.Id);
            }
        }
    }
}
