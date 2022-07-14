using Application.Features.Commands.Request;
using Application.Interfaces;
using MediatR;

namespace Application.Features.Handlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductByIdCommandRequest, bool>
    {
        private readonly IProductRepository _productRepository;

        public DeleteProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<bool> Handle(DeleteProductByIdCommandRequest request, CancellationToken cancellationToken)
        {
            if (request.Id != Guid.Empty)
            {
                await _productRepository.Delete(request.Id);
                return true;
            }
            return false;
        }
    }
}
