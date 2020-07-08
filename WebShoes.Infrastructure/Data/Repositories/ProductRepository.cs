using System.Collections.Generic;
using System.Linq;
using WebShoes.Core.Contracts.Repositories;
using WebShoes.Core.Entities;

namespace WebShoes.Infrastructure.Data.Repositories
{
    public class ProductRepository : Repository<ProductEntity>, IProductRepository
    {

        public ProductEntity Find(long id)
        {
            return _dbContext.Set<ProductEntity>().FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<ProductEntity> GetByCategory(int categoryId)
        {
            return null;
        }
    }
}
