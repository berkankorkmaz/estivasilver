using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EstivaWeb.Models
{
    public class Kategori
    {
        [Key]
        public int Id { get; set; }
        public string KategoriAdi { get; set; }

        public List<Urun> Urunler { get; set; }
    }
}