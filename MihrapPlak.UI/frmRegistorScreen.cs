using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using MihrapPlak.Models.Concrete;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = MihrapPlak.Models.Concrete.User;
using System.Reflection;
using MihrapPlak.UI.Properties;
using MihrapPlak.DAL.Context;

namespace MihrapPlak.UI
{
    public partial class frmRegistorScreen : Form
    {

        User _user;

        MihrapPlakDBContext _dbContext;

        public frmRegistorScreen()
        {
            InitializeComponent();
        }

        private void frmRegistorScreen_Load(object sender, EventArgs e)
        {
            _user = new User();

            _dbContext = new MihrapPlakDBContext();

        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            #region Kullanici Adi

            if (string.IsNullOrEmpty(txtAd.Text))
            {
                MessageBox.Show("İsim Alanı Boş Geçilemez");
                return;
            }
            else
            {
                char[] letters = { 'ç', 'ğ', 'ı', 'ö', 'ş', 'ü', 'İ', 'Ç', 'Ğ', 'Ö', 'Ş', 'Ü' };
                char[] replace = { 'c', 'g', 'i', 'o', 's', 'u', 'i', 'c', 'g', 'o', 's', 'u' };

                for (int i = 0; i < txtAd.Text.Length; i++)
                {
                    for (int j = 0; j < letters.Length; j++)
                    {
                        if (txtAd.Text[i] == letters[j])
                        {
                            txtAd.Text = txtAd.Text.Replace(txtAd.Text[i], replace[j]);
                        }
                    }
                }
                _user.KullaniciAdi = txtAd.Text;
            }

            #endregion

            #region Kullanici Soyadi

            if (string.IsNullOrEmpty(txtSoyad.Text))
            {
                MessageBox.Show("Soyadı alanı boş geçilemez");
                return;
            }
            else
            {
                char[] letters = { 'ç', 'ğ', 'ı', 'ö', 'ş', 'ü', 'İ', 'Ç', 'Ğ', 'Ö', 'Ş', 'Ü' };
                char[] replace = { 'c', 'g', 'i', 'o', 's', 'u', 'i', 'c', 'g', 'o', 's', 'u' };

                for (int i = 0; i < txtSoyad.Text.Length; i++)
                {
                    for (int j = 0; j < letters.Length; j++)
                    {
                        if (txtSoyad.Text[i] == letters[j])
                        {
                            txtSoyad.Text = txtSoyad.Text.Replace(txtSoyad.Text[i], replace[j]);
                        }
                    }
                }
                _user.KullaniciSoyAdi = txtSoyad.Text;
            }

            #endregion

            #region Mail

            if (string.IsNullOrEmpty(txtEMail.Text))
            {
                MessageBox.Show("Mail alanı boş geçilemez");
                return;
            }
            else if (Methods.GecerliEposta(txtEMail.Text))
            {
                _user.Email = txtEMail.Text.Trim();
            }
            else
            {
                MessageBox.Show("Lütfen mailiniz kontrol ediniz");
                return;
            }

            #endregion

            #region Sifre

            if (txtSifre.Text == txtTekrarSifre.Text)
            {
                if (Methods.BuyukHarfKontrolEt(txtSifre.Text) && Methods.KucukHarfKontrolEt(txtSifre.Text) && Methods.OzelKarakterKontrolEt(txtSifre.Text))
                {
                    _user.Sifre = Methods.Sha256_hash(txtSifre.Text);
                }
                else
                {
                    MessageBox.Show("Parola en az 2 büyük harf, 3 küçük harf ve 2 özel karakter içermelidir ");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Girilen şifrelere uyumlu değil.");
                return;
            }

            #endregion

            #region Email Check

            foreach (var email in _dbContext.Kullanicilar)
            {
                if (email.Email == _user.Email)
                {
                    MessageBox.Show("Mail Adresi Kullanılıoyor..");
                    return;
                }
            }


            #endregion

            _dbContext.Kullanicilar.Add(_user);
            _dbContext.SaveChanges();
            MessageBox.Show("Kullanıcı başarılı ile kaydedil");
            this.Close();

        }

        private void chbSifreGöster_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSifreGöster.Checked)
            {
                txtSifre.PasswordChar = '\0';
                txtTekrarSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
                txtTekrarSifre.PasswordChar = '*';
            }
        }

    }
}
