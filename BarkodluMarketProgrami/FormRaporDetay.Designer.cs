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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtGiderMi = new System.Windows.Forms.TextBox();
            this.txtGelirMi = new System.Windows.Forms.TextBox();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtOdemeSekli = new System.Windows.Forms.TextBox();
            this.txtIadeMi = new System.Windows.Forms.TextBox();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.nudAlisFiyatToplam = new System.Windows.Forms.NumericUpDown();
            this.lblAlisFiyatToplam = new System.Windows.Forms.Label();
            this.lblGiderMi = new System.Windows.Forms.Label();
            this.lblGelirMi = new System.Windows.Forms.Label();
            this.lblOdemeSekli = new System.Windows.Forms.Label();
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
            this.gridUrunListesi = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlisFiyatToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNakit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(832, 537);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtGiderMi);
            this.tabPage1.Controls.Add(this.txtGelirMi);
            this.tabPage1.Controls.Add(this.txtKullanici);
            this.tabPage1.Controls.Add(this.txtOdemeSekli);
            this.tabPage1.Controls.Add(this.txtIadeMi);
            this.tabPage1.Controls.Add(this.lblKullanici);
            this.tabPage1.Controls.Add(this.nudAlisFiyatToplam);
            this.tabPage1.Controls.Add(this.lblAlisFiyatToplam);
            this.tabPage1.Controls.Add(this.lblGiderMi);
            this.tabPage1.Controls.Add(this.lblGelirMi);
            this.tabPage1.Controls.Add(this.lblOdemeSekli);
            this.tabPage1.Controls.Add(this.dtpTarih);
            this.tabPage1.Controls.Add(this.lblTarih);
            this.tabPage1.Controls.Add(this.rtbAciklama);
            this.tabPage1.Controls.Add(this.lblAciklama);
            this.tabPage1.Controls.Add(this.nudNakit);
            this.tabPage1.Controls.Add(this.nudKart);
            this.tabPage1.Controls.Add(this.lblKart);
            this.tabPage1.Controls.Add(this.lblNakit);
            this.tabPage1.Controls.Add(this.lblIadeMi);
            this.tabPage1.Controls.Add(this.lblIslemId);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(824, 504);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tekli İşlem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridUrunListesi);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tüm İşlem";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtGiderMi
            // 
            this.txtGiderMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGiderMi.Location = new System.Drawing.Point(100, 218);
            this.txtGiderMi.Name = "txtGiderMi";
            this.txtGiderMi.ReadOnly = true;
            this.txtGiderMi.Size = new System.Drawing.Size(164, 26);
            this.txtGiderMi.TabIndex = 92;
            // 
            // txtGelirMi
            // 
            this.txtGelirMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGelirMi.Location = new System.Drawing.Point(100, 172);
            this.txtGelirMi.Name = "txtGelirMi";
            this.txtGelirMi.ReadOnly = true;
            this.txtGelirMi.Size = new System.Drawing.Size(165, 26);
            this.txtGelirMi.TabIndex = 91;
            // 
            // txtKullanici
            // 
            this.txtKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanici.Location = new System.Drawing.Point(228, 456);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.ReadOnly = true;
            this.txtKullanici.Size = new System.Drawing.Size(149, 26);
            this.txtKullanici.TabIndex = 90;
            // 
            // txtOdemeSekli
            // 
            this.txtOdemeSekli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdemeSekli.Location = new System.Drawing.Point(142, 126);
            this.txtOdemeSekli.Name = "txtOdemeSekli";
            this.txtOdemeSekli.ReadOnly = true;
            this.txtOdemeSekli.Size = new System.Drawing.Size(122, 26);
            this.txtOdemeSekli.TabIndex = 89;
            // 
            // txtIadeMi
            // 
            this.txtIadeMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIadeMi.Location = new System.Drawing.Point(91, 80);
            this.txtIadeMi.Name = "txtIadeMi";
            this.txtIadeMi.ReadOnly = true;
            this.txtIadeMi.Size = new System.Drawing.Size(173, 26);
            this.txtIadeMi.TabIndex = 88;
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.Color.Navy;
            this.lblKullanici.Location = new System.Drawing.Point(8, 451);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(220, 24);
            this.lblKullanici.TabIndex = 87;
            this.lblKullanici.Text = "İşlemi Yapan Kullanıcı:";
            // 
            // nudAlisFiyatToplam
            // 
            this.nudAlisFiyatToplam.DecimalPlaces = 2;
            this.nudAlisFiyatToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudAlisFiyatToplam.Location = new System.Drawing.Point(189, 369);
            this.nudAlisFiyatToplam.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudAlisFiyatToplam.Name = "nudAlisFiyatToplam";
            this.nudAlisFiyatToplam.ReadOnly = true;
            this.nudAlisFiyatToplam.Size = new System.Drawing.Size(187, 26);
            this.nudAlisFiyatToplam.TabIndex = 86;
            // 
            // lblAlisFiyatToplam
            // 
            this.lblAlisFiyatToplam.AutoSize = true;
            this.lblAlisFiyatToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlisFiyatToplam.ForeColor = System.Drawing.Color.Navy;
            this.lblAlisFiyatToplam.Location = new System.Drawing.Point(8, 369);
            this.lblAlisFiyatToplam.Name = "lblAlisFiyatToplam";
            this.lblAlisFiyatToplam.Size = new System.Drawing.Size(176, 24);
            this.lblAlisFiyatToplam.TabIndex = 85;
            this.lblAlisFiyatToplam.Text = "Alış Fiyat Toplam:";
            // 
            // lblGiderMi
            // 
            this.lblGiderMi.AutoSize = true;
            this.lblGiderMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiderMi.ForeColor = System.Drawing.Color.Navy;
            this.lblGiderMi.Location = new System.Drawing.Point(5, 220);
            this.lblGiderMi.Name = "lblGiderMi";
            this.lblGiderMi.Size = new System.Drawing.Size(95, 24);
            this.lblGiderMi.TabIndex = 84;
            this.lblGiderMi.Text = "Gider Mi:";
            // 
            // lblGelirMi
            // 
            this.lblGelirMi.AutoSize = true;
            this.lblGelirMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelirMi.ForeColor = System.Drawing.Color.Navy;
            this.lblGelirMi.Location = new System.Drawing.Point(6, 172);
            this.lblGelirMi.Name = "lblGelirMi";
            this.lblGelirMi.Size = new System.Drawing.Size(88, 24);
            this.lblGelirMi.TabIndex = 83;
            this.lblGelirMi.Text = "Gelir Mi:";
            // 
            // lblOdemeSekli
            // 
            this.lblOdemeSekli.AutoSize = true;
            this.lblOdemeSekli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeSekli.ForeColor = System.Drawing.Color.Navy;
            this.lblOdemeSekli.Location = new System.Drawing.Point(6, 126);
            this.lblOdemeSekli.Name = "lblOdemeSekli";
            this.lblOdemeSekli.Size = new System.Drawing.Size(136, 24);
            this.lblOdemeSekli.TabIndex = 82;
            this.lblOdemeSekli.Text = "Ödeme Şekli:";
            // 
            // dtpTarih
            // 
            this.dtpTarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(78, 412);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(299, 26);
            this.dtpTarih.TabIndex = 81;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.Navy;
            this.lblTarih.Location = new System.Drawing.Point(8, 410);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(64, 24);
            this.lblTarih.TabIndex = 80;
            this.lblTarih.Text = "Tarih:";
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbAciklama.Location = new System.Drawing.Point(599, 58);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.ReadOnly = true;
            this.rtbAciklama.Size = new System.Drawing.Size(192, 209);
            this.rtbAciklama.TabIndex = 79;
            this.rtbAciklama.Text = "";
            // 
            // lblAciklama
            // 
            this.lblAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.Navy;
            this.lblAciklama.Location = new System.Drawing.Point(595, 29);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(94, 24);
            this.lblAciklama.TabIndex = 78;
            this.lblAciklama.Text = "Açıklama";
            // 
            // nudNakit
            // 
            this.nudNakit.DecimalPlaces = 2;
            this.nudNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudNakit.Location = new System.Drawing.Point(70, 265);
            this.nudNakit.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudNakit.Name = "nudNakit";
            this.nudNakit.ReadOnly = true;
            this.nudNakit.Size = new System.Drawing.Size(195, 26);
            this.nudNakit.TabIndex = 77;
            // 
            // nudKart
            // 
            this.nudKart.DecimalPlaces = 2;
            this.nudKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudKart.Location = new System.Drawing.Point(70, 311);
            this.nudKart.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudKart.Name = "nudKart";
            this.nudKart.ReadOnly = true;
            this.nudKart.Size = new System.Drawing.Size(195, 26);
            this.nudKart.TabIndex = 76;
            // 
            // lblKart
            // 
            this.lblKart.AutoSize = true;
            this.lblKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKart.ForeColor = System.Drawing.Color.Navy;
            this.lblKart.Location = new System.Drawing.Point(8, 311);
            this.lblKart.Name = "lblKart";
            this.lblKart.Size = new System.Drawing.Size(52, 24);
            this.lblKart.TabIndex = 75;
            this.lblKart.Text = "Kart:";
            // 
            // lblNakit
            // 
            this.lblNakit.AutoSize = true;
            this.lblNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNakit.ForeColor = System.Drawing.Color.Navy;
            this.lblNakit.Location = new System.Drawing.Point(8, 265);
            this.lblNakit.Name = "lblNakit";
            this.lblNakit.Size = new System.Drawing.Size(62, 24);
            this.lblNakit.TabIndex = 74;
            this.lblNakit.Text = "Nakit:";
            // 
            // lblIadeMi
            // 
            this.lblIadeMi.AutoSize = true;
            this.lblIadeMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIadeMi.ForeColor = System.Drawing.Color.Navy;
            this.lblIadeMi.Location = new System.Drawing.Point(7, 82);
            this.lblIadeMi.Name = "lblIadeMi";
            this.lblIadeMi.Size = new System.Drawing.Size(84, 24);
            this.lblIadeMi.TabIndex = 73;
            this.lblIadeMi.Text = "İade Mi:";
            // 
            // lblIslemId
            // 
            this.lblIslemId.AutoSize = true;
            this.lblIslemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIslemId.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblIslemId.Location = new System.Drawing.Point(11, 28);
            this.lblIslemId.Name = "lblIslemId";
            this.lblIslemId.Size = new System.Drawing.Size(249, 25);
            this.lblIslemId.TabIndex = 72;
            this.lblIslemId.Text = "# Numaralı İşlem Özeti";
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
            this.gridUrunListesi.Size = new System.Drawing.Size(818, 498);
            this.gridUrunListesi.TabIndex = 3;
            // 
            // FormRaporDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 537);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormRaporDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor Detay";
            this.Load += new System.EventHandler(this.FormRaporDetay_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAlisFiyatToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNakit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtGiderMi;
        private System.Windows.Forms.TextBox txtGelirMi;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtOdemeSekli;
        private System.Windows.Forms.TextBox txtIadeMi;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.NumericUpDown nudAlisFiyatToplam;
        private System.Windows.Forms.Label lblAlisFiyatToplam;
        private System.Windows.Forms.Label lblGiderMi;
        private System.Windows.Forms.Label lblGelirMi;
        private System.Windows.Forms.Label lblOdemeSekli;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gridUrunListesi;
    }
}