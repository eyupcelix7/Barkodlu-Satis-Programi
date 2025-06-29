namespace BarkodluMarketProgrami
{
    partial class FormRaporDetay
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
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblTarih = new System.Windows.Forms.Label();
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.nudNakit = new System.Windows.Forms.NumericUpDown();
            this.nudKart = new System.Windows.Forms.NumericUpDown();
            this.lblKart = new System.Windows.Forms.Label();
            this.lblNakit = new System.Windows.Forms.Label();
            this.lblIadeMi = new System.Windows.Forms.Label();
            this.lblIslemId = new System.Windows.Forms.Label();
            this.lblOdemeSekli = new System.Windows.Forms.Label();
            this.lblGelirMi = new System.Windows.Forms.Label();
            this.lblGiderMi = new System.Windows.Forms.Label();
            this.nudAlisFiyatToplam = new System.Windows.Forms.NumericUpDown();
            this.lblAlisFiyatToplam = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.txtIadeMi = new System.Windows.Forms.TextBox();
            this.txtOdemeSekli = new System.Windows.Forms.TextBox();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtGelirMi = new System.Windows.Forms.TextBox();
            this.txtGiderMi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNakit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlisFiyatToplam)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTarih
            // 
            this.dtpTarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(79, 417);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(299, 26);
            this.dtpTarih.TabIndex = 57;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.Navy;
            this.lblTarih.Location = new System.Drawing.Point(9, 415);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(64, 24);
            this.lblTarih.TabIndex = 56;
            this.lblTarih.Text = "Tarih:";
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbAciklama.Location = new System.Drawing.Point(287, 75);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.ReadOnly = true;
            this.rtbAciklama.Size = new System.Drawing.Size(192, 209);
            this.rtbAciklama.TabIndex = 55;
            this.rtbAciklama.Text = "";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.Navy;
            this.lblAciklama.Location = new System.Drawing.Point(283, 46);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(94, 24);
            this.lblAciklama.TabIndex = 54;
            this.lblAciklama.Text = "Açıklama";
            // 
            // nudNakit
            // 
            this.nudNakit.DecimalPlaces = 2;
            this.nudNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudNakit.Location = new System.Drawing.Point(71, 270);
            this.nudNakit.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudNakit.Name = "nudNakit";
            this.nudNakit.ReadOnly = true;
            this.nudNakit.Size = new System.Drawing.Size(195, 26);
            this.nudNakit.TabIndex = 53;
            // 
            // nudKart
            // 
            this.nudKart.DecimalPlaces = 2;
            this.nudKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudKart.Location = new System.Drawing.Point(71, 316);
            this.nudKart.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudKart.Name = "nudKart";
            this.nudKart.ReadOnly = true;
            this.nudKart.Size = new System.Drawing.Size(195, 26);
            this.nudKart.TabIndex = 52;
            // 
            // lblKart
            // 
            this.lblKart.AutoSize = true;
            this.lblKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKart.ForeColor = System.Drawing.Color.Navy;
            this.lblKart.Location = new System.Drawing.Point(9, 316);
            this.lblKart.Name = "lblKart";
            this.lblKart.Size = new System.Drawing.Size(52, 24);
            this.lblKart.TabIndex = 51;
            this.lblKart.Text = "Kart:";
            // 
            // lblNakit
            // 
            this.lblNakit.AutoSize = true;
            this.lblNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNakit.ForeColor = System.Drawing.Color.Navy;
            this.lblNakit.Location = new System.Drawing.Point(9, 270);
            this.lblNakit.Name = "lblNakit";
            this.lblNakit.Size = new System.Drawing.Size(62, 24);
            this.lblNakit.TabIndex = 50;
            this.lblNakit.Text = "Nakit:";
            // 
            // lblIadeMi
            // 
            this.lblIadeMi.AutoSize = true;
            this.lblIadeMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIadeMi.ForeColor = System.Drawing.Color.Navy;
            this.lblIadeMi.Location = new System.Drawing.Point(8, 87);
            this.lblIadeMi.Name = "lblIadeMi";
            this.lblIadeMi.Size = new System.Drawing.Size(84, 24);
            this.lblIadeMi.TabIndex = 48;
            this.lblIadeMi.Text = "İade Mi:";
            // 
            // lblIslemId
            // 
            this.lblIslemId.AutoSize = true;
            this.lblIslemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIslemId.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblIslemId.Location = new System.Drawing.Point(12, 9);
            this.lblIslemId.Name = "lblIslemId";
            this.lblIslemId.Size = new System.Drawing.Size(187, 25);
            this.lblIslemId.TabIndex = 47;
            this.lblIslemId.Text = "# Numaralı İşlem";
            // 
            // lblOdemeSekli
            // 
            this.lblOdemeSekli.AutoSize = true;
            this.lblOdemeSekli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeSekli.ForeColor = System.Drawing.Color.Navy;
            this.lblOdemeSekli.Location = new System.Drawing.Point(7, 131);
            this.lblOdemeSekli.Name = "lblOdemeSekli";
            this.lblOdemeSekli.Size = new System.Drawing.Size(136, 24);
            this.lblOdemeSekli.TabIndex = 59;
            this.lblOdemeSekli.Text = "Ödeme Şekli:";
            // 
            // lblGelirMi
            // 
            this.lblGelirMi.AutoSize = true;
            this.lblGelirMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelirMi.ForeColor = System.Drawing.Color.Navy;
            this.lblGelirMi.Location = new System.Drawing.Point(7, 177);
            this.lblGelirMi.Name = "lblGelirMi";
            this.lblGelirMi.Size = new System.Drawing.Size(88, 24);
            this.lblGelirMi.TabIndex = 60;
            this.lblGelirMi.Text = "Gelir Mi:";
            // 
            // lblGiderMi
            // 
            this.lblGiderMi.AutoSize = true;
            this.lblGiderMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiderMi.ForeColor = System.Drawing.Color.Navy;
            this.lblGiderMi.Location = new System.Drawing.Point(6, 225);
            this.lblGiderMi.Name = "lblGiderMi";
            this.lblGiderMi.Size = new System.Drawing.Size(95, 24);
            this.lblGiderMi.TabIndex = 61;
            this.lblGiderMi.Text = "Gider Mi:";
            // 
            // nudAlisFiyatToplam
            // 
            this.nudAlisFiyatToplam.DecimalPlaces = 2;
            this.nudAlisFiyatToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudAlisFiyatToplam.Location = new System.Drawing.Point(190, 374);
            this.nudAlisFiyatToplam.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudAlisFiyatToplam.Name = "nudAlisFiyatToplam";
            this.nudAlisFiyatToplam.ReadOnly = true;
            this.nudAlisFiyatToplam.Size = new System.Drawing.Size(187, 26);
            this.nudAlisFiyatToplam.TabIndex = 63;
            // 
            // lblAlisFiyatToplam
            // 
            this.lblAlisFiyatToplam.AutoSize = true;
            this.lblAlisFiyatToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlisFiyatToplam.ForeColor = System.Drawing.Color.Navy;
            this.lblAlisFiyatToplam.Location = new System.Drawing.Point(9, 374);
            this.lblAlisFiyatToplam.Name = "lblAlisFiyatToplam";
            this.lblAlisFiyatToplam.Size = new System.Drawing.Size(176, 24);
            this.lblAlisFiyatToplam.TabIndex = 62;
            this.lblAlisFiyatToplam.Text = "Alış Fiyat Toplam:";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.Color.Navy;
            this.lblKullanici.Location = new System.Drawing.Point(9, 456);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(220, 24);
            this.lblKullanici.TabIndex = 64;
            this.lblKullanici.Text = "İşlemi Yapan Kullanıcı:";
            // 
            // txtIadeMi
            // 
            this.txtIadeMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIadeMi.Location = new System.Drawing.Point(92, 85);
            this.txtIadeMi.Name = "txtIadeMi";
            this.txtIadeMi.ReadOnly = true;
            this.txtIadeMi.Size = new System.Drawing.Size(173, 26);
            this.txtIadeMi.TabIndex = 65;
            // 
            // txtOdemeSekli
            // 
            this.txtOdemeSekli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdemeSekli.Location = new System.Drawing.Point(143, 131);
            this.txtOdemeSekli.Name = "txtOdemeSekli";
            this.txtOdemeSekli.ReadOnly = true;
            this.txtOdemeSekli.Size = new System.Drawing.Size(122, 26);
            this.txtOdemeSekli.TabIndex = 66;
            // 
            // txtKullanici
            // 
            this.txtKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanici.Location = new System.Drawing.Point(229, 461);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.ReadOnly = true;
            this.txtKullanici.Size = new System.Drawing.Size(149, 26);
            this.txtKullanici.TabIndex = 69;
            // 
            // txtGelirMi
            // 
            this.txtGelirMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGelirMi.Location = new System.Drawing.Point(101, 177);
            this.txtGelirMi.Name = "txtGelirMi";
            this.txtGelirMi.ReadOnly = true;
            this.txtGelirMi.Size = new System.Drawing.Size(165, 26);
            this.txtGelirMi.TabIndex = 70;
            // 
            // txtGiderMi
            // 
            this.txtGiderMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGiderMi.Location = new System.Drawing.Point(101, 223);
            this.txtGiderMi.Name = "txtGiderMi";
            this.txtGiderMi.ReadOnly = true;
            this.txtGiderMi.Size = new System.Drawing.Size(164, 26);
            this.txtGiderMi.TabIndex = 71;
            // 
            // FormRaporDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 537);
            this.Controls.Add(this.txtGiderMi);
            this.Controls.Add(this.txtGelirMi);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.txtOdemeSekli);
            this.Controls.Add(this.txtIadeMi);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.nudAlisFiyatToplam);
            this.Controls.Add(this.lblAlisFiyatToplam);
            this.Controls.Add(this.lblGiderMi);
            this.Controls.Add(this.lblGelirMi);
            this.Controls.Add(this.lblOdemeSekli);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.rtbAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.nudNakit);
            this.Controls.Add(this.nudKart);
            this.Controls.Add(this.lblKart);
            this.Controls.Add(this.lblNakit);
            this.Controls.Add(this.lblIadeMi);
            this.Controls.Add(this.lblIslemId);
            this.MaximumSize = new System.Drawing.Size(507, 576);
            this.MinimumSize = new System.Drawing.Size(507, 576);
            this.Name = "FormRaporDetay";
            this.Text = "Rapor Detay";
            this.Load += new System.EventHandler(this.FormRaporDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNakit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlisFiyatToplam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.RichTextBox rtbAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.NumericUpDown nudNakit;
        private System.Windows.Forms.NumericUpDown nudKart;
        private System.Windows.Forms.Label lblKart;
        private System.Windows.Forms.Label lblNakit;
        private System.Windows.Forms.Label lblIadeMi;
        private System.Windows.Forms.Label lblIslemId;
        private System.Windows.Forms.Label lblOdemeSekli;
        private System.Windows.Forms.Label lblGelirMi;
        private System.Windows.Forms.Label lblGiderMi;
        private System.Windows.Forms.NumericUpDown nudAlisFiyatToplam;
        private System.Windows.Forms.Label lblAlisFiyatToplam;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.TextBox txtIadeMi;
        private System.Windows.Forms.TextBox txtOdemeSekli;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtGelirMi;
        private System.Windows.Forms.TextBox txtGiderMi;
    }
}