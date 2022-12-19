using Entities.Concrete;
using Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class KitapContext : IdentityDbContext<Kullanıcı,Role,string>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-CQ6T5PI;Database=DenemeProje;Trusted_Connection=true");
        }
        public DbSet<Kitap> Kitaps { get; set; }
        public DbSet<Yazar> Yazars { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Yorum> Yorums { get; set; }

    }
}
