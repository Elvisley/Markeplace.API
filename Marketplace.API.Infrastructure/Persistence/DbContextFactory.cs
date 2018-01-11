using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Marketplace.API.Infrastructure.Persistence
{
    public class DbContextFactory : IDesignTimeDbContextFactory<MarketplaceContext>
    {
        public DbContextFactory()
        {
        }

        public MarketplaceContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MarketplaceContext>();
            builder.UseMySql("Server=localhost;Database=DB_MKTPLACE;Uid=root;Pwd=123456");
            return new MarketplaceContext(builder.Options);
        }
    }
}
