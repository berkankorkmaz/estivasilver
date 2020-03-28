using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EstivaWeb.Models
{
    public class EstivaContext : DbContext
    {
        public virtual DbSet<Urun> Uruns { get; set; }
        public virtual DbSet<Kategori> Kategoris { get; set; }

        public virtual DbSet<Kullanici> Kullanicis { get; set; }

        public virtual DbSet<Contact> Contacts { get; set; }
    }
}