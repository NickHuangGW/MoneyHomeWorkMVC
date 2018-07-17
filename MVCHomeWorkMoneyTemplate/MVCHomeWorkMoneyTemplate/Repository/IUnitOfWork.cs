using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHomeWorkMoneyTemplate.Repository
{
    public interface IUnitOfWork
    {
        DbContext UnitDbContext { get; set; }

        void CommitTrans();
    }
}
