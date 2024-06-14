using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MihrapPlak.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MihrapPlak.DAL.Configurations
{
    public class User_CFG : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.KullaniciId);

            builder.Property(u => u.KullaniciAdi)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(25);

            builder.Property(u => u.KullaniciSoyAdi)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(30);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(60);

            builder.Property(u => u.Sifre)
                .IsRequired()
                .HasColumnType("nvarchar(200)");
        }
    }
}
