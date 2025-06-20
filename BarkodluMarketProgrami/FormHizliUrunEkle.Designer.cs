namespace BarkodluMarketProgrami
{
    partial class FormHizliUrunEkle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.gridUrunListesi = new System.Windows.Forms.DataGridView();
            this.urunBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.button27);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel1.Controls.Add(this.txtUrunAd);
            this.splitContainer1.Panel1.Controls.Add(this.lblUrunAd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridUrunListesi);
            this.splitContainer1.Size = new System.Drawing.Size(491, 537);
            this.splitContainer1.SplitterDistance = 121;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::BarkodluMarketProgrami.Properties.Resources.searchWhite;
            this.button1.Location = new System.Drawing.Point(10, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2);
            this.button1.Size = new System.Drawing.Size(113, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ürün Ara";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            this.button27.AutoSize = true;
            this.button27.BackColor = System.Drawing.Color.OrangeRed;
            this.button27.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button27.ForeColor = System.Drawing.Color.White;
            this.button27.Image = global::BarkodluMarketProgrami.Properties.Resources.cancelWhite;
            this.button27.Location = new System.Drawing.Point(131, 65);
            this.button27.Margin = new System.Windows.Forms.Padding(1);
            this.button27.Name = "button27";
            this.button27.Padding = new System.Windows.Forms.Padding(2);
            this.button27.Size = new System.Drawing.Size(105, 44);
            this.button27.TabIndex = 8;
            this.button27.Text = "Temizle";
            this.button27.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button27.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.checkBox1.Location = new System.Drawing.Point(374, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Tümünü Ara";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAd.Location = new System.Drawing.Point(83, 20);
            this.txtUrunAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(225, 23);
            this.txtUrunAd.TabIndex = 5;
            this.txtUrunAd.TextChanged += new System.EventHandler(this.txtUrunAd_TextChanged);
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAd.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblUrunAd.Location = new System.Drawing.Point(7, 23);
            this.lblUrunAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(72, 18);
            this.lblUrunAd.TabIndex = 4;
            this.lblUrunAd.Text = "Ürün Adı";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUrunListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUrunListesi.ColumnHeadersHeight = 29;
            this.gridUrunListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunBarkod,
            this.urunAdi,
            this.urunBirim,
            this.urunMiktar,
            this.urunFiyat});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUrunListesi.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridUrunListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUrunListesi.EnableHeadersVisualStyles = false;
            this.gridUrunListesi.GridColor = System.Drawing.Color.White;
            this.gridUrunListesi.Location = new System.Drawing.Point(0, 0);
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
            this.gridUrunListesi.Size = new System.Drawing.Size(491, 412);
            this.gridUrunListesi.TabIndex = 2;
            this.gridUrunListesi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUrunListesi_CellContentDoubleClick);
            // 
            // urunBarkod
            // 
            this.urunBarkod.HeaderText = "Barkod";
            this.urunBarkod.MinimumWidth = 6;
            this.urunBarkod.Name = "urunBarkod";
            this.urunBarkod.ReadOnly = true;
            // 
            // urunAdi
            // 
            this.urunAdi.HeaderText = "Ürün";
            this.urunAdi.MinimumWidth = 6;
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.ReadOnly = true;
            // 
            // urunBirim
            // 
            this.urunBirim.HeaderText = "Birim";
            this.urunBirim.MinimumWidth = 6;
            this.urunBirim.Name = "urunBirim";
            this.urunBirim.ReadOnly = true;
            // 
            // urunMiktar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.urunMiktar.DefaultCellStyle = dataGridViewCellStyle2;
            this.urunMiktar.HeaderText = "Miktar";
            this.urunMiktar.MinimumWidth = 6;
            this.urunMiktar.Name = "urunMiktar";
            this.urunMiktar.ReadOnly = true;
            // 
            // urunFiyat
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            this.urunFiyat.DefaultCellStyle = dataGridViewCellStyle3;
            this.urunFiyat.HeaderText = "Fiyat";
            this.urunFiyat.MinimumWidth = 6;
            this.urunFiyat.Name = "urunFiyat";
            this.urunFiyat.ReadOnly = true;
            // 
            // FormHizliUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 537);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormHizliUrunEkle";
            this.Text = "Hızlı Ürün Ekle";
            this.Load += new System.EventHandler(this.FormHizliUrunEkle_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView gridUrunListesi;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunBirim;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunFiyat;
    }
}