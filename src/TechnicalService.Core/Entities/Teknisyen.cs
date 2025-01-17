using System;

namespace TechnicalService.Core.Entities
{
    public class Teknisyen
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Uzmanlik { get; set; }
        public bool AktifMi { get; set; }
        public DateTime IseBaslamaTarihi { get; set; }
    }
}
