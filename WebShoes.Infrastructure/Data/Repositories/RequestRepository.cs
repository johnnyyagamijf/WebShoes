using System;
using System.Collections.Generic;
using System.Text;
using WebShoes.Core.Contracts.Repositories;
using WebShoes.Core.Entities;

namespace WebShoes.Infrastructure.Data.Repositories
{
    public class RequestRepository : Repository<RequestEntity>, IRequestRepository
    {
    }
}
