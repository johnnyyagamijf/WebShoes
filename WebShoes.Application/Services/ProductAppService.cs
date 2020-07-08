using AutoMapper;
using System.Collections.Generic;
using WebShoes.Application.Contracts.Services;
using WebShoes.Application.ViewModels;
using WebShoes.Core.Contracts.Services;
using WebShoes.Core.Entities;

namespace WebShoes.Application.Services
{
    public class ProductAppService : IProductAppService
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductAppService(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public IEnumerable<ProductViewModel> GetAll()
        {
            var productEntities = _productService.GetAll();
            return _mapper.Map<IEnumerable<ProductEntity>, IEnumerable<ProductViewModel>>(productEntities);
        }

        public IEnumerable<ProductViewModel> GetByCategory(int categoryId)
        {
            var productEntities = _productService.GetByCategory(categoryId);
            return _mapper.Map<IEnumerable<ProductEntity>, IEnumerable<ProductViewModel>>(productEntities);
        }

        public ProductViewModel GetById(long id)
        {
            var productEntity = _productService.GetById(id);
            return _mapper.Map<ProductEntity, ProductViewModel>(productEntity);
        }
    }
}
