using System.Collections.Generic;
using WebShoes.Application.ViewModels;

namespace WebShoes.Application.Contracts.Services
{
    public interface IProductAppService
    {
        ProductViewModel GetById(long id);
        IEnumerable<ProductViewModel> GetByCategory(int categoryId);
        IEnumerable<ProductViewModel> GetAll();
    }
}
