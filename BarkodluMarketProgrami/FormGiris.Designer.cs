namespace BarkodluMarketProgrami
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnYedekYükle = new System.Windows.Forms.Button();
            this.btnKullaniciAyarlari = new System.Windows.Forms.Button();
            this.btnKullaniciDegistir = new System.Windows.Forms.Button();
            this.btnYedekleme = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnUrunGiris = new System.Windows.Forms.Button();
            this.btnStokTakibi = new System.Windows.Forms.Button();
            this.btnGenelRapor = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnVeresiyeIslemleri = new System.Windows.Forms.Button();
            this.btnFiyatGuncelle = new System.Windows.Forms.Button();
            this.lblKasiyer = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnCikis, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnYedekYükle, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnKullaniciAyarlari, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnKullaniciDegistir, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnYedekleme, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAyarlar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnUrunGiris, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnStokTakibi, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGenelRapor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSatis, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnVeresiyeIslemleri, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFiyatGuncelle, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(830, 554);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCikis.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Image = global::BarkodluMarketProgrami.Properties.Resources.logout;
            this.btnCikis.Location = new System.Drawing.Point(553, 415);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(1);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(276, 138);
            this.btnCikis.TabIndex = 11;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnYedekYükle
            // 
            this.btnYedekYükle.BackColor = System.Drawing.Color.DarkGreen;
            this.btnYedekYükle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnYedekYükle.Enabled = false;
            this.btnYedekYükle.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnYedekYükle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYedekYükle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYedekYükle.ForeColor = System.Drawing.Color.White;
            this.btnYedekYükle.Image = global::BarkodluMarketProgrami.Properties.Resources.database;
            this.btnYedekYükle.Location = new System.Drawing.Point(277, 415);
            this.btnYedekYükle.Margin = new System.Windows.Forms.Padding(1);
            this.btnYedekYükle.Name = "btnYedekYükle";
            this.btnYedekYükle.Size = new System.Drawing.Size(274, 138);
            this.btnYedekYükle.TabIndex = 10;
            this.btnYedekYükle.Text = "Yedek Yükle";
            this.btnYedekYükle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYedekYükle.UseVisualStyleBackColor = false;
            this.btnYedekYükle.Click += new System.EventHandler(this.btnYedekYükle_Click);
            // 
            // btnKullaniciAyarlari
            // 
            this.btnKullaniciAyarlari.BackColor = System.Drawing.Color.DarkGreen;
            this.btnKullaniciAyarlari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKullaniciAyarlari.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnKullaniciAyarlari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciAyarlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciAyarlari.ForeColor = System.Drawing.Color.White;
            this.btnKullaniciAyarlari.Image = global::BarkodluMarketProgrami.Properties.Resources.clerk;
            this.btnKullaniciAyarlari.Location = new System.Drawing.Point(1, 415);
            this.btnKullaniciAyarlari.Margin = new System.Windows.Forms.Padding(1);
            this.btnKullaniciAyarlari.Name = "btnKullaniciAyarlari";
            this.btnKullaniciAyarlari.Size = new System.Drawing.Size(274, 138);
            this.btnKullaniciAyarlari.TabIndex = 9;
            this.btnKullaniciAyarlari.Text = "Kullanıcı Ayarları";
            this.btnKullaniciAyarlari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKullaniciAyarlari.UseVisualStyleBackColor = false;
            this.btnKullaniciAyarlari.Click += new System.EventHandler(this.btnKullaniciAyarlari_Click);
            // 
            // btnKullaniciDegistir
            // 
            this.btnKullaniciDegistir.BackColor = System.Drawing.Color.Navy;
            this.btnKullaniciDegistir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKullaniciDegistir.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnKullaniciDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciDegistir.ForeColor = System.Drawing.Color.White;
            this.btnKullaniciDegistir.Image = global::BarkodluMarketProgrami.Properties.Resources.clerk;
            this.btnKullaniciDegistir.Location = new System.Drawing.Point(553, 277);
            this.btnKullaniciDegistir.Margin = new System.Windows.Forms.Padding(1);
            this.btnKullaniciDegistir.Name = "btnKullaniciDegistir";
            this.btnKullaniciDegistir.Size = new System.Drawing.Size(276, 136);
            this.btnKullaniciDegistir.TabIndex = 8;
            this.btnKullaniciDegistir.Text = "Kullanıcı Değiştir";
            this.btnKullaniciDegistir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKullaniciDegistir.UseVisualStyleBackColor = false;
            this.btnKullaniciDegistir.Click += new System.EventHandler(this.btnKullaniciDegistir_Click);
            // 
            // btnYedekleme
            // 
            this.btnYedekleme.BackColor = System.Drawing.Color.Navy;
            this.btnYedekleme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnYedekleme.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnYedekleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYedekleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYedekleme.ForeColor = System.Drawing.Color.White;
            this.btnYedekleme.Image = global::BarkodluMarketProgrami.Properties.Resources.database;
            this.btnYedekleme.Location = new System.Drawing.Point(277, 277);
            this.btnYedekleme.Margin = new System.Windows.Forms.Padding(1);
            this.btnYedekleme.Name = "btnYedekleme";
            this.btnYedekleme.Size = new System.Drawing.Size(274, 136);
            this.btnYedekleme.TabIndex = 7;
            this.btnYedekleme.Text = "Yedekle";
            this.btnYedekleme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYedekleme.UseVisualStyleBackColor = false;
            this.btnYedekleme.Click += new System.EventHandler(this.btnYedekleme_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.Color.Navy;
            this.btnAyarlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAyarlar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyarlar.ForeColor = System.Drawing.Color.White;
            this.btnAyarlar.Image = global::BarkodluMarketProgrami.Properties.Resources.money_management;
            this.btnAyarlar.Location = new System.Drawing.Point(1, 277);
            this.btnAyarlar.Margin = new System.Windows.Forms.Padding(1);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(274, 136);
            this.btnAyarlar.TabIndex = 6;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnUrunGiris
            // 
            this.btnUrunGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnUrunGiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUrunGiris.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnUrunGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunGiris.ForeColor = System.Drawing.Color.White;
            this.btnUrunGiris.Image = global::BarkodluMarketProgrami.Properties.Resources.milk;
            this.btnUrunGiris.Location = new System.Drawing.Point(1, 139);
            this.btnUrunGiris.Margin = new System.Windows.Forms.Padding(1);
            this.btnUrunGiris.Name = "btnUrunGiris";
            this.btnUrunGiris.Size = new System.Drawing.Size(274, 136);
            this.btnUrunGiris.TabIndex = 3;
            this.btnUrunGiris.Text = "Ürün Giriş";
            this.btnUrunGiris.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUrunGiris.UseVisualStyleBackColor = false;
            this.btnUrunGiris.Click += new System.EventHandler(this.btnUrunGiris_Click);
            // 
            // btnStokTakibi
            // 
            this.btnStokTakibi.BackColor = System.Drawing.Color.Tomato;
            this.btnStokTakibi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStokTakibi.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnStokTakibi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokTakibi.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokTakibi.ForeColor = System.Drawing.Color.White;
            this.btnStokTakibi.Image = global::BarkodluMarketProgrami.Properties.Resources.in_stock;
            this.btnStokTakibi.Location = new System.Drawing.Point(553, 1);
            this.btnStokTakibi.Margin = new System.Windows.Forms.Padding(1);
            this.btnStokTakibi.Name = "btnStokTakibi";
            this.btnStokTakibi.Size = new System.Drawing.Size(276, 136);
            this.btnStokTakibi.TabIndex = 2;
            this.btnStokTakibi.Text = "Stok Takibi";
            this.btnStokTakibi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStokTakibi.UseVisualStyleBackColor = false;
            this.btnStokTakibi.Click += new System.EventHandler(this.btnStokTakibi_Click);
            // 
            // btnGenelRapor
            // 
            this.btnGenelRapor.BackColor = System.Drawing.Color.Tomato;
            this.btnGenelRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenelRapor.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnGenelRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenelRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenelRapor.ForeColor = System.Drawing.Color.White;
            this.btnGenelRapor.Image = global::BarkodluMarketProgrami.Properties.Resources.report;
            this.btnGenelRapor.Location = new System.Drawing.Point(277, 1);
            this.btnGenelRapor.Margin = new System.Windows.Forms.Padding(1);
            this.btnGenelRapor.Name = "btnGenelRapor";
            this.btnGenelRapor.Size = new System.Drawing.Size(274, 136);
            this.btnGenelRapor.TabIndex = 1;
            this.btnGenelRapor.Text = "Genel Rapor";
            this.btnGenelRapor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenelRapor.UseVisualStyleBackColor = false;
            this.btnGenelRapor.Click += new System.EventHandler(this.btnGenelRapor_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.BackColor = System.Drawing.Color.Tomato;
            this.btnSatis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSatis.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatis.ForeColor = System.Drawing.Color.White;
            this.btnSatis.Image = global::BarkodluMarketProgrami.Properties.Resources.price_tag__1_;
            this.btnSatis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatis.Location = new System.Drawing.Point(1, 1);
            this.btnSatis.Margin = new System.Windows.Forms.Padding(1);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(274, 136);
            this.btnSatis.TabIndex = 0;
            this.btnSatis.Text = "Satış İşlemi";
            this.btnSatis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSatis.UseVisualStyleBackColor = false;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnVeresiyeIslemleri
            // 
            this.btnVeresiyeIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnVeresiyeIslemleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVeresiyeIslemleri.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnVeresiyeIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeresiyeIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeresiyeIslemleri.ForeColor = System.Drawing.Color.White;
            this.btnVeresiyeIslemleri.Image = global::BarkodluMarketProgrami.Properties.Resources.money__1_;
            this.btnVeresiyeIslemleri.Location = new System.Drawing.Point(553, 139);
            this.btnVeresiyeIslemleri.Margin = new System.Windows.Forms.Padding(1);
            this.btnVeresiyeIslemleri.Name = "btnVeresiyeIslemleri";
            this.btnVeresiyeIslemleri.Size = new System.Drawing.Size(276, 136);
            this.btnVeresiyeIslemleri.TabIndex = 5;
            this.btnVeresiyeIslemleri.Text = "Veresiye İşlemleri";
            this.btnVeresiyeIslemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVeresiyeIslemleri.UseVisualStyleBackColor = false;
            this.btnVeresiyeIslemleri.Click += new System.EventHandler(this.btnVeresiyeIslemleri_Click);
            // 
            // btnFiyatGuncelle
            // 
            this.btnFiyatGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnFiyatGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFiyatGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnFiyatGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiyatGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiyatGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnFiyatGuncelle.Image = global::BarkodluMarketProgrami.Properties.Resources.cleaning__1_;
            this.btnFiyatGuncelle.Location = new System.Drawing.Point(277, 139);
            this.btnFiyatGuncelle.Margin = new System.Windows.Forms.Padding(1);
            this.btnFiyatGuncelle.Name = "btnFiyatGuncelle";
            this.btnFiyatGuncelle.Size = new System.Drawing.Size(274, 136);
            this.btnFiyatGuncelle.TabIndex = 4;
            this.btnFiyatGuncelle.Text = "Ürün Güncelle";
            this.btnFiyatGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiyatGuncelle.UseVisualStyleBackColor = false;
            this.btnFiyatGuncelle.Click += new System.EventHandler(this.btnFiyatGuncelle_Click);
            // 
            // lblKasiyer
            // 
            this.lblKasiyer.AutoSize = true;
            this.lblKasiyer.BackColor = System.Drawing.Color.Black;
            this.lblKasiyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasiyer.ForeColor = System.Drawing.Color.White;
            this.lblKasiyer.Location = new System.Drawing.Point(30, 20);
            this.lblKasiyer.Name = "lblKasiyer";
            this.lblKasiyer.Size = new System.Drawing.Size(74, 18);
            this.lblKasiyer.TabIndex = 1;
            this.lblKasiyer.Text = "Kasiyer: ";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.BackColor = System.Drawing.Color.Black;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.Color.White;
            this.lblKullanici.Location = new System.Drawing.Point(94, 22);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(71, 16);
            this.lblKullanici.TabIndex = 2;
            this.lblKullanici.Text = "eyupcelix7";
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(898, 622);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.lblKasiyer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(833, 534);
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barkodlu Satış Sistemi";
            this.Load += new System.EventHandler(this.FormGiris_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnKullaniciDegistir;
        private System.Windows.Forms.Button btnYedekleme;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnVeresiyeIslemleri;
        private System.Windows.Forms.Button btnUrunGiris;
        private System.Windows.Forms.Button btnStokTakibi;
        private System.Windows.Forms.Button btnGenelRapor;
        private System.Windows.Forms.Label lblKasiyer;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnYedekYükle;
        private System.Windows.Forms.Button btnKullaniciAyarlari;
        private System.Windows.Forms.Button btnFiyatGuncelle;
        public System.Windows.Forms.Label lblKullanici;
    }
}