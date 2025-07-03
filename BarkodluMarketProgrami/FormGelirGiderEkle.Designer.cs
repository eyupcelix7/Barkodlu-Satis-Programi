namespace BarkodluMarketProgrami
{
    partial class FormGelirGiderEkle
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
            this.lblGelirGider = new System.Windows.Forms.Label();
            this.lblOdemeTuru = new System.Windows.Forms.Label();
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.lblNakit = new System.Windows.Forms.Label();
            this.lblKart = new System.Windows.Forms.Label();
            this.nudKart = new System.Windows.Forms.NumericUpDown();
            this.nudNakit = new System.Windows.Forms.NumericUpDown();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKasiyer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudKart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNakit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGelirGider
            // 
            this.lblGelirGider.AutoSize = true;
            this.lblGelirGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelirGider.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblGelirGider.Location = new System.Drawing.Point(11, 9);
            this.lblGelirGider.Name = "lblGelirGider";
            this.lblGelirGider.Size = new System.Drawing.Size(141, 25);
            this.lblGelirGider.TabIndex = 34;
            this.lblGelirGider.Text = "Gelir - Gider";
            // 
            // lblOdemeTuru
            // 
            this.lblOdemeTuru.AutoSize = true;
            this.lblOdemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeTuru.ForeColor = System.Drawing.Color.Navy;
            this.lblOdemeTuru.Location = new System.Drawing.Point(13, 59);
            this.lblOdemeTuru.Name = "lblOdemeTuru";
            this.lblOdemeTuru.Size = new System.Drawing.Size(129, 24);
            this.lblOdemeTuru.TabIndex = 35;
            this.lblOdemeTuru.Text = "Ödeme Türü";
            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Items.AddRange(new object[] {
            "Nakit",
            "Kart",
            "Kart-Nakit"});
            this.cmbOdemeTuru.Location = new System.Drawing.Point(17, 86);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(229, 28);
            this.cmbOdemeTuru.TabIndex = 36;
            this.cmbOdemeTuru.SelectedIndexChanged += new System.EventHandler(this.cmbOdemeTuru_SelectedIndexChanged);
            // 
            // lblNakit
            // 
            this.lblNakit.AutoSize = true;
            this.lblNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNakit.ForeColor = System.Drawing.Color.Navy;
            this.lblNakit.Location = new System.Drawing.Point(12, 131);
            this.lblNakit.Name = "lblNakit";
            this.lblNakit.Size = new System.Drawing.Size(56, 24);
            this.lblNakit.TabIndex = 37;
            this.lblNakit.Text = "Nakit";
            // 
            // lblKart
            // 
            this.lblKart.AutoSize = true;
            this.lblKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKart.ForeColor = System.Drawing.Color.Navy;
            this.lblKart.Location = new System.Drawing.Point(136, 131);
            this.lblKart.Name = "lblKart";
            this.lblKart.Size = new System.Drawing.Size(46, 24);
            this.lblKart.TabIndex = 38;
            this.lblKart.Text = "Kart";
            // 
            // nudKart
            // 
            this.nudKart.DecimalPlaces = 2;
            this.nudKart.Location = new System.Drawing.Point(140, 158);
            this.nudKart.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudKart.Name = "nudKart";
            this.nudKart.Size = new System.Drawing.Size(106, 20);
            this.nudKart.TabIndex = 40;
            // 
            // nudNakit
            // 
            this.nudNakit.DecimalPlaces = 2;
            this.nudNakit.Location = new System.Drawing.Point(18, 158);
            this.nudNakit.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudNakit.Name = "nudNakit";
            this.nudNakit.Size = new System.Drawing.Size(116, 20);
            this.nudNakit.TabIndex = 41;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.Navy;
            this.lblAciklama.Location = new System.Drawing.Point(14, 190);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(94, 24);
            this.lblAciklama.TabIndex = 42;
            this.lblAciklama.Text = "Açıklama";
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbAciklama.Location = new System.Drawing.Point(18, 217);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.Size = new System.Drawing.Size(228, 136);
            this.rtbAciklama.TabIndex = 43;
            this.rtbAciklama.Text = "";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.Navy;
            this.lblTarih.Location = new System.Drawing.Point(14, 370);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(58, 24);
            this.lblTarih.TabIndex = 44;
            this.lblTarih.Text = "Tarih";
            // 
            // dtpTarih
            // 
            this.dtpTarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(18, 397);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(228, 20);
            this.dtpTarih.TabIndex = 45;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(18, 448);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(1);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(126, 56);
            this.btnEkle.TabIndex = 46;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(342, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 77;
            this.label1.Text = "Kasiyer:";
            // 
            // lblKasiyer
            // 
            this.lblKasiyer.AutoSize = true;
            this.lblKasiyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasiyer.ForeColor = System.Drawing.Color.Black;
            this.lblKasiyer.Location = new System.Drawing.Point(409, 9);
            this.lblKasiyer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKasiyer.Name = "lblKasiyer";
            this.lblKasiyer.Size = new System.Drawing.Size(71, 16);
            this.lblKasiyer.TabIndex = 76;
            this.lblKasiyer.Text = "eyupcelix7";
            // 
            // FormGelirGiderEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(491, 537);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKasiyer);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.rtbAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.nudNakit);
            this.Controls.Add(this.nudKart);
            this.Controls.Add(this.lblKart);
            this.Controls.Add(this.lblNakit);
            this.Controls.Add(this.cmbOdemeTuru);
            this.Controls.Add(this.lblOdemeTuru);
            this.Controls.Add(this.lblGelirGider);
            this.MaximumSize = new System.Drawing.Size(507, 576);
            this.MinimumSize = new System.Drawing.Size(507, 576);
            this.Name = "FormGelirGiderEkle";
            this.Text = "Gelir Ekle";
            this.Load += new System.EventHandler(this.FormGelirGiderEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNakit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGelirGider;
        private System.Windows.Forms.Label lblOdemeTuru;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private System.Windows.Forms.Label lblNakit;
        private System.Windows.Forms.Label lblKart;
        private System.Windows.Forms.NumericUpDown nudKart;
        private System.Windows.Forms.NumericUpDown nudNakit;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.RichTextBox rtbAciklama;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblKasiyer;
    }
}