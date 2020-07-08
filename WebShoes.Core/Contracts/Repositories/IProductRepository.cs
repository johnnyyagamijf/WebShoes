using System.Collections.Generic;
using WebShoes.Core.Entities;

namespace WebShoes.Core.Contracts.Repositories
{
    public interface IProductRepository : IRepository<ProductEntity>
    {
        IEnumerable<ProductEntity> GetByCategory(int categoryId);
        ProductEntity Find(long id);

    }
}
