using Application.Features.Commands.Request;
using Application.Features.Commands.Response;
using Application.Interfaces;
using AutoMapper;
using MediatR;

namespace Application.Features.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            if (request != null)
            {
                var product = _mapper.Map<Domain.Entities.Product>(request);
                await _productRepository.Add(product);
                return new CreateProductCommandResponse()
                {
                    Description = product.Description ?? "",
                    Id = product.Id,
                    Price = product.Price,
                    Name = product.Name ?? ""
                };
            }
            return null;
        }
    }
}
