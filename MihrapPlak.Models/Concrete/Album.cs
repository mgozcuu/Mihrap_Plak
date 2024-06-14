using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MihrapPlak.Models.Concrete
{
    public class Album 
    {
        public int AlbumId { get; set; }

        public string AlbumAdi { get; set; }

        public string AlbumSanatcisi_Grubu { get; set; }

        public DateTime AlbumCikisTarihi { get; set; }

        public decimal AlbumFiyati { get; set; }

        public double IndirimOrani { get; set; }

        public bool Satistami { get; set; }

        

        public ICollection<AlbumUser> Albumler { get; set; }
    }
}
