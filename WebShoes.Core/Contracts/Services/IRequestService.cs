using System.Collections.Generic;
using WebShoes.Core.Entities;

namespace WebShoes.Core.Contracts.Services
{
    public interface IRequestService
    {
        IEnumerable<RequestEntity> GetAll();

        void Add(RequestEntity requestEntity);
    }
}
