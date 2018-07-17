using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MVCHomeWorkMoneyTemplate.Repository
{
    public class GenericRepostiory<T> : IGenericRepostiory<T> where T : class
    {
        public IUnitOfWork UnitOfWork { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Create(T model)
        {
            throw new NotImplementedException();
        }

        public void Delete(T model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(T model)
        {
            throw new NotImplementedException();
        }
    }
}