using AutoMapper;
using MediatR;
using ProductApp.Application.DTO;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<ServiceResponse<ProductViewDTO>>
    {
        public Guid Id { get; set; }




        public class GetProdcutByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<ProductViewDTO>>
        {
            private readonly IMapper mapper;
            private readonly IProductRepository productRepository;
            public GetProdcutByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
            {
                this.productRepository = productRepository;
                this.mapper = mapper;
            }

            public async Task<ServiceResponse<ProductViewDTO>> Handle(GetProductByIdQuery request,CancellationToken cancellationToken)
            {
                var product = await productRepository.GetByIdAsync(request.Id);
                var dto = mapper.Map<ProductViewDTO>(product);
                return new ServiceResponse<ProductViewDTO>(dto);
            }
        }


    }
}
