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
    
    public partial class Invoice_Info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice_Info()
        {
            this.ProductSolds = new HashSet<ProductSold>();
        }
    
        public string InvoiceNo { get; set; }
        public string InvoiceDate { get; set; }
        public string CustomerID { get; set; }
        public double SubTotal { get; set; }
        public double VATPer { get; set; }
        public double VATAmount { get; set; }
        public double DiscountPer { get; set; }
        public double DiscountAmount { get; set; }
        public double GrandTotal { get; set; }
        public double TotalPayment { get; set; }
        public double PaymentDue { get; set; }
        public string PaymentType { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSold> ProductSolds { get; set; }
    }
}
