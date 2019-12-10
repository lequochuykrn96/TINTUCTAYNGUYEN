using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TINTUCTAYNGUYEN.Models
{
    public class LKgiaCF : DbContext
    {
        public LKgiaCF() : base("GIACAFE")
        { }
        public DbSet<Tinh> Tinhs { get; set; }
        public DbSet<KhuVuc> KhuVucs { get; set; }        //public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}