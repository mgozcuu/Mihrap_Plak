namespace MihrapPlak.UI
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            grpLogin = new GroupBox();
            pcbGoster = new PictureBox();
            pcbSifre = new PictureBox();
            lklbl_HesapOlustur = new LinkLabel();
            btnGirisYap = new Button();
            chkSifreGoster = new CheckBox();
            txtSifre = new TextBox();
            lblSifre = new Label();
            txtKullaniciAdi = new TextBox();
            lblKullaniciAdi = new Label();
            grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbGoster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbSifre).BeginInit();
            SuspendLayout();
            // 
            // grpLogin
            // 
            grpLogin.BackColor = SystemColors.ActiveCaption;
            grpLogin.Controls.Add(pcbGoster);
            grpLogin.Controls.Add(pcbSifre);
            grpLogin.Controls.Add(lklbl_HesapOlustur);
            grpLogin.Controls.Add(btnGirisYap);
            grpLogin.Controls.Add(chkSifreGoster);
            grpLogin.Controls.Add(txtSifre);
            grpLogin.Controls.Add(lblSifre);
            grpLogin.Controls.Add(txtKullaniciAdi);
            grpLogin.Controls.Add(lblKullaniciAdi);
            grpLogin.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            grpLogin.Location = new Point(124, 51);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(522, 326);
            grpLogin.TabIndex = 2;
            grpLogin.TabStop = false;
            grpLogin.Text = "Giriş Ekranı";
            // 
            // pcbGoster
            // 
            pcbGoster.Image = (Image)resources.GetObject("pcbGoster.Image");
            pcbGoster.Location = new Point(125, 155);
            pcbGoster.Margin = new Padding(3, 4, 3, 4);
            pcbGoster.Name = "pcbGoster";
            pcbGoster.Size = new Size(37, 47);
            pcbGoster.SizeMode = PictureBoxSizeMode.Zoom;
            pcbGoster.TabIndex = 45;
            pcbGoster.TabStop = false;
            // 
            // pcbSifre
            // 
            pcbSifre.Image = (Image)resources.GetObject("pcbSifre.Image");
            pcbSifre.Location = new Point(24, 100);
            pcbSifre.Margin = new Padding(3, 4, 3, 4);
            pcbSifre.Name = "pcbSifre";
            pcbSifre.Size = new Size(37, 47);
            pcbSifre.SizeMode = PictureBoxSizeMode.Zoom;
            pcbSifre.TabIndex = 44;
            pcbSifre.TabStop = false;
            // 
            // lklbl_HesapOlustur
            // 
            lklbl_HesapOlustur.AutoSize = true;
            lklbl_HesapOlustur.Location = new Point(174, 264);
            lklbl_HesapOlustur.Name = "lklbl_HesapOlustur";
            lklbl_HesapOlustur.Size = new Size(193, 23);
            lklbl_HesapOlustur.TabIndex = 43;
            lklbl_HesapOlustur.TabStop = true;
            lklbl_HesapOlustur.Text = "Yeni Hesap Oluştur";
            lklbl_HesapOlustur.LinkClicked += lklbl_HesapOlustur_LinkClicked;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(168, 214);
            btnGirisYap.Margin = new Padding(3, 4, 3, 4);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(199, 31);
            btnGirisYap.TabIndex = 9;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // chkSifreGoster
            // 
            chkSifreGoster.AutoSize = true;
            chkSifreGoster.BackgroundImageLayout = ImageLayout.Stretch;
            chkSifreGoster.Location = new Point(194, 166);
            chkSifreGoster.Margin = new Padding(3, 4, 3, 4);
            chkSifreGoster.Name = "chkSifreGoster";
            chkSifreGoster.Size = new Size(159, 27);
            chkSifreGoster.TabIndex = 8;
            chkSifreGoster.Text = "Şifreyi Göster";
            chkSifreGoster.UseVisualStyleBackColor = true;
            chkSifreGoster.CheckedChanged += chkSifreGoster_CheckedChanged;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(168, 115);
            txtSifre.Margin = new Padding(3, 4, 3, 4);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(199, 32);
            txtSifre.TabIndex = 5;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(91, 115);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(62, 23);
            lblSifre.TabIndex = 4;
            lblSifre.Text = "Şifre :";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(168, 56);
            txtKullaniciAdi.Margin = new Padding(3, 4, 3, 4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(199, 32);
            txtKullaniciAdi.TabIndex = 3;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(13, 59);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(149, 23);
            lblKullaniciAdi.TabIndex = 0;
            lblKullaniciAdi.Text = "Kullanıcı Adı : ";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(grpLogin);
            Name = "frmLogin";
            Text = "Giriş Ekranı";
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbGoster).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbSifre).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpLogin;
        private PictureBox pcbGoster;
        private PictureBox pcbSifre;
        private LinkLabel lklbl_HesapOlustur;
        private Button btnGirisYap;
        private CheckBox chkSifreGoster;
        private TextBox txtSifre;
        private Label lblSifre;
        private TextBox txtKullaniciAdi;
        private Label lblKullaniciAdi;
    }
}
