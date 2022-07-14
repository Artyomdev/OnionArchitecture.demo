using Application.Features.Commands.Request;
using Application.Features.Commands.Response;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class GeneralProfile:Profile
    {
        public GeneralProfile()
        {
            CreateMap<CreateProductCommandRequest, Product>();
            CreateMap<UpdateProductCommandRequest, Product>();
            CreateMap<UpdateProductCommandRequest, UpdateProductCommandResponse>();
            CreateMap<Product, UpdateProductCommandResponse>();
        }
    }
}
