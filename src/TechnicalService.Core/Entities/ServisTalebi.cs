using System;

namespace TechnicalService.Core.Entities
{
    public class ServisTalebi
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public int TeknisyenId { get; set; }
        public string CihazModeli { get; set; }
        public string SeriNo { get; set; }
        public string Sorun { get; set; }
        public string Aciklama { get; set; }
        public DateTime TalepTarihi { get; set; }
        public DateTime? TamamlanmaTarihi { get; set; }
        public string Durum { get; set; } // Bekliyor, İşlemde, Tamamlandı, İptal
        public decimal? Ucret { get; set; }
    }
}
