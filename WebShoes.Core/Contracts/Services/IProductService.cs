using System.Collections.Generic;
using WebShoes.Core.Entities;

namespace WebShoes.Core.Contracts.Services
{
    public interface IProductService
    {
        ProductEntity GetById(long id);

        IEnumerable<ProductEntity> GetByCategory(int categoryId);
        IEnumerable<ProductEntity> GetAll();
    }
}
