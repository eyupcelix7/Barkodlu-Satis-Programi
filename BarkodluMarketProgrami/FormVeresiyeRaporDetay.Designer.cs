namespace BarkodluMarketProgrami
{
    partial class FormVeresiyeRaporDetay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridUrunListesi = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblGiderMi = new System.Windows.Forms.Label();
            this.lblGelirMi = new System.Windows.Forms.Label();
            this.lblOdemeSekli = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblTarih = new System.Windows.Forms.Label();
            this.nudTutar = new System.Windows.Forms.NumericUpDown();
            this.lblIadeMi = new System.Windows.Forms.Label();
            this.lblIslemId = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtSatis = new System.Windows.Forms.TextBox();
            this.txtOdeme = new System.Windows.Forms.TextBox();
            this.lblDetaylar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunListesi)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTutar)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridUrunListesi
            // 
            this.gridUrunListesi.AllowUserToAddRows = false;
            this.gridUrunListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUrunListesi.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridUrunListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUrunListesi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUrunListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUrunListesi.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUrunListesi.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridUrunListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUrunListesi.EnableHeadersVisualStyles = false;
            this.gridUrunListesi.GridColor = System.Drawing.Color.White;
            this.gridUrunListesi.Location = new System.Drawing.Point(3, 3);
            this.gridUrunListesi.Margin = new System.Windows.Forms.Padding(2);
            this.gridUrunListesi.Name = "gridUrunListesi";
            this.gridUrunListesi.ReadOnly = true;
            this.gridUrunListesi.RowHeadersVisible = false;
            this.gridUrunListesi.RowHeadersWidth = 51;
            this.gridUrunListesi.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridUrunListesi.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridUrunListesi.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.gridUrunListesi.RowTemplate.Height = 32;
            this.gridUrunListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUrunListesi.Size = new System.Drawing.Size(786, 514);
            this.gridUrunListesi.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridUrunListesi);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Geçmiş Borçlar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtKullanici
            // 
            this.txtKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanici.Location = new System.Drawing.Point(107, 327);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.ReadOnly = true;
            this.txtKullanici.Size = new System.Drawing.Size(179, 26);
            this.txtKullanici.TabIndex = 90;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(113, 82);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.ReadOnly = true;
            this.txtAdSoyad.Size = new System.Drawing.Size(173, 26);
            this.txtAdSoyad.TabIndex = 88;
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.Color.Navy;
            this.lblKullanici.Location = new System.Drawing.Point(6, 327);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(95, 24);
            this.lblKullanici.TabIndex = 87;
            this.lblKullanici.Text = "Kullanıcı:";
            // 
            // lblGiderMi
            // 
            this.lblGiderMi.AutoSize = true;
            this.lblGiderMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiderMi.ForeColor = System.Drawing.Color.Navy;
            this.lblGiderMi.Location = new System.Drawing.Point(5, 220);
            this.lblGiderMi.Name = "lblGiderMi";
            this.lblGiderMi.Size = new System.Drawing.Size(118, 24);
            this.lblGiderMi.TabIndex = 84;
            this.lblGiderMi.Text = "Ödeme Mi?";
            // 
            // lblGelirMi
            // 
            this.lblGelirMi.AutoSize = true;
            this.lblGelirMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelirMi.ForeColor = System.Drawing.Color.Navy;
            this.lblGelirMi.Location = new System.Drawing.Point(6, 172);
            this.lblGelirMi.Name = "lblGelirMi";
            this.lblGelirMi.Size = new System.Drawing.Size(58, 24);
            this.lblGelirMi.TabIndex = 83;
            this.lblGelirMi.Text = "Tutar";
            // 
            // lblOdemeSekli
            // 
            this.lblOdemeSekli.AutoSize = true;
            this.lblOdemeSekli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeSekli.ForeColor = System.Drawing.Color.Navy;
            this.lblOdemeSekli.Location = new System.Drawing.Point(6, 126);
            this.lblOdemeSekli.Name = "lblOdemeSekli";
            this.lblOdemeSekli.Size = new System.Drawing.Size(153, 24);
            this.lblOdemeSekli.TabIndex = 82;
            this.lblOdemeSekli.Text = "Satış İşlemi Mi?";
            // 
            // dtpTarih
            // 
            this.dtpTarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(70, 271);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(299, 26);
            this.dtpTarih.TabIndex = 81;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.Navy;
            this.lblTarih.Location = new System.Drawing.Point(7, 271);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(64, 24);
            this.lblTarih.TabIndex = 80;
            this.lblTarih.Text = "Tarih:";
            // 
            // nudTutar
            // 
            this.nudTutar.DecimalPlaces = 2;
            this.nudTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudTutar.Location = new System.Drawing.Point(70, 170);
            this.nudTutar.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudTutar.Name = "nudTutar";
            this.nudTutar.ReadOnly = true;
            this.nudTutar.Size = new System.Drawing.Size(160, 26);
            this.nudTutar.TabIndex = 77;
            // 
            // lblIadeMi
            // 
            this.lblIadeMi.AutoSize = true;
            this.lblIadeMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIadeMi.ForeColor = System.Drawing.Color.Navy;
            this.lblIadeMi.Location = new System.Drawing.Point(7, 82);
            this.lblIadeMi.Name = "lblIadeMi";
            this.lblIadeMi.Size = new System.Drawing.Size(100, 24);
            this.lblIadeMi.TabIndex = 73;
            this.lblIadeMi.Text = "Ad Soyad";
            // 
            // lblIslemId
            // 
            this.lblIslemId.AutoSize = true;
            this.lblIslemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIslemId.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblIslemId.Location = new System.Drawing.Point(6, 28);
            this.lblIslemId.Name = "lblIslemId";
            this.lblIslemId.Size = new System.Drawing.Size(224, 25);
            this.lblIslemId.TabIndex = 72;
            this.lblIslemId.Text = "Tekli Veresiye Özeti";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblDetaylar);
            this.tabPage1.Controls.Add(this.txtOdeme);
            this.tabPage1.Controls.Add(this.txtSatis);
            this.tabPage1.Controls.Add(this.txtKullanici);
            this.tabPage1.Controls.Add(this.txtAdSoyad);
            this.tabPage1.Controls.Add(this.lblKullanici);
            this.tabPage1.Controls.Add(this.lblGiderMi);
            this.tabPage1.Controls.Add(this.lblGelirMi);
            this.tabPage1.Controls.Add(this.lblOdemeSekli);
            this.tabPage1.Controls.Add(this.dtpTarih);
            this.tabPage1.Controls.Add(this.lblTarih);
            this.tabPage1.Controls.Add(this.nudTutar);
            this.tabPage1.Controls.Add(this.lblIadeMi);
            this.tabPage1.Controls.Add(this.lblIslemId);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tekli Sorgu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 553);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 520);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Geçmiş Ödemeler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtSatis
            // 
            this.txtSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatis.Location = new System.Drawing.Point(165, 126);
            this.txtSatis.Name = "txtSatis";
            this.txtSatis.ReadOnly = true;
            this.txtSatis.Size = new System.Drawing.Size(121, 26);
            this.txtSatis.TabIndex = 91;
            // 
            // txtOdeme
            // 
            this.txtOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdeme.Location = new System.Drawing.Point(129, 218);
            this.txtOdeme.Name = "txtOdeme";
            this.txtOdeme.ReadOnly = true;
            this.txtOdeme.Size = new System.Drawing.Size(157, 26);
            this.txtOdeme.TabIndex = 93;
            // 
            // lblDetaylar
            // 
            this.lblDetaylar.AutoSize = true;
            this.lblDetaylar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDetaylar.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDetaylar.Location = new System.Drawing.Point(293, 132);
            this.lblDetaylar.Name = "lblDetaylar";
            this.lblDetaylar.Size = new System.Drawing.Size(76, 16);
            this.lblDetaylar.TabIndex = 94;
            this.lblDetaylar.Text = "(Detaylar)";
            this.lblDetaylar.Visible = false;
            // 
            // FormVeresiyeRaporDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormVeresiyeRaporDetay";
            this.Text = "FormVeresiyeRaporDetay";
            this.Load += new System.EventHandler(this.FormVeresiyeRaporDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunListesi)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTutar)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridUrunListesi;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblGiderMi;
        private System.Windows.Forms.Label lblGelirMi;
        private System.Windows.Forms.Label lblOdemeSekli;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.NumericUpDown nudTutar;
        private System.Windows.Forms.Label lblIadeMi;
        private System.Windows.Forms.Label lblIslemId;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblDetaylar;
        private System.Windows.Forms.TextBox txtOdeme;
        private System.Windows.Forms.TextBox txtSatis;
    }
}