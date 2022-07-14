using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Generic
{
    public interface IEntityRepository<TEntity> where TEntity : BaseEntity
    {
        Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null);
        Task<TEntity> GetById(Guid id);
        Task Update(TEntity entity);
        Task Add(TEntity entity);
        Task Delete(Guid id);
    }
}
