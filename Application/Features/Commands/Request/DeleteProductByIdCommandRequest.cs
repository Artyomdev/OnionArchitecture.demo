using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Commands.Request
{
    public class DeleteProductByIdCommandRequest:IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
