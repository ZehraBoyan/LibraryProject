using BusinessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class LibraryDbContext:DbContext
    {
        public DbSet<Kitap> Kitaplar { get; set; } // Kitaplar tablosu
        public DbSet<Uye> Uyeler { get; set; } // Üyeler tablosu

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\MSSQLSERVER01;Database=master;Integrated Security=True");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kitap>().HasKey(k => k.Id);
            modelBuilder.Entity<Uye>().HasKey(k => k.Id);
        }

    }
}
