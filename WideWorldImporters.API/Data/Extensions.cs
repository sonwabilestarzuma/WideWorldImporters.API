using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WideWorldImporters.API.Models;

namespace WideWorldImporters.API.Data
{
    public static class Extensions
    {
        public static StockItem ToEntity(this PostStockItemsRequest request)
            => new StockItem
            {
                StockItemID = request.StockItemID,
                StockItemName = request.StockItemName,
                SupplierID = request.SupplierID,
                ColorID = request.ColorID,
                UnitPackageID = request.UnitPackageID,
                OuterPackageID = request.OuterPackageID,
                Brand = request.Brand,
                Size = request.Size,
                LeadTimeDays = request.LeadTimeDays,
                QuantityPerOuter = request.QuantityPerOuter,
                IsChillerStock = request.IsChillerStock,
                Barcode = request.Barcode,
                TaxRate = request.TaxRate,
                UnitPrice = request.UnitPrice,
                RecommendedRetailPrice = request.RecommendedRetailPrice,
                TypicalWeightPerUnit = request.TypicalWeightPerUnit,
                MarketingComments = request.MarketingComments,
                InternalComments = request.InternalComments,
                CustomFields = request.CustomFields,
                Tags = request.Tags,
                SearchDetails = request.SearchDetails,
                LastEditedBy = request.LastEditedBy,
                ValidFrom = request.ValidFrom,
                ValidTo = request.ValidTo
            };
    }
#pragma warning restore CS1591
}

