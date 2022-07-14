using Application.Interfaces;
using Domain.Entities;
using Persistence.Context;
using Persistence.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ProductRepository:BaseRepository<Product > , IProductRepository
    {
        public ProductRepository(AppDbContext dbContext):base(dbContext)
        {

        }
    }
}
