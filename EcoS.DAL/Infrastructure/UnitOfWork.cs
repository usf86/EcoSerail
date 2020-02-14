using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoS.DAL.Infrastructure
{
    public class UnitOfWork
    {
        private readonly EcoBaseEntities _dbContext;

        public UnitOfWork()
        {
            _dbContext = new EcoBaseEntities();
        }

        public DbContext Db
        {
            get { return _dbContext; }
        }

        public void Dispose()
        {
        }
    }
}
