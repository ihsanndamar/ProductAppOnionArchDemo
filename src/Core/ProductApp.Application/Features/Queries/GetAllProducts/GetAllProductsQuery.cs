using MediatR;
using ProductApp.Application.DTO;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<List<ProductViewDTO>>
    {


        public class GetAllPRoductQueryHandler : IRequestHandler<GetAllProductsQuery, List<ProductViewDTO>>
        {
            private readonly IProductRepository productRepository;
            public GetAllPRoductQueryHandler(IProductRepository productRepository)
            {
                this.productRepository = productRepository;
            }
            public async Task<List<ProductViewDTO>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
            {
                var products = await productRepository.GetAllAsync();
                return products.Select(x => new ProductViewDTO { Id = x.Id, Name = x.Name }).ToList();
            }
        }
    }

}
