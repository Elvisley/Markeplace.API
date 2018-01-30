using System;
using System.Collections.Generic;
using Marketplace.API.Domain.RepositoriesContracts;

namespace Marketplace.API.Aplication.Services
{
    public class ServiceMarketplace
    {

        private readonly IRepositoryMarketplace _iRepositoryMarketplace;

        public ServiceMarketplace(IRepositoryMarketplace _rep)
        {
            _iRepositoryMarketplace = _rep;
        }

        public IEnumerable<Domain.Domain.Marketplace> GetAll(){
            return _iRepositoryMarketplace.GetAll();
        }

        public Domain.Domain.Marketplace Create(Domain.Domain.Marketplace  marketplace){
            return _iRepositoryMarketplace.Save(marketplace);
        }
    }
}
