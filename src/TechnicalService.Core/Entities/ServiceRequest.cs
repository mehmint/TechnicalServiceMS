using System;

namespace TechnicalService.Core.Entities
{
    public class ServiceRequest
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int TechnicianId { get; set; }
        public string IssueDescription { get; set; }
        public string IssueCode { get; set; }
        public string Barcode { get; set; }
        public bool HasDamageOnArrival { get; set; }
        public string DamageDescription { get; set; }
        public byte[] DamageImages { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime? SentDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string Status { get; set; } // Pending, InProgress, Completed, Cancelled
        public string DepartmentId { get; set; }
        public decimal? ServiceFee { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
