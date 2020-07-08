using System.Collections.Generic;
using WebShoes.Application.ViewModels;

namespace WebShoes.Application.Contracts.Services
{
    public interface IRequestAppService
    {
        IEnumerable<RequestViewModel> GetAll();
        void Add(RequestViewModel requestViewModel);
    }
}
