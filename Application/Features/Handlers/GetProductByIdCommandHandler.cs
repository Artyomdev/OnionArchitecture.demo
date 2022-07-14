using Application.Features.Queries.Request;
using Application.Features.Queries.Response;
using Application.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Handlers
{
    public class GetProductByIdCommandHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResponse>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductByIdCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }


        public async Task<GetProductByIdQueryResponse> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            if (request.Id == Guid.Empty) return null;
            var product = await _productRepository.GetById(request.Id);  
            if (product == null) return null;
            return new GetProductByIdQueryResponse()
            {
                Id = product.Id,
                Description = product.Description ?? "",
                Price = product.Price,
                Name = product.Name ?? ""
            };


        }
    }
}
