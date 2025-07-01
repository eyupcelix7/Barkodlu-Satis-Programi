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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnGenelRapor = new System.Windows.Forms.Button();
            this.btnStokTakibi = new System.Windows.Forms.Button();
            this.btnUrunGiris = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnFiyatGuncelle = new System.Windows.Forms.Button();
            this.btnYedekle = new System.Windows.Forms.Button();
            this.btnKullaniciDegistir = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblKasiyer = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btnCikis, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnKullaniciDegistir, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnYedekle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnFiyatGuncelle, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAyarlar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnUrunGiris, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnStokTakibi, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGenelRapor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSatis, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(723, 362);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSatis
            // 
            this.btnSatis.BackColor = System.Drawing.Color.Tomato;
            this.btnSatis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSatis.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatis.ForeColor = System.Drawing.Color.White;
            this.btnSatis.Location = new System.Drawing.Point(3, 3);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(235, 114);
            this.btnSatis.TabIndex = 0;
            this.btnSatis.Text = "Satış";
            this.btnSatis.UseVisualStyleBackColor = false;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnGenelRapor
            // 
            this.btnGenelRapor.BackColor = System.Drawing.Color.Tomato;
            this.btnGenelRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenelRapor.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnGenelRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenelRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenelRapor.ForeColor = System.Drawing.Color.White;
            this.btnGenelRapor.Location = new System.Drawing.Point(244, 3);
            this.btnGenelRapor.Name = "btnGenelRapor";
            this.btnGenelRapor.Size = new System.Drawing.Size(235, 114);
            this.btnGenelRapor.TabIndex = 1;
            this.btnGenelRapor.Text = "Genel Rapor";
            this.btnGenelRapor.UseVisualStyleBackColor = false;
            this.btnGenelRapor.Click += new System.EventHandler(this.btnGenelRapor_Click);
            // 
            // btnStokTakibi
            // 
            this.btnStokTakibi.BackColor = System.Drawing.Color.Tomato;
            this.btnStokTakibi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStokTakibi.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnStokTakibi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokTakibi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokTakibi.ForeColor = System.Drawing.Color.White;
            this.btnStokTakibi.Location = new System.Drawing.Point(485, 3);
            this.btnStokTakibi.Name = "btnStokTakibi";
            this.btnStokTakibi.Size = new System.Drawing.Size(235, 114);
            this.btnStokTakibi.TabIndex = 2;
            this.btnStokTakibi.Text = "Stok Takibi";
            this.btnStokTakibi.UseVisualStyleBackColor = false;
            this.btnStokTakibi.Click += new System.EventHandler(this.btnStokTakibi_Click);
            // 
            // btnUrunGiris
            // 
            this.btnUrunGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnUrunGiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUrunGiris.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnUrunGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunGiris.ForeColor = System.Drawing.Color.White;
            this.btnUrunGiris.Location = new System.Drawing.Point(3, 123);
            this.btnUrunGiris.Name = "btnUrunGiris";
            this.btnUrunGiris.Size = new System.Drawing.Size(235, 114);
            this.btnUrunGiris.TabIndex = 3;
            this.btnUrunGiris.Text = "Ürün Giriş";
            this.btnUrunGiris.UseVisualStyleBackColor = false;
            this.btnUrunGiris.Click += new System.EventHandler(this.btnUrunGiris_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnAyarlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAyarlar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyarlar.ForeColor = System.Drawing.Color.White;
            this.btnAyarlar.Location = new System.Drawing.Point(244, 123);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(235, 114);
            this.btnAyarlar.TabIndex = 4;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.UseVisualStyleBackColor = false;
            // 
            // btnFiyatGuncelle
            // 
            this.btnFiyatGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnFiyatGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFiyatGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnFiyatGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiyatGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiyatGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnFiyatGuncelle.Location = new System.Drawing.Point(485, 123);
            this.btnFiyatGuncelle.Name = "btnFiyatGuncelle";
            this.btnFiyatGuncelle.Size = new System.Drawing.Size(235, 114);
            this.btnFiyatGuncelle.TabIndex = 5;
            this.btnFiyatGuncelle.Text = "Fiyat Güncelle";
            this.btnFiyatGuncelle.UseVisualStyleBackColor = false;
            this.btnFiyatGuncelle.Click += new System.EventHandler(this.btnFiyatGuncelle_Click);
            // 
            // btnYedekle
            // 
            this.btnYedekle.BackColor = System.Drawing.Color.DarkGreen;
            this.btnYedekle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnYedekle.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnYedekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYedekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYedekle.ForeColor = System.Drawing.Color.White;
            this.btnYedekle.Location = new System.Drawing.Point(3, 243);
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.Size = new System.Drawing.Size(235, 116);
            this.btnYedekle.TabIndex = 6;
            this.btnYedekle.Text = "Yedekleme";
            this.btnYedekle.UseVisualStyleBackColor = false;
            // 
            // btnKullaniciDegistir
            // 
            this.btnKullaniciDegistir.BackColor = System.Drawing.Color.DarkGreen;
            this.btnKullaniciDegistir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKullaniciDegistir.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnKullaniciDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciDegistir.ForeColor = System.Drawing.Color.White;
            this.btnKullaniciDegistir.Location = new System.Drawing.Point(244, 243);
            this.btnKullaniciDegistir.Name = "btnKullaniciDegistir";
            this.btnKullaniciDegistir.Size = new System.Drawing.Size(235, 116);
            this.btnKullaniciDegistir.TabIndex = 7;
            this.btnKullaniciDegistir.Text = "Kullanıcı Değiştir";
            this.btnKullaniciDegistir.UseVisualStyleBackColor = false;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCikis.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(485, 243);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(235, 116);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
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
            this.ClientSize = new System.Drawing.Size(791, 455);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.lblKasiyer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barkodlu Satış Sistemi";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnKullaniciDegistir;
        private System.Windows.Forms.Button btnYedekle;
        private System.Windows.Forms.Button btnFiyatGuncelle;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnUrunGiris;
        private System.Windows.Forms.Button btnStokTakibi;
        private System.Windows.Forms.Button btnGenelRapor;
        private System.Windows.Forms.Label lblKasiyer;
        private System.Windows.Forms.Label lblKullanici;
    }
}