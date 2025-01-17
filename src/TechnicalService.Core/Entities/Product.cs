using System;

namespace TechnicalService.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string UsedInDevice { get; set; }
        public int ProductYear { get; set; }
        public int Quantity { get; set; }
        public int CriticalQuantity { get; set; }
        public byte[] ProductImage { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
