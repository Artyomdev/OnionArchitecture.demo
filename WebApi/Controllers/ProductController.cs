using Application.Features.Commands.Request;
using Application.Features.Queries.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("productId")]
        public async Task<IActionResult> GetProductById(GetProductByIdQuery query)
        {
            return Ok(await _mediator.Send(new GetProductByIdQuery { Id = query.Id }));
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommandRequest command)
        {
            return Ok(await _mediator.Send(command));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommandRequest command)
        {
            return Ok(await _mediator.Send(command));
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(DeleteProductByIdCommandRequest request)
        {
            return Ok(await _mediator.Send(new DeleteProductByIdCommandRequest { Id = request.Id }));
        }

    }
}
