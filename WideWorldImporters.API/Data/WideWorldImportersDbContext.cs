using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WideWorldImporters.API.Models;

namespace WideWorldImporters.API.Data
{
    public class WideWorldImportersDbContext : DbContext
    {
        public WideWorldImportersDbContext(DbContextOptions<WideWorldImportersDbContext> options)
      : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply configurations for entity

            modelBuilder
                .ApplyConfiguration(new StockItemsConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<StockItem> StockItems { get; set; }
    }
#pragma warning restore CS1591
}

