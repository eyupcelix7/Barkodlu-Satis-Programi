namespace BarkodluMarketProgrami
{
    partial class FormStokIzleme
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cbxTumZamanlar = new System.Windows.Forms.CheckBox();
            this.pnlUrunAdi = new System.Windows.Forms.Panel();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblBitisTarihi = new System.Windows.Forms.Label();
            this.rdbUrunGrubunaGore = new System.Windows.Forms.RadioButton();
            this.lblUrunGrubu = new System.Windows.Forms.Label();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbIslemTuru = new System.Windows.Forms.ComboBox();
            this.lblBaslangicTarihi = new System.Windows.Forms.Label();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblFiltrelemeTuru = new System.Windows.Forms.Label();
            this.rdbTumu = new System.Windows.Forms.RadioButton();
            this.lblIslemTuru = new System.Windows.Forms.Label();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lblKasiyer = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.nudBulunanUrunSayisi = new System.Windows.Forms.NumericUpDown();
            this.lblBulunanUrunSayisi = new System.Windows.Forms.Label();
            this.gridSonucListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.pnlUrunAdi.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBulunanUrunSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSonucListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1860, 896);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.cbxTumZamanlar);
            this.splitContainer2.Panel1.Controls.Add(this.pnlUrunAdi);
            this.splitContainer2.Panel1.Controls.Add(this.lblBitisTarihi);
            this.splitContainer2.Panel1.Controls.Add(this.rdbUrunGrubunaGore);
            this.splitContainer2.Panel1.Controls.Add(this.lblUrunGrubu);
            this.splitContainer2.Panel1.Controls.Add(this.dtpBitisTarihi);
            this.splitContainer2.Panel1.Controls.Add(this.cmbIslemTuru);
            this.splitContainer2.Panel1.Controls.Add(this.lblBaslangicTarihi);
            this.splitContainer2.Panel1.Controls.Add(this.dtpBaslangicTarihi);
            this.splitContainer2.Panel1.Controls.Add(this.lblFiltrelemeTuru);
            this.splitContainer2.Panel1.Controls.Add(this.rdbTumu);
            this.splitContainer2.Panel1.Controls.Add(this.lblIslemTuru);
            this.splitContainer2.Panel1.Controls.Add(this.cmbUrunGrubu);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer2.Size = new System.Drawing.Size(305, 896);
            this.splitContainer2.SplitterDistance = 785;
            this.splitContainer2.TabIndex = 0;
            // 
            // cbxTumZamanlar
            // 
            this.cbxTumZamanlar.AutoSize = true;
            this.cbxTumZamanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxTumZamanlar.ForeColor = System.Drawing.Color.Navy;
            this.cbxTumZamanlar.Location = new System.Drawing.Point(14, 465);
            this.cbxTumZamanlar.Name = "cbxTumZamanlar";
            this.cbxTumZamanlar.Size = new System.Drawing.Size(142, 24);
            this.cbxTumZamanlar.TabIndex = 13;
            this.cbxTumZamanlar.Text = "Tüm Zamanlar";
            this.cbxTumZamanlar.UseVisualStyleBackColor = true;
            this.cbxTumZamanlar.CheckedChanged += new System.EventHandler(this.cbxTumZamanlar_CheckedChanged);
            // 
            // pnlUrunAdi
            // 
            this.pnlUrunAdi.Controls.Add(this.txtUrunAdi);
            this.pnlUrunAdi.Controls.Add(this.lblUrunAdi);
            this.pnlUrunAdi.Location = new System.Drawing.Point(4, 515);
            this.pnlUrunAdi.Name = "pnlUrunAdi";
            this.pnlUrunAdi.Size = new System.Drawing.Size(299, 100);
            this.pnlUrunAdi.TabIndex = 12;
            this.pnlUrunAdi.Visible = false;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(6, 46);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(231, 26);
            this.txtUrunAdi.TabIndex = 2;
            this.txtUrunAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunAdi_KeyPress);
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUrunAdi.Location = new System.Drawing.Point(6, 14);
            this.lblUrunAdi.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(103, 25);
            this.lblUrunAdi.TabIndex = 11;
            this.lblUrunAdi.Text = "Ürün Adı";
            this.lblUrunAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBitisTarihi
            // 
            this.lblBitisTarihi.AutoSize = true;
            this.lblBitisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitisTarihi.Location = new System.Drawing.Point(9, 375);
            this.lblBitisTarihi.Margin = new System.Windows.Forms.Padding(0);
            this.lblBitisTarihi.Name = "lblBitisTarihi";
            this.lblBitisTarihi.Size = new System.Drawing.Size(125, 25);
            this.lblBitisTarihi.TabIndex = 8;
            this.lblBitisTarihi.Text = "Bitiş Tarihi";
            this.lblBitisTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbUrunGrubunaGore
            // 
            this.rdbUrunGrubunaGore.AutoSize = true;
            this.rdbUrunGrubunaGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbUrunGrubunaGore.ForeColor = System.Drawing.Color.Navy;
            this.rdbUrunGrubunaGore.Location = new System.Drawing.Point(14, 70);
            this.rdbUrunGrubunaGore.Margin = new System.Windows.Forms.Padding(0);
            this.rdbUrunGrubunaGore.Name = "rdbUrunGrubunaGore";
            this.rdbUrunGrubunaGore.Size = new System.Drawing.Size(212, 28);
            this.rdbUrunGrubunaGore.TabIndex = 1;
            this.rdbUrunGrubunaGore.Text = "Ürün Grubuna Göre";
            this.rdbUrunGrubunaGore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbUrunGrubunaGore.UseVisualStyleBackColor = true;
            // 
            // lblUrunGrubu
            // 
            this.lblUrunGrubu.AutoSize = true;
            this.lblUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunGrubu.Location = new System.Drawing.Point(9, 189);
            this.lblUrunGrubu.Margin = new System.Windows.Forms.Padding(0);
            this.lblUrunGrubu.Name = "lblUrunGrubu";
            this.lblUrunGrubu.Size = new System.Drawing.Size(133, 25);
            this.lblUrunGrubu.TabIndex = 4;
            this.lblUrunGrubu.Text = "Ürün Grubu";
            this.lblUrunGrubu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBitisTarihi.Location = new System.Drawing.Point(14, 416);
            this.dtpBitisTarihi.Margin = new System.Windows.Forms.Padding(0);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(226, 26);
            this.dtpBitisTarihi.TabIndex = 9;
            // 
            // cmbIslemTuru
            // 
            this.cmbIslemTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslemTuru.FormattingEnabled = true;
            this.cmbIslemTuru.Items.AddRange(new object[] {
            "Stok Durumu",
            "Stok Giriş İzleme"});
            this.cmbIslemTuru.Location = new System.Drawing.Point(14, 137);
            this.cmbIslemTuru.Margin = new System.Windows.Forms.Padding(0);
            this.cmbIslemTuru.Name = "cmbIslemTuru";
            this.cmbIslemTuru.Size = new System.Drawing.Size(226, 28);
            this.cmbIslemTuru.TabIndex = 1;
            // 
            // lblBaslangicTarihi
            // 
            this.lblBaslangicTarihi.AutoSize = true;
            this.lblBaslangicTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslangicTarihi.Location = new System.Drawing.Point(9, 291);
            this.lblBaslangicTarihi.Margin = new System.Windows.Forms.Padding(0);
            this.lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            this.lblBaslangicTarihi.Size = new System.Drawing.Size(182, 25);
            this.lblBaslangicTarihi.TabIndex = 6;
            this.lblBaslangicTarihi.Text = "Başlangıç Tarihi";
            this.lblBaslangicTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(14, 330);
            this.dtpBaslangicTarihi.Margin = new System.Windows.Forms.Padding(0);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(226, 26);
            this.dtpBaslangicTarihi.TabIndex = 7;
            // 
            // lblFiltrelemeTuru
            // 
            this.lblFiltrelemeTuru.AutoSize = true;
            this.lblFiltrelemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiltrelemeTuru.Location = new System.Drawing.Point(9, 9);
            this.lblFiltrelemeTuru.Margin = new System.Windows.Forms.Padding(0);
            this.lblFiltrelemeTuru.Name = "lblFiltrelemeTuru";
            this.lblFiltrelemeTuru.Size = new System.Drawing.Size(171, 25);
            this.lblFiltrelemeTuru.TabIndex = 2;
            this.lblFiltrelemeTuru.Text = "Filtreleme Türü";
            this.lblFiltrelemeTuru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbTumu
            // 
            this.rdbTumu.AutoSize = true;
            this.rdbTumu.Checked = true;
            this.rdbTumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbTumu.ForeColor = System.Drawing.Color.Navy;
            this.rdbTumu.Location = new System.Drawing.Point(14, 47);
            this.rdbTumu.Margin = new System.Windows.Forms.Padding(0);
            this.rdbTumu.Name = "rdbTumu";
            this.rdbTumu.Size = new System.Drawing.Size(82, 28);
            this.rdbTumu.TabIndex = 0;
            this.rdbTumu.TabStop = true;
            this.rdbTumu.Text = "Tümü";
            this.rdbTumu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbTumu.UseVisualStyleBackColor = true;
            // 
            // lblIslemTuru
            // 
            this.lblIslemTuru.AutoSize = true;
            this.lblIslemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIslemTuru.Location = new System.Drawing.Point(9, 109);
            this.lblIslemTuru.Margin = new System.Windows.Forms.Padding(0);
            this.lblIslemTuru.Name = "lblIslemTuru";
            this.lblIslemTuru.Size = new System.Drawing.Size(122, 25);
            this.lblIslemTuru.TabIndex = 0;
            this.lblIslemTuru.Text = "İşlem Türü";
            this.lblIslemTuru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunGrubu.FormattingEnabled = true;
            this.cmbUrunGrubu.Location = new System.Drawing.Point(14, 225);
            this.cmbUrunGrubu.Margin = new System.Windows.Forms.Padding(0);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(226, 28);
            this.cmbUrunGrubu.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnTemizle, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAra, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(305, 107);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.OrangeRed;
            this.btnTemizle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(153, 1);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(1);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(151, 105);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(1, 1);
            this.btnAra.Margin = new System.Windows.Forms.Padding(1);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(150, 105);
            this.btnAra.TabIndex = 10;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.lblKasiyer);
            this.splitContainer3.Panel1.Controls.Add(this.lblKullanici);
            this.splitContainer3.Panel1.Controls.Add(this.btnPdf);
            this.splitContainer3.Panel1.Controls.Add(this.btnExcel);
            this.splitContainer3.Panel1.Controls.Add(this.nudBulunanUrunSayisi);
            this.splitContainer3.Panel1.Controls.Add(this.lblBulunanUrunSayisi);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.gridSonucListesi);
            this.splitContainer3.Size = new System.Drawing.Size(1551, 896);
            this.splitContainer3.SplitterDistance = 103;
            this.splitContainer3.TabIndex = 0;
            // 
            // lblKasiyer
            // 
            this.lblKasiyer.AutoSize = true;
            this.lblKasiyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasiyer.ForeColor = System.Drawing.Color.Black;
            this.lblKasiyer.Location = new System.Drawing.Point(11, 9);
            this.lblKasiyer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKasiyer.Name = "lblKasiyer";
            this.lblKasiyer.Size = new System.Drawing.Size(69, 18);
            this.lblKasiyer.TabIndex = 77;
            this.lblKasiyer.Text = "Kasiyer:";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.Color.Black;
            this.lblKullanici.Location = new System.Drawing.Point(78, 11);
            this.lblKullanici.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(71, 16);
            this.lblKullanici.TabIndex = 76;
            this.lblKullanici.Text = "eyupcelix7";
            // 
            // btnPdf
            // 
            this.btnPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPdf.BackColor = System.Drawing.Color.DarkRed;
            this.btnPdf.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPdf.ForeColor = System.Drawing.Color.White;
            this.btnPdf.Image = global::BarkodluMarketProgrami.Properties.Resources.pdf;
            this.btnPdf.Location = new System.Drawing.Point(1439, 20);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(1);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(88, 74);
            this.btnPdf.TabIndex = 75;
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Image = global::BarkodluMarketProgrami.Properties.Resources.excel;
            this.btnExcel.Location = new System.Drawing.Point(1339, 20);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(1);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(88, 74);
            this.btnExcel.TabIndex = 74;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // nudBulunanUrunSayisi
            // 
            this.nudBulunanUrunSayisi.Location = new System.Drawing.Point(210, 50);
            this.nudBulunanUrunSayisi.Name = "nudBulunanUrunSayisi";
            this.nudBulunanUrunSayisi.ReadOnly = true;
            this.nudBulunanUrunSayisi.Size = new System.Drawing.Size(124, 20);
            this.nudBulunanUrunSayisi.TabIndex = 24;
            // 
            // lblBulunanUrunSayisi
            // 
            this.lblBulunanUrunSayisi.AutoSize = true;
            this.lblBulunanUrunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBulunanUrunSayisi.ForeColor = System.Drawing.Color.Black;
            this.lblBulunanUrunSayisi.Location = new System.Drawing.Point(11, 52);
            this.lblBulunanUrunSayisi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBulunanUrunSayisi.Name = "lblBulunanUrunSayisi";
            this.lblBulunanUrunSayisi.Size = new System.Drawing.Size(194, 18);
            this.lblBulunanUrunSayisi.TabIndex = 22;
            this.lblBulunanUrunSayisi.Text = "BULUNAN ÜRÜN SAYISI";
            // 
            // gridSonucListesi
            // 
            this.gridSonucListesi.AllowUserToAddRows = false;
            this.gridSonucListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSonucListesi.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridSonucListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSonucListesi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSonucListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSonucListesi.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSonucListesi.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridSonucListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSonucListesi.EnableHeadersVisualStyles = false;
            this.gridSonucListesi.GridColor = System.Drawing.Color.White;
            this.gridSonucListesi.Location = new System.Drawing.Point(0, 0);
            this.gridSonucListesi.Margin = new System.Windows.Forms.Padding(2);
            this.gridSonucListesi.Name = "gridSonucListesi";
            this.gridSonucListesi.ReadOnly = true;
            this.gridSonucListesi.RowHeadersVisible = false;
            this.gridSonucListesi.RowHeadersWidth = 51;
            this.gridSonucListesi.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridSonucListesi.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridSonucListesi.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.gridSonucListesi.RowTemplate.Height = 32;
            this.gridSonucListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSonucListesi.Size = new System.Drawing.Size(1551, 789);
            this.gridSonucListesi.TabIndex = 3;
            // 
            // FormStokIzleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1860, 896);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormStokIzleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok İzleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormStokIzleme_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.pnlUrunAdi.ResumeLayout(false);
            this.pnlUrunAdi.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudBulunanUrunSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSonucListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblIslemTuru;
        private System.Windows.Forms.Label lblFiltrelemeTuru;
        private System.Windows.Forms.ComboBox cmbIslemTuru;
        private System.Windows.Forms.RadioButton rdbTumu;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.Label lblBitisTarihi;
        private System.Windows.Forms.Label lblBaslangicTarihi;
        private System.Windows.Forms.ComboBox cmbUrunGrubu;
        private System.Windows.Forms.Label lblUrunGrubu;
        private System.Windows.Forms.RadioButton rdbUrunGrubunaGore;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView gridSonucListesi;
        private System.Windows.Forms.NumericUpDown nudBulunanUrunSayisi;
        private System.Windows.Forms.Label lblBulunanUrunSayisi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label lblKasiyer;
        public System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Panel pnlUrunAdi;
        private System.Windows.Forms.CheckBox cbxTumZamanlar;
    }
}