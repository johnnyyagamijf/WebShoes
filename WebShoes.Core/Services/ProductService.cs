using System.Collections.Generic;
using WebShoes.Core.Contracts.Repositories;
using WebShoes.Core.Contracts.Services;
using WebShoes.Core.Entities;

namespace WebShoes.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<ProductEntity> GetAll()
        {
            return _productRepository.GetAll();
        }

        public IEnumerable<ProductEntity> GetByCategory(int categoryId)
        {
            return _productRepository.GetByCategory(categoryId);
        }

        public ProductEntity GetById(long id)
        {
            return _productRepository.Find(id);
        }
    }
}
