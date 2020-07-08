using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace WebShoes.Core.Contracts.Repositories
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity entity);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity entity);
    }
}
