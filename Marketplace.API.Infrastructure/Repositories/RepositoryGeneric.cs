using System;
using System.Collections.Generic;
using System.Linq;
using Marketplace.API.Domain.RepositoriesContracts;
using Marketplace.API.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Marketplace.API.Infrastructure.Repositories
{
    public class RepositoryGeneric<T> : IRepositoryGeneric<T> where T : class
    {
        private readonly MarketplaceContext _context;


        public RepositoryGeneric(MarketplaceContext _marketplaceContext)
        {
            this._context = _marketplaceContext;

        }

        public void Delete(T Entity)
        {
            try{
                _context.Set<T>().Remove(Entity);
                _context.SaveChanges();
            }catch(Exception ex){
                throw ex;
            }
        }

        public T GetById<TKey>(TKey id)
        {
            try{
                return this._context.Set<T>().Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetAll()
        {
            try{
                return this._context.Set<T>().AsNoTracking();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T Save(T entity)
        {
            try{
                _context.Set<T>().Add(entity);
                _context.SaveChanges();
                return entity; 
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public T Update(T entity, int key)
        {
            try{
                _context.Set<T>().Update(entity);
                _context.SaveChanges();
                return entity;
            } catch (Exception ex) {
                throw ex;
            }


        }

    }
}
