//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductSold
    {
        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }
    
        public virtual Invoice_Info Invoice_Info { get; set; }
        public virtual Product Product { get; set; }
    }
}
