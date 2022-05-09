﻿using Microsoft.EntityFrameworkCore;

namespace Fundraise.Core.Entities
{
    public class FundraiseContext : DbContext
    {
        public FundraiseContext(DbContextOptions<FundraiseContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Fundraiser> Fundraisers { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Donation> Donations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Campaign>()
                .Property<string>("ExtendedDataStr")
                .HasField("_extendedData");
        }
    }
}
