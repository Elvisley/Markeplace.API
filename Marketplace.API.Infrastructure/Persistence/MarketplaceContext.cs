using System;
using Marketplace.API.Infrastructure.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Marketplace.API.Infrastructure.Persistence
{
    public class MarketplaceContext : DbContext
    {

        public MarketplaceContext(DbContextOptions<MarketplaceContext> dbco) :
        base(dbco)
        {
        }

        public DbSet<Domain.Domain.Marketplace> Marketplaces { set; get; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.ApplyConfiguration(new MarketplaceConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
