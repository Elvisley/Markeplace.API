using System;
using System.Linq;

namespace Marketplace.API.Domain.RepositoriesContracts
{
    public interface IRepositoryGeneric<T>
    {
        T Get<TKey>(TKey id);

        IQueryable<T> GetAll();

        void Save(T entity);

        void Update(T entity);

        void Delete(T Entity);
    }
}
