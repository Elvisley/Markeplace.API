using System;
using System.Linq;
using Marketplace.API.Domain.RepositoriesContracts;
using Marketplace.API.Infrastructure.Persistence;

namespace Marketplace.API.Infrastructure.Repositories
{
    public class RepositoryGeneric<T> where T : class, IRepositoryGeneric<T>
    {
        protected MarketplaceContext _context;

        public RepositoryGeneric(MarketplaceContext _marketplaceContext)
        {
            this._context = _marketplaceContext;
        }

        public void Delete(T Entity)
        {
            try{
                _context.Set<T>().Remove(Entity);    
            }catch(Exception ex){
                throw ex;
            }
        }

        public T Get<TKey>(TKey id)
        {
            return _context.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().ToList().AsQueryable();
        }

        public T Save(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public T Update(T entity, int key)
        {
            if(entity == null){
                return null;
            }

            T entityUpdtd = _context.Set<T>().Find(key);

            if(entityUpdtd != null){
                _context.Entry(entityUpdtd).CurrentValues.SetValues(entity);
                _context.SaveChanges();
            }

            return entityUpdtd;

        }

    }
}
