//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public System.Guid Id { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<decimal> Size { get; set; }
        public Nullable<decimal> Length { get; set; }
        public string PackingDetails { get; set; }
        public string Application { get; set; }
        public string MOQ { get; set; }
        public string DeliveryTime { get; set; }
        public string Advantages { get; set; }
        public Nullable<int> Stock { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public string CategoryId { get; set; }
        public string ProductGroupId { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string CreatedBy { get; set; }
    }
}