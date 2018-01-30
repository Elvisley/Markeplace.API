using System;
using Marketplace.API.Domain.RepositoriesContracts;
using Marketplace.API.Infrastructure.Persistence;

namespace Marketplace.API.Infrastructure.Repositories
{
    public class RepositoryMarketplace : RepositoryGeneric<Domain.Domain.Marketplace>, IRepositoryMarketplace
    {
        public RepositoryMarketplace(MarketplaceContext _marketplaceContext) : base(_marketplaceContext)
        {
        }
    }
}
