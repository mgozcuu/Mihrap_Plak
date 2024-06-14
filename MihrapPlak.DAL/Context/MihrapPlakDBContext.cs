using Microsoft.EntityFrameworkCore;
using MihrapPlak.DAL.Configurations;
using MihrapPlak.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MihrapPlak.DAL.Context
{
    public class MihrapPlakDBContext : DbContext
    {
        public DbSet<Album> Albumler { get; set; }

        public DbSet<User> Kullanicilar { get; set; }

        public DbSet<AlbumUser> AlbumKullanicilar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MIHRAP-PC\\SQLEXPRESS;Database=Mihrap_PLAK;Integrated security=true;TrustServerCertificate = true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new Album_CFG());
            modelBuilder.ApplyConfiguration(new AlbumUser_CFG());
            modelBuilder.ApplyConfiguration(new User_CFG());

            base.OnModelCreating(modelBuilder);
        }
    }
}

