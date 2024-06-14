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
    public class Album_CFG : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(a => a.AlbumId);

            builder.Property(a => a.AlbumAdi)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(40);
            builder.Property(a => a.AlbumSanatcisi_Grubu)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(40);
            builder.Property(a => a.AlbumCikisTarihi)
                .IsRequired()
                .HasColumnType("datetime2");
            builder.Property(a => a.AlbumFiyati)
                .IsRequired()
                .HasColumnType("money");

            builder.Property(a => a.IndirimOrani)
                .HasColumnType("decimal (5,2)");
            builder.Property(a => a.Satistami)
                .IsRequired();
        }
    }
}
