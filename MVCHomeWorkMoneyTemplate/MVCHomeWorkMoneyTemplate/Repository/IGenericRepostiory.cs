using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVCHomeWorkMoneyTemplate.Repository
{
    public interface IGenericRepostiory<T>
    {
        IUnitOfWork UnitOfWork { get; set; }

        IQueryable<T> GetAll();

        IQueryable<T> Query(Expression<Func<T, bool>> predicate);

        void Create(T model);

        void Delete(T model);

        void Update(T model);

    }
}
