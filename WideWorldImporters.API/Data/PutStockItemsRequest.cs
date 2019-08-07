using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WideWorldImporters.API.Data
{
    public class PutStockItemsRequest
    {
        [Required]
        [StringLength(200)]
        public string StockItemName { get; set; }

        [Required]
        public int? SupplierID { get; set; }

        public int? ColorID { get; set; }

        [Required]
        public decimal? UnitPrice { get; set; }
    }
}
