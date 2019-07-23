using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySampleDataInterfaces.Common
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll();

        T Get(int id);

        void Add(T entity);

        void Remove(T entity);

    }
}
