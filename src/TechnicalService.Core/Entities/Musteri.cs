using System;

namespace TechnicalService.Core.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string IdCardNumber { get; set; }
        public string CreditCardInfo { get; set; } // Encrypted
        public byte[] CustomerImage { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
