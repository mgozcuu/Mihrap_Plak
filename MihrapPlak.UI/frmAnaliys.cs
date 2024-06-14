using Microsoft.EntityFrameworkCore;
using MihrapPlak.DAL.Context;
using MihrapPlak.Models.Concrete;
using MihrapPlak.UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MihrapPlak.UI
{
    public partial class frmAnaliys : Form
    {
        MihrapPlakDBContext _dbContext;

        public frmAnaliys()
        {
            InitializeComponent();

        }

        private void frmAnaliys_Load(object sender, EventArgs e)
        {
            _dbContext = new MihrapPlakDBContext();
            cmbBoxAra.SelectedIndex = 0;
            DataGridWiew();
            btnGüncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void DataGridWiew()
        {
            dgvButunAlbumler.DataSource = _dbContext.Albumler.ToList();
            dgvButunAlbumler.RowHeadersVisible = false;
            dgvButunAlbumler.Columns["AlbumId"].Visible = false;
            dgvButunAlbumler.Columns["Albumler"].Visible = false;
            dgvButunAlbumler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvButunAlbumler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Album album = new Album();

            if (Methods.BosAlanKontrolEt(grbAlbumEkle))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz");
            }
            else
            {
                album.AlbumSanatcisi_Grubu = txtSanatci.Text;
                album.AlbumAdi = txtAlbumAdi.Text;
                album.AlbumCikisTarihi = dtpCikisTarihi.Value.Date;
                album.AlbumFiyati = Convert.ToDecimal(txtFiyat.Text);


                if (Convert.ToInt32(txtIndirimOrani.Text) > 100 || Convert.ToInt32(txtIndirimOrani.Text) < 0)
                {
                    MessageBox.Show("İndirim oranı 0-100 arasında olmalıdır.");
                    return;
                }
                else
                {
                    album.IndirimOrani = Convert.ToDouble(txtIndirimOrani.Text) / 100;
                }

                if (rbtnSatista.Checked == true)
                {
                    album.Satistami = true;
                }
                else if (rbtnSatistaDegil.Checked == true)

                {
                    album.Satistami = false;
                }

                _dbContext.Albumler.Add(album);
                _dbContext.SaveChanges();
                MessageBox.Show("Album başarıyla eklendi");
                DataGridWiew();
                Methods.TumMetinKutulariniTemizle(grbAlbumEkle);

            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            // DataGridView denetimindeki seçili olan satırın verilerine erişmek için kullanılır.
            Album album = (Album)dgvButunAlbumler.CurrentRow.DataBoundItem;

            album.AlbumSanatcisi_Grubu = txtSanatci.Text;
            album.AlbumAdi = txtAlbumAdi.Text;
            album.AlbumCikisTarihi = dtpCikisTarihi.Value.Date;
            album.AlbumFiyati = Convert.ToDecimal(txtFiyat.Text);
            album.IndirimOrani = Convert.ToDouble(txtIndirimOrani.Text);

            if (rbtnSatista.Checked == true)
            {
                album.Satistami = true;
            }
            else if (rbtnSatistaDegil.Checked == true)

            {
                album.Satistami = false;
            }

            _dbContext.SaveChanges();
            MessageBox.Show("Albüm başaraıyla güncellendi.");
            DataGridWiew();
            Methods.TumMetinKutulariniTemizle(grbAlbumEkle);
            btnGüncelle.Enabled = false;
            btnEkle.Enabled = true;
            btnSil.Enabled = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Album album = (Album)dgvButunAlbumler.CurrentRow.DataBoundItem;
            _dbContext.Albumler.Remove(album);
            _dbContext.SaveChanges();
            MessageBox.Show("Albüm başarıyla silindi.");
            DataGridWiew();
            Methods.TumMetinKutulariniTemizle(grbAlbumEkle);
            btnGüncelle.Enabled = false;
            btnEkle.Enabled = true;
            btnSil.Enabled = false;
        }

        private void dgvButunAlbumler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Kullanıcı bir hücrenin içeriğine doğrudan tıkladığında tetiklenir.Hücre dışında çalışmaz .
        }


        // Kullanıcı hücrenin herhangi bir yerine tıkladığında tetiklenir.
        private void dgvButunAlbumler_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            btnGüncelle.Enabled = true;
            btnEkle.Enabled = false;
            btnSil.Enabled = true;
            txtAlbumAdi.Text = dgvButunAlbumler.CurrentRow.Cells[1].Value.ToString();
            txtSanatci.Text = dgvButunAlbumler.CurrentRow.Cells[2].Value.ToString();
            dtpCikisTarihi.Value = Convert.ToDateTime(dgvButunAlbumler.CurrentRow.Cells[3].Value);
            txtFiyat.Text = dgvButunAlbumler.CurrentRow.Cells[4].Value.ToString();
            txtIndirimOrani.Text = dgvButunAlbumler.CurrentRow.Cells[5].Value.ToString();
            if (dgvButunAlbumler.CurrentRow.Cells[6].Value.ToString() == "True")
            {
                rbtnSatista.Checked = true;
            }
            else
            {
                rbtnSatistaDegil.Checked = true;
            }

        }

        private void frmAnaliys_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        // Sorgular
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (cmbBoxAra.SelectedIndex == 1)
            {
                dgvArananAlbum.DataSource = _dbContext.Albumler
                    .Where(x => x.Satistami == false)
                    .Select(a => new { a.AlbumAdi, a.AlbumSanatcisi_Grubu }).ToList();
            }
            else if (cmbBoxAra.SelectedIndex == 2)
            {
                dgvArananAlbum.DataSource = _dbContext.Albumler
                    .Where(x => x.Satistami == true)
                    .Select(a => new { a.AlbumAdi, a.AlbumSanatcisi_Grubu }).ToList();
            }
            else if (cmbBoxAra.SelectedIndex == 3)
            {
                dgvArananAlbum.DataSource = _dbContext.Albumler.OrderByDescending(x => x.AlbumCikisTarihi).Take(10).Select(a => new { a.AlbumAdi, a.AlbumSanatcisi_Grubu }).ToList();
            }
            else if (cmbBoxAra.SelectedIndex == 4)
            {
                dgvArananAlbum.DataSource = _dbContext.Albumler.Where(x => x.IndirimOrani > 0).Select(a => new { a.AlbumAdi, a.AlbumSanatcisi_Grubu }).ToList();
            }
        }
    }
}
