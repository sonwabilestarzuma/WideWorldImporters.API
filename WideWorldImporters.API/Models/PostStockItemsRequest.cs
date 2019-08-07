using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WideWorldImporters.API.Models
{
    public class PostStockItemsRequest
    {
        [Key]
         public int? StockItemID { get; set; }

        [Required]
        [StringLength(200)]
        public string StockItemName { get; set; }

        [Required]
        public int? SupplierID { get; set; }

        public int? ColorID { get; set; }

        [Required]
        public int? UnitPackageID { get; set; }

        [Required]
        public int? OuterPackageID { get; set; }

        [StringLength(100)]
        public string Brand { get; set; }

        [StringLength(40)]
        public string Size { get; set; }

        [Required]
        public int? LeadTimeDays { get; set; }

        [Required]
        public int? QuantityPerOuter { get; set; }

        [Required]
        public bool? IsChillerStock { get; set; }

        [StringLength(100)]
        public string Barcode { get; set; }

        [Required]
        public decimal? TaxRate { get; set; }

        [Required]
        public decimal? UnitPrice { get; set; }

        public decimal? RecommendedRetailPrice { get; set; }

        [Required]
        public decimal? TypicalWeightPerUnit { get; set; }

        public string MarketingComments { get; set; }

        public string InternalComments { get; set; }

        public string CustomFields { get; set; }

        public string Tags { get; set; }

        [Required]
        public string SearchDetails { get; set; }

        [Required]
        public int? LastEditedBy { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidTo { get; set; }
    }
}
