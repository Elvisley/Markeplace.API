using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Marketplace.API.Domain;

namespace Marketplace.API.Infrastructure.Persistence.Configuration
{
    public class MarketplaceConfiguration : IEntityTypeConfiguration<Domain.Domain.Marketplace>
    {
        public void Configure(EntityTypeBuilder<Domain.Domain.Marketplace> builder)
        {
            builder.ToTable("MARKETPLACE");
            builder.HasKey(mn => mn.Id).HasName("ID");
            builder.Property(mn => mn.Name).HasMaxLength(200).IsRequired().HasColumnName("NAME");
            builder.Property(mn => mn.Address).HasMaxLength(200).IsRequired().HasColumnName("ADDRESS");
            builder.Property(mn => mn.LocationMaps).HasMaxLength(60).HasColumnName("LOCATION_MAPS");
            builder.Property(mn => mn.Phone).HasMaxLength(10).IsRequired().HasColumnName("PHONE");
            builder.Property(mn => mn.Photo).HasMaxLength(100).IsRequired().HasColumnName("PHOTO");
            builder.Property(mn => mn.SocialReason).HasMaxLength(250).IsRequired().HasColumnName("SOCIAL_REASON");
        }
    }
}
