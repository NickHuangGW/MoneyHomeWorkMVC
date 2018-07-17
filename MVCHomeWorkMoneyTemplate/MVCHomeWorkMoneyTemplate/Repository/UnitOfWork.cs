using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCHomeWorkMoneyTemplate.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext UnitDbContext { get; set; }

        public UnitOfWork(DbContext dbContext)
        {
            UnitDbContext = dbContext;
        }

        public void CommitTrans()
        {
            UnitDbContext.SaveChanges();
        }
    }
}