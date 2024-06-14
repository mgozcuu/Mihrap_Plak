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
    public class AlbumUser_CFG : IEntityTypeConfiguration<AlbumUser>
    {
        public void Configure(EntityTypeBuilder<AlbumUser> builder)
        {
            builder.HasKey(x => new { x.AlbumId, x.KullaniciId });
        }
    }
}
