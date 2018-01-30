using System;
using System.Collections.Generic;
using System.Linq;

namespace Marketplace.API.Domain.RepositoriesContracts
{
    public interface IRepositoryGeneric<T> where T : class
    {
        T GetById<TKey>(TKey id);

        IEnumerable<T> GetAll();

        T Save(T entity);

        T Update(T entity, int key);

        void Delete(T Entity);

    }
}
