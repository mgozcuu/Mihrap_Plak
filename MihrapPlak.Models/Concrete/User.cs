using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MihrapPlak.Models.Concrete
{
    public class User 
    {
        public int KullaniciId { get; set; }

        public string KullaniciAdi { get; set; }

        public string KullaniciSoyAdi { get; set; }

        public string Email { get; set; }

        public string Sifre { get; set; }

       

        public ICollection<AlbumUser> Kullanicilar { get; set; }
    }
}
