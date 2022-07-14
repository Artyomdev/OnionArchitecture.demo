using Application.Features.Commands.Request;
using Application.Features.Commands.Response;
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
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, UpdateProductCommandResponse>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<UpdateProductCommandResponse> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {

            if (request.Id != Guid.Empty)
            {
                var product = await _productRepository.GetById(request.Id);
                if (product != null)
                {
                    product.Name = request.Name;
                    product.Price = request.Price;
                    product.Description = request.Description;
                    await _productRepository.Update(product);
                    return _mapper.Map<UpdateProductCommandResponse>(request);
                }
            }
            return null;
        }
    }
}
