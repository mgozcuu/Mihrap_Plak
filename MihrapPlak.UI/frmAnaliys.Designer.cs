namespace MihrapPlak.UI
{
    partial class frmAnaliys
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbAlbumEkle = new GroupBox();
            txtIndirimOrani = new TextBox();
            rbtnSatistaDegil = new RadioButton();
            btnSil = new Button();
            rbtnSatista = new RadioButton();
            btnGüncelle = new Button();
            txtFiyat = new TextBox();
            dtpCikisTarihi = new DateTimePicker();
            txtAlbumAdi = new TextBox();
            txtSanatci = new TextBox();
            btnEkle = new Button();
            lblSatis = new Label();
            lblİdirimOranı = new Label();
            lblFiyat = new Label();
            lblCikisTarihi = new Label();
            lblAlbumAdi = new Label();
            lblSanatci = new Label();
            dgvButunAlbumler = new DataGridView();
            grbAlbumAra = new GroupBox();
            dgvArananAlbum = new DataGridView();
            btnAra = new Button();
            cmbBoxAra = new ComboBox();
            lblAramaKriteri = new Label();
            grbAlbumEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvButunAlbumler).BeginInit();
            grbAlbumAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArananAlbum).BeginInit();
            SuspendLayout();
            // 
            // grbAlbumEkle
            // 
            grbAlbumEkle.Controls.Add(txtIndirimOrani);
            grbAlbumEkle.Controls.Add(rbtnSatistaDegil);
            grbAlbumEkle.Controls.Add(btnSil);
            grbAlbumEkle.Controls.Add(rbtnSatista);
            grbAlbumEkle.Controls.Add(btnGüncelle);
            grbAlbumEkle.Controls.Add(txtFiyat);
            grbAlbumEkle.Controls.Add(dtpCikisTarihi);
            grbAlbumEkle.Controls.Add(txtAlbumAdi);
            grbAlbumEkle.Controls.Add(txtSanatci);
            grbAlbumEkle.Controls.Add(btnEkle);
            grbAlbumEkle.Controls.Add(lblSatis);
            grbAlbumEkle.Controls.Add(lblİdirimOranı);
            grbAlbumEkle.Controls.Add(lblFiyat);
            grbAlbumEkle.Controls.Add(lblCikisTarihi);
            grbAlbumEkle.Controls.Add(lblAlbumAdi);
            grbAlbumEkle.Controls.Add(lblSanatci);
            grbAlbumEkle.Controls.Add(dgvButunAlbumler);
            grbAlbumEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grbAlbumEkle.Location = new Point(11, 12);
            grbAlbumEkle.Margin = new Padding(2, 3, 2, 3);
            grbAlbumEkle.Name = "grbAlbumEkle";
            grbAlbumEkle.Padding = new Padding(2, 3, 2, 3);
            grbAlbumEkle.Size = new Size(1386, 332);
            grbAlbumEkle.TabIndex = 3;
            grbAlbumEkle.TabStop = false;
            grbAlbumEkle.Text = "Albüm Ekle";
            // 
            // txtIndirimOrani
            // 
            txtIndirimOrani.BackColor = SystemColors.InactiveCaption;
            txtIndirimOrani.Location = new Point(1016, 157);
            txtIndirimOrani.Margin = new Padding(2, 3, 2, 3);
            txtIndirimOrani.Name = "txtIndirimOrani";
            txtIndirimOrani.Size = new Size(241, 27);
            txtIndirimOrani.TabIndex = 14;
            // 
            // rbtnSatistaDegil
            // 
            rbtnSatistaDegil.AutoSize = true;
            rbtnSatistaDegil.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rbtnSatistaDegil.Location = new Point(1133, 190);
            rbtnSatistaDegil.Margin = new Padding(2, 3, 2, 3);
            rbtnSatistaDegil.Name = "rbtnSatistaDegil";
            rbtnSatistaDegil.Size = new Size(147, 27);
            rbtnSatistaDegil.TabIndex = 13;
            rbtnSatistaDegil.TabStop = true;
            rbtnSatistaDegil.Text = "Satıştan Kalktı";
            rbtnSatistaDegil.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.GradientInactiveCaption;
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(1202, 223);
            btnSil.Margin = new Padding(2, 3, 2, 3);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(180, 60);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // rbtnSatista
            // 
            rbtnSatista.AutoSize = true;
            rbtnSatista.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rbtnSatista.Location = new Point(1016, 186);
            rbtnSatista.Margin = new Padding(2, 3, 2, 3);
            rbtnSatista.Name = "rbtnSatista";
            rbtnSatista.Size = new Size(85, 27);
            rbtnSatista.TabIndex = 12;
            rbtnSatista.TabStop = true;
            rbtnSatista.Text = "Satışta";
            rbtnSatista.UseVisualStyleBackColor = true;
            // 
            // btnGüncelle
            // 
            btnGüncelle.BackColor = SystemColors.GradientInactiveCaption;
            btnGüncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGüncelle.Location = new Point(1018, 224);
            btnGüncelle.Margin = new Padding(2, 3, 2, 3);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(167, 59);
            btnGüncelle.TabIndex = 2;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = false;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // txtFiyat
            // 
            txtFiyat.BackColor = SystemColors.InactiveCaption;
            txtFiyat.Location = new Point(1016, 124);
            txtFiyat.Margin = new Padding(2, 3, 2, 3);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(241, 27);
            txtFiyat.TabIndex = 11;
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(1016, 91);
            dtpCikisTarihi.Margin = new Padding(2, 3, 2, 3);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(241, 27);
            dtpCikisTarihi.TabIndex = 10;
            // 
            // txtAlbumAdi
            // 
            txtAlbumAdi.BackColor = SystemColors.InactiveCaption;
            txtAlbumAdi.Location = new Point(1016, 58);
            txtAlbumAdi.Margin = new Padding(2, 3, 2, 3);
            txtAlbumAdi.Name = "txtAlbumAdi";
            txtAlbumAdi.Size = new Size(241, 27);
            txtAlbumAdi.TabIndex = 9;
            // 
            // txtSanatci
            // 
            txtSanatci.BackColor = SystemColors.InactiveCaption;
            txtSanatci.Location = new Point(1016, 24);
            txtSanatci.Margin = new Padding(2, 3, 2, 3);
            txtSanatci.Name = "txtSanatci";
            txtSanatci.Size = new Size(241, 27);
            txtSanatci.TabIndex = 8;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.GradientInactiveCaption;
            btnEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle.Location = new Point(834, 223);
            btnEkle.Margin = new Padding(2, 3, 2, 3);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(180, 60);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // lblSatis
            // 
            lblSatis.AutoSize = true;
            lblSatis.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSatis.Location = new Point(831, 192);
            lblSatis.Margin = new Padding(2, 0, 2, 0);
            lblSatis.Name = "lblSatis";
            lblSatis.Size = new Size(140, 23);
            lblSatis.TabIndex = 6;
            lblSatis.Text = "Satış Durumu:";
            // 
            // lblİdirimOranı
            // 
            lblİdirimOranı.AutoSize = true;
            lblİdirimOranı.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblİdirimOranı.Location = new Point(831, 159);
            lblİdirimOranı.Margin = new Padding(2, 0, 2, 0);
            lblİdirimOranı.Name = "lblİdirimOranı";
            lblİdirimOranı.Size = new Size(141, 23);
            lblİdirimOranı.TabIndex = 5;
            lblİdirimOranı.Text = "İndirim Oranı:";
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFiyat.Location = new Point(831, 127);
            lblFiyat.Margin = new Padding(2, 0, 2, 0);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(67, 23);
            lblFiyat.TabIndex = 4;
            lblFiyat.Text = "Fiyatı:";
            // 
            // lblCikisTarihi
            // 
            lblCikisTarihi.AutoSize = true;
            lblCikisTarihi.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCikisTarihi.Location = new Point(831, 89);
            lblCikisTarihi.Margin = new Padding(2, 0, 2, 0);
            lblCikisTarihi.Name = "lblCikisTarihi";
            lblCikisTarihi.Size = new Size(124, 23);
            lblCikisTarihi.TabIndex = 3;
            lblCikisTarihi.Text = "Çıkış Tarihi: ";
            // 
            // lblAlbumAdi
            // 
            lblAlbumAdi.AutoSize = true;
            lblAlbumAdi.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAlbumAdi.Location = new Point(831, 57);
            lblAlbumAdi.Margin = new Padding(2, 0, 2, 0);
            lblAlbumAdi.Name = "lblAlbumAdi";
            lblAlbumAdi.Size = new Size(125, 23);
            lblAlbumAdi.TabIndex = 2;
            lblAlbumAdi.Text = "Albüm Adı: ";
            // 
            // lblSanatci
            // 
            lblSanatci.AutoSize = true;
            lblSanatci.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSanatci.Location = new Point(831, 28);
            lblSanatci.Margin = new Padding(2, 0, 2, 0);
            lblSanatci.Name = "lblSanatci";
            lblSanatci.Size = new Size(151, 23);
            lblSanatci.TabIndex = 1;
            lblSanatci.Text = "Sanaçtı/Grup :";
            // 
            // dgvButunAlbumler
            // 
            dgvButunAlbumler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvButunAlbumler.BackgroundColor = SystemColors.ActiveCaption;
            dgvButunAlbumler.ColumnHeadersHeight = 29;
            dgvButunAlbumler.GridColor = SystemColors.ScrollBar;
            dgvButunAlbumler.Location = new Point(28, 26);
            dgvButunAlbumler.Margin = new Padding(2, 3, 2, 3);
            dgvButunAlbumler.Name = "dgvButunAlbumler";
            dgvButunAlbumler.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvButunAlbumler.RowTemplate.Height = 33;
            dgvButunAlbumler.Size = new Size(790, 290);
            dgvButunAlbumler.TabIndex = 0;
            dgvButunAlbumler.CellClick += dgvButunAlbumler_CellClick;
            dgvButunAlbumler.CellContentClick += dgvButunAlbumler_CellContentClick;
            // 
            // grbAlbumAra
            // 
            grbAlbumAra.Controls.Add(dgvArananAlbum);
            grbAlbumAra.Controls.Add(btnAra);
            grbAlbumAra.Controls.Add(cmbBoxAra);
            grbAlbumAra.Controls.Add(lblAramaKriteri);
            grbAlbumAra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grbAlbumAra.Location = new Point(15, 375);
            grbAlbumAra.Margin = new Padding(2, 3, 2, 3);
            grbAlbumAra.Name = "grbAlbumAra";
            grbAlbumAra.Padding = new Padding(2, 3, 2, 3);
            grbAlbumAra.Size = new Size(1217, 258);
            grbAlbumAra.TabIndex = 4;
            grbAlbumAra.TabStop = false;
            grbAlbumAra.Text = "Albüm Ara";
            // 
            // dgvArananAlbum
            // 
            dgvArananAlbum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArananAlbum.BackgroundColor = SystemColors.ActiveCaption;
            dgvArananAlbum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArananAlbum.Location = new Point(24, 39);
            dgvArananAlbum.Margin = new Padding(3, 4, 3, 4);
            dgvArananAlbum.Name = "dgvArananAlbum";
            dgvArananAlbum.RowHeadersWidth = 51;
            dgvArananAlbum.RowTemplate.Height = 25;
            dgvArananAlbum.Size = new Size(490, 200);
            dgvArananAlbum.TabIndex = 5;
            // 
            // btnAra
            // 
            btnAra.BackColor = SystemColors.GradientInactiveCaption;
            btnAra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAra.Location = new Point(656, 123);
            btnAra.Margin = new Padding(2, 3, 2, 3);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(238, 50);
            btnAra.TabIndex = 4;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // cmbBoxAra
            // 
            cmbBoxAra.BackColor = SystemColors.InactiveCaption;
            cmbBoxAra.FormattingEnabled = true;
            cmbBoxAra.Items.AddRange(new object[] { "Lütfen Bir Arama Kriteri Seçiniz!", "Satışı durmuş albümler", "Satışı devam eden albümler", "Son eklenen 10 albüm", "İndirimdeki albümler" });
            cmbBoxAra.Location = new Point(656, 71);
            cmbBoxAra.Margin = new Padding(2, 3, 2, 3);
            cmbBoxAra.Name = "cmbBoxAra";
            cmbBoxAra.Size = new Size(238, 28);
            cmbBoxAra.TabIndex = 1;
            // 
            // lblAramaKriteri
            // 
            lblAramaKriteri.AutoSize = true;
            lblAramaKriteri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAramaKriteri.Location = new Point(710, 39);
            lblAramaKriteri.Margin = new Padding(2, 0, 2, 0);
            lblAramaKriteri.Name = "lblAramaKriteri";
            lblAramaKriteri.Size = new Size(104, 20);
            lblAramaKriteri.TabIndex = 0;
            lblAramaKriteri.Text = "Arama Kriteri";
            // 
            // frmAnaliys
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1583, 645);
            Controls.Add(grbAlbumAra);
            Controls.Add(grbAlbumEkle);
            Name = "frmAnaliys";
            Text = "frmAnaliys";
            FormClosing += frmAnaliys_FormClosing;
            Load += frmAnaliys_Load;
            grbAlbumEkle.ResumeLayout(false);
            grbAlbumEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvButunAlbumler).EndInit();
            grbAlbumAra.ResumeLayout(false);
            grbAlbumAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArananAlbum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbAlbumEkle;
        private TextBox txtIndirimOrani;
        private RadioButton rbtnSatistaDegil;
        private Button btnSil;
        private RadioButton rbtnSatista;
        private Button btnGüncelle;
        private TextBox txtFiyat;
        private DateTimePicker dtpCikisTarihi;
        private TextBox txtAlbumAdi;
        private TextBox txtSanatci;
        private Button btnEkle;
        private Label lblSatis;
        private Label lblİdirimOranı;
        private Label lblFiyat;
        private Label lblCikisTarihi;
        private Label lblAlbumAdi;
        private Label lblSanatci;
        private DataGridView dgvButunAlbumler;
        private GroupBox grbAlbumAra;
        private DataGridView dgvArananAlbum;
        private Button btnAra;
        private ComboBox cmbBoxAra;
        private Label lblAramaKriteri;
    }
}