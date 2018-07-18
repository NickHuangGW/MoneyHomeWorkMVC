using MVCHomeWorkMoneyTemplate.Models;
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

        public UnitOfWork()
        {
            UnitDbContext = new DataBase();
        }

        public void CommitTrans()
        {
            UnitDbContext.SaveChanges();
        }
    }
}