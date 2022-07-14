using Application.Features.Queries.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Queries.Request
{
    public class GetProductByIdQuery : IRequest<GetProductByIdQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
