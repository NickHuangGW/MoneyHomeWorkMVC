using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MVCHomeWorkMoneyTemplate.Repository
{
    public class GenericRepostiory<T> : IGenericRepostiory<T> where T : class
    {
        public IUnitOfWork UnitOfWork { get; set; }

        private DbSet<T> EfDbSet { get; set; }

        public GenericRepostiory(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            EfDbSet = UnitOfWork.UnitDbContext.Set<T>();
        }

        public void Create(T model)
        {
            EfDbSet.Add(model);
        }

        public void Delete(T model)
        {
            EfDbSet.Remove(model);
        }

        public IQueryable<T> GetAll()
        {
            return EfDbSet.AsQueryable();
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> predicate)
        {
            return EfDbSet.Where(predicate);
        }

        public void Update(T model)
        {
            //未實作
            throw new NotImplementedException();
        }
    }
}