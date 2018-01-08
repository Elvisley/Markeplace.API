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
            builder.UseMySql("Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;");
            return new MarketplaceContext(builder.Options);
        }
    }
}
