﻿// <auto-generated />
using Marketplace.API.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Marketplace.API.Infrastructure.Migrations
{
    [DbContext(typeof(MarketplaceContext))]
    [Migration("20180111003747_InitialMigrationMarketplace")]
    partial class InitialMigrationMarketplace
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("Marketplace.API.Domain.Domain.Marketplace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("ADDRESS")
                        .HasMaxLength(200);

                    b.Property<string>("LocationMaps")
                        .HasColumnName("LOCATION_MAPS")
                        .HasMaxLength(60);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("NAME")
                        .HasMaxLength(200);

                    b.Property<int>("Phone")
                        .HasColumnName("PHONE")
                        .HasMaxLength(10);

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnName("PHOTO")
                        .HasMaxLength(100);

                    b.Property<string>("SocialReason")
                        .IsRequired()
                        .HasColumnName("SOCIAL_REASON")
                        .HasMaxLength(250);

                    b.HasKey("Id")
                        .HasName("ID");

                    b.ToTable("MARKETPLACE");
                });
#pragma warning restore 612, 618
        }
    }
}
