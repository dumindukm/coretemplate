using MySampleDataInterfaces.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySample_DataService.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseContext dbContext;

        public UnitOfWork(IDatabaseContext database)
        {
            dbContext = database;
        }

        public void Save()
        {
            dbContext.Save();
        }
    }
}
