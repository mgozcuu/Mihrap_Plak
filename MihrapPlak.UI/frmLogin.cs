using Microsoft.EntityFrameworkCore;
using MihrapPlak.DAL.Context;
using MihrapPlak.Models.Concrete;
using MihrapPlak.UI.Properties;
using System.Security.Cryptography;
using System.Text;

namespace MihrapPlak.UI
{
    public partial class frmLogin : Form
    {
        MihrapPlakDBContext _dbContext;

        User _user;

        frmAnaliys _frmAnaliys;

        frmRegistorScreen _frmRegistorScreen;
      

        public frmLogin()
        {
            InitializeComponent();

           _dbContext = new MihrapPlakDBContext();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = Methods.Sha256_hash(txtSifre.Text);

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanýcý adý veya parola boþ býrakýlamaz", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            _user = _dbContext.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == kullaniciAdi && x.Sifre == sifre);
            if (_user == null)
            {
                MessageBox.Show("Kullanýcý adý veya parola hatalý", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Giriþ Baþarýlý");
                _frmAnaliys = new frmAnaliys();
                _frmAnaliys.ShowDialog();
                this.Hide();
            }
        }


        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSifreGoster.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }

        }

        private void lklbl_HesapOlustur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistorScreen registerScreen = new frmRegistorScreen();
            registerScreen.ShowDialog();
        }
    }
}
