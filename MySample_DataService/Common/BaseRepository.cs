using MySample_Domain.Common;
using MySampleDataInterfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySample_DataService.Common
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IEntity
    {
        private readonly IDatabaseContext _database;

        public BaseRepository(IDatabaseContext database)
        {
            _database = database;
        }

        public IQueryable<T> GetAll()
        {
            return _database.Set<T>();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
            //return _database.Set<T>();
                //.Single(p => p.Id == id);
        }

        public void Add(T entity)
        {
            _database.Set<T>().Add(entity);
        }

        public void Remove(T entity)
        {
            _database.Set<T>().Remove(entity);
        }

    }
}
