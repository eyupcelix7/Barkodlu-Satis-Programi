namespace BarkodluMarketProgrami
{
    partial class FormVeresiyeRapor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVeresiyeRapor));
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblBitisTarihi = new System.Windows.Forms.Label();
            this.nudTopOdVT = new System.Windows.Forms.NumericUpDown();
            this.lblTopSatVTutar = new System.Windows.Forms.Label();
            this.lblBaslangicTarihi = new System.Windows.Forms.Label();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.rdbOdenilmisV = new System.Windows.Forms.RadioButton();
            this.rdbTumu = new System.Windows.Forms.RadioButton();
            this.rdbOdenilmemisV = new System.Windows.Forms.RadioButton();
            this.lblKasiyer = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblRaporlamaTuru = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nudTopVerVT = new System.Windows.Forms.NumericUpDown();
            this.gridSonucListesi = new System.Windows.Forms.DataGridView();
            this.pnlIstatistik = new System.Windows.Forms.Panel();
            this.lblVeresiyeAl = new System.Windows.Forms.Label();
            this.lblUyari = new System.Windows.Forms.Label();
            this.lblTopAlV = new System.Windows.Forms.Label();
            this.lblTopAlVTutar = new System.Windows.Forms.Label();
            this.nudTopVerV = new System.Windows.Forms.NumericUpDown();
            this.lblVeresiyeVer = new System.Windows.Forms.Label();
            this.lblTopSatV = new System.Windows.Forms.Label();
            this.nudTopOdV = new System.Windows.Forms.NumericUpDown();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnVeresiyeAl = new System.Windows.Forms.Button();
            this.btnVeresiyeVer = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopOdVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopVerVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSonucListesi)).BeginInit();
            this.pnlIstatistik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopVerV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopOdV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBitisTarihi.CalendarForeColor = System.Drawing.Color.Navy;
            this.dtpBitisTarihi.Location = new System.Drawing.Point(242, 117);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(199, 20);
            this.dtpBitisTarihi.TabIndex = 42;
            // 
            // lblBitisTarihi
            // 
            this.lblBitisTarihi.AutoSize = true;
            this.lblBitisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitisTarihi.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblBitisTarihi.Location = new System.Drawing.Point(238, 84);
            this.lblBitisTarihi.Name = "lblBitisTarihi";
            this.lblBitisTarihi.Size = new System.Drawing.Size(107, 24);
            this.lblBitisTarihi.TabIndex = 40;
            this.lblBitisTarihi.Text = "Bitiş Tarihi";
            // 
            // nudTopOdVT
            // 
            this.nudTopOdVT.Location = new System.Drawing.Point(186, 51);
            this.nudTopOdVT.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudTopOdVT.Name = "nudTopOdVT";
            this.nudTopOdVT.ReadOnly = true;
            this.nudTopOdVT.Size = new System.Drawing.Size(90, 20);
            this.nudTopOdVT.TabIndex = 125;
            this.nudTopOdVT.ThousandsSeparator = true;
            // 
            // lblTopSatVTutar
            // 
            this.lblTopSatVTutar.AutoSize = true;
            this.lblTopSatVTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopSatVTutar.ForeColor = System.Drawing.Color.Navy;
            this.lblTopSatVTutar.Location = new System.Drawing.Point(3, 13);
            this.lblTopSatVTutar.Name = "lblTopSatVTutar";
            this.lblTopSatVTutar.Size = new System.Drawing.Size(170, 20);
            this.lblTopSatVTutar.TabIndex = 89;
            this.lblTopSatVTutar.Text = "Toplam Veresiye Tutarı";
            // 
            // lblBaslangicTarihi
            // 
            this.lblBaslangicTarihi.AutoSize = true;
            this.lblBaslangicTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslangicTarihi.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblBaslangicTarihi.Location = new System.Drawing.Point(238, 13);
            this.lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            this.lblBaslangicTarihi.Size = new System.Drawing.Size(159, 24);
            this.lblBaslangicTarihi.TabIndex = 39;
            this.lblBaslangicTarihi.Text = "Başlangıç Tarihi";
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBaslangicTarihi.CalendarForeColor = System.Drawing.Color.Navy;
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(242, 46);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(199, 20);
            this.dtpBaslangicTarihi.TabIndex = 41;
            // 
            // rdbOdenilmisV
            // 
            this.rdbOdenilmisV.AutoSize = true;
            this.rdbOdenilmisV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbOdenilmisV.ForeColor = System.Drawing.Color.Navy;
            this.rdbOdenilmisV.Location = new System.Drawing.Point(14, 133);
            this.rdbOdenilmisV.Name = "rdbOdenilmisV";
            this.rdbOdenilmisV.Size = new System.Drawing.Size(96, 24);
            this.rdbOdenilmisV.TabIndex = 36;
            this.rdbOdenilmisV.Text = "Ödemeler";
            this.rdbOdenilmisV.UseVisualStyleBackColor = true;
            // 
            // rdbTumu
            // 
            this.rdbTumu.AutoSize = true;
            this.rdbTumu.Checked = true;
            this.rdbTumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbTumu.ForeColor = System.Drawing.Color.Navy;
            this.rdbTumu.Location = new System.Drawing.Point(14, 73);
            this.rdbTumu.Name = "rdbTumu";
            this.rdbTumu.Size = new System.Drawing.Size(67, 24);
            this.rdbTumu.TabIndex = 34;
            this.rdbTumu.TabStop = true;
            this.rdbTumu.Text = "Tümü";
            this.rdbTumu.UseVisualStyleBackColor = true;
            // 
            // rdbOdenilmemisV
            // 
            this.rdbOdenilmemisV.AutoSize = true;
            this.rdbOdenilmemisV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbOdenilmemisV.ForeColor = System.Drawing.Color.Navy;
            this.rdbOdenilmemisV.Location = new System.Drawing.Point(14, 103);
            this.rdbOdenilmemisV.Name = "rdbOdenilmemisV";
            this.rdbOdenilmemisV.Size = new System.Drawing.Size(105, 24);
            this.rdbOdenilmemisV.TabIndex = 35;
            this.rdbOdenilmemisV.Text = "Veresiyeler";
            this.rdbOdenilmemisV.UseVisualStyleBackColor = true;
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
            this.lblKasiyer.TabIndex = 75;
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
            this.lblKullanici.TabIndex = 74;
            this.lblKullanici.Text = "eyupcelix7";
            // 
            // lblRaporlamaTuru
            // 
            this.lblRaporlamaTuru.AutoSize = true;
            this.lblRaporlamaTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRaporlamaTuru.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblRaporlamaTuru.Location = new System.Drawing.Point(10, 42);
            this.lblRaporlamaTuru.Name = "lblRaporlamaTuru";
            this.lblRaporlamaTuru.Size = new System.Drawing.Size(160, 24);
            this.lblRaporlamaTuru.TabIndex = 33;
            this.lblRaporlamaTuru.Text = "Raporlama Türü";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // nudTopVerVT
            // 
            this.nudTopVerVT.Location = new System.Drawing.Point(186, 13);
            this.nudTopVerVT.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudTopVerVT.Name = "nudTopVerVT";
            this.nudTopVerVT.ReadOnly = true;
            this.nudTopVerVT.Size = new System.Drawing.Size(90, 20);
            this.nudTopVerVT.TabIndex = 101;
            this.nudTopVerVT.ThousandsSeparator = true;
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
            this.gridSonucListesi.Size = new System.Drawing.Size(1312, 528);
            this.gridSonucListesi.TabIndex = 4;
            this.gridSonucListesi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSonucListesi_CellDoubleClick);
            this.gridSonucListesi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridSonucListesi_CellFormatting);
            // 
            // pnlIstatistik
            // 
            this.pnlIstatistik.Controls.Add(this.lblVeresiyeAl);
            this.pnlIstatistik.Controls.Add(this.lblUyari);
            this.pnlIstatistik.Controls.Add(this.lblTopAlV);
            this.pnlIstatistik.Controls.Add(this.lblTopAlVTutar);
            this.pnlIstatistik.Controls.Add(this.nudTopVerV);
            this.pnlIstatistik.Controls.Add(this.lblVeresiyeVer);
            this.pnlIstatistik.Controls.Add(this.lblTopSatV);
            this.pnlIstatistik.Controls.Add(this.nudTopOdV);
            this.pnlIstatistik.Controls.Add(this.btnPdf);
            this.pnlIstatistik.Controls.Add(this.nudTopOdVT);
            this.pnlIstatistik.Controls.Add(this.lblTopSatVTutar);
            this.pnlIstatistik.Controls.Add(this.btnExcel);
            this.pnlIstatistik.Controls.Add(this.nudTopVerVT);
            this.pnlIstatistik.Controls.Add(this.btnVeresiyeAl);
            this.pnlIstatistik.Controls.Add(this.btnVeresiyeVer);
            this.pnlIstatistik.Location = new System.Drawing.Point(475, 0);
            this.pnlIstatistik.Name = "pnlIstatistik";
            this.pnlIstatistik.Size = new System.Drawing.Size(837, 223);
            this.pnlIstatistik.TabIndex = 88;
            // 
            // lblVeresiyeAl
            // 
            this.lblVeresiyeAl.AutoSize = true;
            this.lblVeresiyeAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeresiyeAl.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblVeresiyeAl.Location = new System.Drawing.Point(490, 145);
            this.lblVeresiyeAl.Name = "lblVeresiyeAl";
            this.lblVeresiyeAl.Size = new System.Drawing.Size(104, 24);
            this.lblVeresiyeAl.TabIndex = 129;
            this.lblVeresiyeAl.Text = "Ödeme Al";
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyari.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUyari.Location = new System.Drawing.Point(4, 175);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(155, 26);
            this.lblUyari.TabIndex = 132;
            this.lblUyari.Text = "(04.06.2025 - 04.07.2025 \r\nARASINDAKİ KAYITLAR)\r\n";
            this.lblUyari.Visible = false;
            // 
            // lblTopAlV
            // 
            this.lblTopAlV.AutoSize = true;
            this.lblTopAlV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopAlV.ForeColor = System.Drawing.Color.Navy;
            this.lblTopAlV.Location = new System.Drawing.Point(3, 125);
            this.lblTopAlV.Name = "lblTopAlV";
            this.lblTopAlV.Size = new System.Drawing.Size(162, 20);
            this.lblTopAlV.TabIndex = 131;
            this.lblTopAlV.Text = "Toplam Ödeme Sayısı";
            // 
            // lblTopAlVTutar
            // 
            this.lblTopAlVTutar.AutoSize = true;
            this.lblTopAlVTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopAlVTutar.ForeColor = System.Drawing.Color.Navy;
            this.lblTopAlVTutar.Location = new System.Drawing.Point(3, 51);
            this.lblTopAlVTutar.Name = "lblTopAlVTutar";
            this.lblTopAlVTutar.Size = new System.Drawing.Size(161, 20);
            this.lblTopAlVTutar.TabIndex = 130;
            this.lblTopAlVTutar.Text = "Toplam Ödeme Tutarı";
            // 
            // nudTopVerV
            // 
            this.nudTopVerV.Location = new System.Drawing.Point(186, 88);
            this.nudTopVerV.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudTopVerV.Name = "nudTopVerV";
            this.nudTopVerV.ReadOnly = true;
            this.nudTopVerV.Size = new System.Drawing.Size(90, 20);
            this.nudTopVerV.TabIndex = 129;
            this.nudTopVerV.ThousandsSeparator = true;
            // 
            // lblVeresiyeVer
            // 
            this.lblVeresiyeVer.AutoSize = true;
            this.lblVeresiyeVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeresiyeVer.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblVeresiyeVer.Location = new System.Drawing.Point(463, 42);
            this.lblVeresiyeVer.Name = "lblVeresiyeVer";
            this.lblVeresiyeVer.Size = new System.Drawing.Size(131, 24);
            this.lblVeresiyeVer.TabIndex = 128;
            this.lblVeresiyeVer.Text = "Veresiye Ver";
            // 
            // lblTopSatV
            // 
            this.lblTopSatV.AutoSize = true;
            this.lblTopSatV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopSatV.ForeColor = System.Drawing.Color.Navy;
            this.lblTopSatV.Location = new System.Drawing.Point(3, 88);
            this.lblTopSatV.Name = "lblTopSatV";
            this.lblTopSatV.Size = new System.Drawing.Size(171, 20);
            this.lblTopSatV.TabIndex = 128;
            this.lblTopSatV.Text = "Toplam Veresiye Sayısı";
            // 
            // nudTopOdV
            // 
            this.nudTopOdV.Location = new System.Drawing.Point(186, 125);
            this.nudTopOdV.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudTopOdV.Name = "nudTopOdV";
            this.nudTopOdV.ReadOnly = true;
            this.nudTopOdV.Size = new System.Drawing.Size(90, 20);
            this.nudTopOdV.TabIndex = 127;
            this.nudTopOdV.ThousandsSeparator = true;
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
            this.btnPdf.Location = new System.Drawing.Point(727, 120);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(1);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(100, 70);
            this.btnPdf.TabIndex = 115;
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
            this.btnExcel.Location = new System.Drawing.Point(727, 20);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(1);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(100, 70);
            this.btnExcel.TabIndex = 114;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnVeresiyeAl
            // 
            this.btnVeresiyeAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.btnVeresiyeAl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.btnVeresiyeAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeresiyeAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeresiyeAl.ForeColor = System.Drawing.Color.White;
            this.btnVeresiyeAl.Image = global::BarkodluMarketProgrami.Properties.Resources.add;
            this.btnVeresiyeAl.Location = new System.Drawing.Point(612, 120);
            this.btnVeresiyeAl.Margin = new System.Windows.Forms.Padding(1);
            this.btnVeresiyeAl.Name = "btnVeresiyeAl";
            this.btnVeresiyeAl.Size = new System.Drawing.Size(100, 70);
            this.btnVeresiyeAl.TabIndex = 109;
            this.btnVeresiyeAl.UseVisualStyleBackColor = false;
            this.btnVeresiyeAl.Click += new System.EventHandler(this.btnVeresiyeAl_Click);
            // 
            // btnVeresiyeVer
            // 
            this.btnVeresiyeVer.BackColor = System.Drawing.Color.DarkRed;
            this.btnVeresiyeVer.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnVeresiyeVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeresiyeVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeresiyeVer.ForeColor = System.Drawing.Color.White;
            this.btnVeresiyeVer.Image = global::BarkodluMarketProgrami.Properties.Resources.add;
            this.btnVeresiyeVer.Location = new System.Drawing.Point(612, 20);
            this.btnVeresiyeVer.Margin = new System.Windows.Forms.Padding(1);
            this.btnVeresiyeVer.Name = "btnVeresiyeVer";
            this.btnVeresiyeVer.Size = new System.Drawing.Size(100, 70);
            this.btnVeresiyeVer.TabIndex = 108;
            this.btnVeresiyeVer.UseVisualStyleBackColor = false;
            this.btnVeresiyeVer.Click += new System.EventHandler(this.btnVeresiyeVer_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlIstatistik);
            this.splitContainer1.Panel1.Controls.Add(this.lblKasiyer);
            this.splitContainer1.Panel1.Controls.Add(this.lblKullanici);
            this.splitContainer1.Panel1.Controls.Add(this.btnAra);
            this.splitContainer1.Panel1.Controls.Add(this.dtpBitisTarihi);
            this.splitContainer1.Panel1.Controls.Add(this.dtpBaslangicTarihi);
            this.splitContainer1.Panel1.Controls.Add(this.lblBitisTarihi);
            this.splitContainer1.Panel1.Controls.Add(this.lblBaslangicTarihi);
            this.splitContainer1.Panel1.Controls.Add(this.rdbOdenilmisV);
            this.splitContainer1.Panel1.Controls.Add(this.rdbOdenilmemisV);
            this.splitContainer1.Panel1.Controls.Add(this.rdbTumu);
            this.splitContainer1.Panel1.Controls.Add(this.lblRaporlamaTuru);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridSonucListesi);
            this.splitContainer1.Size = new System.Drawing.Size(1312, 761);
            this.splitContainer1.SplitterDistance = 229;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAra.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Image = global::BarkodluMarketProgrami.Properties.Resources.searchWhite;
            this.btnAra.Location = new System.Drawing.Point(341, 152);
            this.btnAra.Margin = new System.Windows.Forms.Padding(1);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 50);
            this.btnAra.TabIndex = 43;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // FormVeresiyeRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 761);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVeresiyeRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veresiye Rapor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.nudTopOdVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopVerVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSonucListesi)).EndInit();
            this.pnlIstatistik.ResumeLayout(false);
            this.pnlIstatistik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopVerV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopOdV)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.Label lblBitisTarihi;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.NumericUpDown nudTopOdVT;
        private System.Windows.Forms.Label lblTopSatVTutar;
        private System.Windows.Forms.Label lblBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.RadioButton rdbOdenilmisV;
        private System.Windows.Forms.RadioButton rdbTumu;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.RadioButton rdbOdenilmemisV;
        private System.Windows.Forms.Button btnVeresiyeVer;
        private System.Windows.Forms.Label lblKasiyer;
        private System.Windows.Forms.Button btnVeresiyeAl;
        public System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblRaporlamaTuru;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown nudTopVerVT;
        private System.Windows.Forms.DataGridView gridSonucListesi;
        private System.Windows.Forms.Panel pnlIstatistik;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblVeresiyeAl;
        private System.Windows.Forms.Label lblVeresiyeVer;
        private System.Windows.Forms.NumericUpDown nudTopVerV;
        private System.Windows.Forms.Label lblTopSatV;
        private System.Windows.Forms.NumericUpDown nudTopOdV;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.Label lblTopAlV;
        private System.Windows.Forms.Label lblTopAlVTutar;
    }
}