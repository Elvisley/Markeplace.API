using System;
using System.Linq;

namespace Marketplace.API.Domain.RepositoriesContracts
{
    public interface IRepositoryGeneric<T>
    {
        T Get<TKey>(TKey id);

        IQueryable<T> GetAll();

        T Save(T entity);

        T Update(T entity, int key);

        void Delete(T Entity);

    }
}
