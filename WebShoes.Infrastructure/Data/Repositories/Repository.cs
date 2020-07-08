using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WebShoes.Core.Contracts.Repositories;
using WebShoes.Infrastructure.Data.Context;

namespace WebShoes.Infrastructure.Data.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly WebShoesDataModelContext _dbContext;

        public void Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
