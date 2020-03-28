using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstivaWeb.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public DateTime Tarih { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }

        public Contact()
        {
            Tarih = DateTime.Now;
        }
    }
}