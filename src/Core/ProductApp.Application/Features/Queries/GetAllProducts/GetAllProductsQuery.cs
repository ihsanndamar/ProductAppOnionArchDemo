using AutoMapper;
using MediatR;
using ProductApp.Application.DTO;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Mapping;
using ProductApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<ServiceResponse<List<ProductViewDTO>>>
    {


        public class GetAllPRoductQueryHandler : IRequestHandler<GetAllProductsQuery, ServiceResponse<List<ProductViewDTO>>>
        {
            private readonly IProductRepository productRepository;
            private readonly IMapper mapper;
            public GetAllPRoductQueryHandler(IProductRepository productRepository, IMapper mapper)
            {
                this.productRepository = productRepository;
                this.mapper = mapper;
            }
            public async Task<ServiceResponse<List<ProductViewDTO>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
            {
                var products = await productRepository.GetAllAsync();
                var viewModel = mapper.Map<List<ProductViewDTO>>(products);
                return new ServiceResponse<List<ProductViewDTO>>(viewModel);
            }
        }
    }

}
