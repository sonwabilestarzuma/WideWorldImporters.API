using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WideWorldImporters.API.Models
{
    public class StockItemsConfiguration : IEntityTypeConfiguration<StockItem>
    {
        public void Configure(EntityTypeBuilder<StockItem> builder)
        {
            // Set configuration for entity
            builder.ToTable("StockItems", "Warehouse");

            // Set key for entity
            builder.HasKey(p => p.StockItemID);

            // Set configuration for columns

            builder.Property(p => p.StockItemName).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(p => p.SupplierID).HasColumnType("int").IsRequired();
            builder.Property(p => p.ColorID).HasColumnType("int");
            builder.Property(p => p.UnitPackageID).HasColumnType("int").IsRequired();
            builder.Property(p => p.OuterPackageID).HasColumnType("int").IsRequired();
            builder.Property(p => p.Brand).HasColumnType("nvarchar(100)");
            builder.Property(p => p.Size).HasColumnType("nvarchar(40)");
            builder.Property(p => p.LeadTimeDays).HasColumnType("int").IsRequired();
            builder.Property(p => p.QuantityPerOuter).HasColumnType("int").IsRequired();
            builder.Property(p => p.IsChillerStock).HasColumnType("bit").IsRequired();
            builder.Property(p => p.Barcode).HasColumnType("nvarchar(100)");
            builder.Property(p => p.TaxRate).HasColumnType("decimal(18, 3)").IsRequired();
            builder.Property(p => p.UnitPrice).HasColumnType("decimal(18, 2)").IsRequired();
            builder.Property(p => p.RecommendedRetailPrice).HasColumnType("decimal(18, 2)");
            builder.Property(p => p.TypicalWeightPerUnit).HasColumnType("decimal(18, 3)").IsRequired();
            builder.Property(p => p.MarketingComments).HasColumnType("nvarchar(max)");
            builder.Property(p => p.InternalComments).HasColumnType("nvarchar(max)");
            builder.Property(p => p.CustomFields).HasColumnType("nvarchar(max)");
            builder.Property(p => p.LastEditedBy).HasColumnType("int").IsRequired();

            // Columns with default value

             builder
                .Property(p => p.StockItemID)
                .HasColumnType("int")
                .IsRequired()
                .HasDefaultValueSql("NEXT VALUE FOR [Sequences].[StockItemID]");

            // Computed columns

            builder
                .Property(p => p.Tags)
                .HasColumnType("nvarchar(max)")
                .HasComputedColumnSql("json_query([CustomFields],N'$.Tags')");

            builder
                .Property(p => p.SearchDetails)
                .HasColumnType("nvarchar(max)")
                .IsRequired()
                .HasComputedColumnSql("concat([StockItemName],N' ',[MarketingComments])");

            // Columns with generated value on add or update

            builder
                .Property(p => p.ValidFrom)
                .HasColumnType("datetime2")
                .IsRequired()
                .ValueGeneratedOnAddOrUpdate();

            builder
                .Property(p => p.ValidTo)
                .HasColumnType("datetime2")
                .IsRequired()
                .ValueGeneratedOnAddOrUpdate();
        }
    }
}
