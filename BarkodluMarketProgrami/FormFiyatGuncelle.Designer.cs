namespace BarkodluMarketProgrami
{
    partial class FormFiyatGuncelle
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblKasiyer = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.nudGuncelFiyatSonuc = new System.Windows.Forms.NumericUpDown();
            this.nudYeniFiyatSonuc = new System.Windows.Forms.NumericUpDown();
            this.lblYeniFiyat = new System.Windows.Forms.Label();
            this.lblGuncelFiyatSonuc = new System.Windows.Forms.Label();
            this.txtUrunAdiSonuc = new System.Windows.Forms.TextBox();
            this.lblUrunAdiSonuc = new System.Windows.Forms.Label();
            this.txtBarkodSonuc = new System.Windows.Forms.TextBox();
            this.lblBarkodSonuc = new System.Windows.Forms.Label();
            this.btnUrunuGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuncelFiyatSonuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYeniFiyatSonuc)).BeginInit();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.splitContainer1.Panel1.Controls.Add(this.lblKasiyer);
            this.splitContainer1.Panel1.Controls.Add(this.lblKullanici);
            this.splitContainer1.Panel1.Controls.Add(this.txtBarkod);
            this.splitContainer1.Panel1.Controls.Add(this.lblBarkod);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnUrunuGuncelle);
            this.splitContainer1.Panel2.Controls.Add(this.nudGuncelFiyatSonuc);
            this.splitContainer1.Panel2.Controls.Add(this.nudYeniFiyatSonuc);
            this.splitContainer1.Panel2.Controls.Add(this.lblYeniFiyat);
            this.splitContainer1.Panel2.Controls.Add(this.lblGuncelFiyatSonuc);
            this.splitContainer1.Panel2.Controls.Add(this.txtUrunAdiSonuc);
            this.splitContainer1.Panel2.Controls.Add(this.lblUrunAdiSonuc);
            this.splitContainer1.Panel2.Controls.Add(this.txtBarkodSonuc);
            this.splitContainer1.Panel2.Controls.Add(this.lblBarkodSonuc);
            this.splitContainer1.Size = new System.Drawing.Size(491, 537);
            this.splitContainer1.SplitterDistance = 121;
            this.splitContainer1.TabIndex = 1;
            // 
            // lblKasiyer
            // 
            this.lblKasiyer.AutoSize = true;
            this.lblKasiyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasiyer.ForeColor = System.Drawing.Color.Black;
            this.lblKasiyer.Location = new System.Drawing.Point(11, 10);
            this.lblKasiyer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKasiyer.Name = "lblKasiyer";
            this.lblKasiyer.Size = new System.Drawing.Size(69, 18);
            this.lblKasiyer.TabIndex = 79;
            this.lblKasiyer.Text = "Kasiyer:";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.Color.Black;
            this.lblKullanici.Location = new System.Drawing.Point(78, 12);
            this.lblKullanici.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(71, 16);
            this.lblKullanici.TabIndex = 78;
            this.lblKullanici.Text = "eyupcelix7";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(77, 49);
            this.txtBarkod.Margin = new System.Windows.Forms.Padding(2);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(225, 23);
            this.txtBarkod.TabIndex = 5;
            this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyDown);
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarkod.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblBarkod.Location = new System.Drawing.Point(11, 52);
            this.lblBarkod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(62, 18);
            this.lblBarkod.TabIndex = 4;
            this.lblBarkod.Text = "Barkod";
            // 
            // nudGuncelFiyatSonuc
            // 
            this.nudGuncelFiyatSonuc.DecimalPlaces = 2;
            this.nudGuncelFiyatSonuc.Location = new System.Drawing.Point(118, 124);
            this.nudGuncelFiyatSonuc.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudGuncelFiyatSonuc.Name = "nudGuncelFiyatSonuc";
            this.nudGuncelFiyatSonuc.Size = new System.Drawing.Size(114, 20);
            this.nudGuncelFiyatSonuc.TabIndex = 20;
            // 
            // nudYeniFiyatSonuc
            // 
            this.nudYeniFiyatSonuc.DecimalPlaces = 2;
            this.nudYeniFiyatSonuc.Location = new System.Drawing.Point(118, 182);
            this.nudYeniFiyatSonuc.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudYeniFiyatSonuc.Name = "nudYeniFiyatSonuc";
            this.nudYeniFiyatSonuc.Size = new System.Drawing.Size(114, 20);
            this.nudYeniFiyatSonuc.TabIndex = 19;
            // 
            // lblYeniFiyat
            // 
            this.lblYeniFiyat.AutoSize = true;
            this.lblYeniFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniFiyat.ForeColor = System.Drawing.Color.Navy;
            this.lblYeniFiyat.Location = new System.Drawing.Point(11, 181);
            this.lblYeniFiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYeniFiyat.Name = "lblYeniFiyat";
            this.lblYeniFiyat.Size = new System.Drawing.Size(81, 18);
            this.lblYeniFiyat.TabIndex = 18;
            this.lblYeniFiyat.Text = "Yeni Fiyat";
            // 
            // lblGuncelFiyatSonuc
            // 
            this.lblGuncelFiyatSonuc.AutoSize = true;
            this.lblGuncelFiyatSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuncelFiyatSonuc.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblGuncelFiyatSonuc.Location = new System.Drawing.Point(11, 123);
            this.lblGuncelFiyatSonuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuncelFiyatSonuc.Name = "lblGuncelFiyatSonuc";
            this.lblGuncelFiyatSonuc.Size = new System.Drawing.Size(102, 18);
            this.lblGuncelFiyatSonuc.TabIndex = 14;
            this.lblGuncelFiyatSonuc.Text = "Güncel Fiyat";
            // 
            // txtUrunAdiSonuc
            // 
            this.txtUrunAdiSonuc.Enabled = false;
            this.txtUrunAdiSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdiSonuc.Location = new System.Drawing.Point(118, 80);
            this.txtUrunAdiSonuc.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrunAdiSonuc.Name = "txtUrunAdiSonuc";
            this.txtUrunAdiSonuc.Size = new System.Drawing.Size(225, 23);
            this.txtUrunAdiSonuc.TabIndex = 13;
            // 
            // lblUrunAdiSonuc
            // 
            this.lblUrunAdiSonuc.AutoSize = true;
            this.lblUrunAdiSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdiSonuc.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblUrunAdiSonuc.Location = new System.Drawing.Point(11, 80);
            this.lblUrunAdiSonuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrunAdiSonuc.Name = "lblUrunAdiSonuc";
            this.lblUrunAdiSonuc.Size = new System.Drawing.Size(72, 18);
            this.lblUrunAdiSonuc.TabIndex = 12;
            this.lblUrunAdiSonuc.Text = "Ürün Adı";
            // 
            // txtBarkodSonuc
            // 
            this.txtBarkodSonuc.Enabled = false;
            this.txtBarkodSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodSonuc.Location = new System.Drawing.Point(118, 30);
            this.txtBarkodSonuc.Margin = new System.Windows.Forms.Padding(2);
            this.txtBarkodSonuc.Name = "txtBarkodSonuc";
            this.txtBarkodSonuc.Size = new System.Drawing.Size(225, 23);
            this.txtBarkodSonuc.TabIndex = 11;
            // 
            // lblBarkodSonuc
            // 
            this.lblBarkodSonuc.AutoSize = true;
            this.lblBarkodSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarkodSonuc.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblBarkodSonuc.Location = new System.Drawing.Point(11, 33);
            this.lblBarkodSonuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarkodSonuc.Name = "lblBarkodSonuc";
            this.lblBarkodSonuc.Size = new System.Drawing.Size(62, 18);
            this.lblBarkodSonuc.TabIndex = 10;
            this.lblBarkodSonuc.Text = "Barkod";
            // 
            // btnUrunuGuncelle
            // 
            this.btnUrunuGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunuGuncelle.AutoSize = true;
            this.btnUrunuGuncelle.BackColor = System.Drawing.Color.Navy;
            this.btnUrunuGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnUrunuGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunuGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunuGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnUrunuGuncelle.Image = global::BarkodluMarketProgrami.Properties.Resources.searchWhite;
            this.btnUrunuGuncelle.Location = new System.Drawing.Point(14, 238);
            this.btnUrunuGuncelle.Margin = new System.Windows.Forms.Padding(1);
            this.btnUrunuGuncelle.Name = "btnUrunuGuncelle";
            this.btnUrunuGuncelle.Padding = new System.Windows.Forms.Padding(2);
            this.btnUrunuGuncelle.Size = new System.Drawing.Size(155, 44);
            this.btnUrunuGuncelle.TabIndex = 80;
            this.btnUrunuGuncelle.Text = "Ürünü Güncelle";
            this.btnUrunuGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUrunuGuncelle.UseVisualStyleBackColor = false;
            this.btnUrunuGuncelle.Click += new System.EventHandler(this.btnUrunuGuncelle_Click);
            // 
            // FormFiyatGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 537);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormFiyatGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiyat Güncelle";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudGuncelFiyatSonuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYeniFiyatSonuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.Label lblYeniFiyat;
        private System.Windows.Forms.Label lblGuncelFiyatSonuc;
        private System.Windows.Forms.TextBox txtUrunAdiSonuc;
        private System.Windows.Forms.Label lblUrunAdiSonuc;
        private System.Windows.Forms.TextBox txtBarkodSonuc;
        private System.Windows.Forms.Label lblBarkodSonuc;
        private System.Windows.Forms.NumericUpDown nudGuncelFiyatSonuc;
        private System.Windows.Forms.NumericUpDown nudYeniFiyatSonuc;
        private System.Windows.Forms.Label lblKasiyer;
        public System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Button btnUrunuGuncelle;
    }
}