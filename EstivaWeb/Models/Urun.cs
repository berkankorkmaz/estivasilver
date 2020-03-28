using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EstivaWeb.Models
{
    public class Urun
    {
        [Key]
        public int Id { get; set; }
        public string Urunadi { get; set; }
        public string UrunKodu { get; set; }
        public string UrunBarkodu { get; set; }
        public decimal UrunFiyati { get; set; }
        public decimal UrunFiyati2 { get; set; }
        public string TrendLink { get; set; }
        public string N11Link { get; set; }
        public string HepsiLink { get; set; }
        public string GittiLink { get; set; }
        public bool IsUrunYeni { get; set; }
        public bool IsUrunIndirim { get; set; }
        public string UrunMarkasi { get; set; }
        public string UrunCinsi { get; set; }
        public string UrunGrami { get; set; }
        public string UrunOlcusu { get; set; }
        public string UrunDegeri { get; set; }
        public string UrunCarpani { get; set; }
        public DateTime UrunTarihi { get; set; }
        public string UrunResmi { get; set; }
        public string UrunBilgisiBir { get; set; } //cicek sepeti link
        public string UrunBilgisiIki { get; set; }
        public string UrunBilgisiUc { get; set; }
        public string UrunBilgisiDort { get; set; }
        public string UrunBilgisiBes { get; set; }
        public List<Kategori> Kategoriler { get; set; }


        public Urun()
        {
            UrunTarihi = DateTime.Today;
            Kategoriler = new List<Kategori>();
        }
    }
}