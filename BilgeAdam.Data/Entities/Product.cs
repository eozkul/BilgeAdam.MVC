﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.Data.Entities
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? CategoryID { get; set; }
        public int? SupplierID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        [ForeignKey(nameof(CategoryID))]
        public Category Category { get; set; }

        [ForeignKey(nameof(SupplierID))]
        public Supplier Supplier { get; set; }
    }
}
