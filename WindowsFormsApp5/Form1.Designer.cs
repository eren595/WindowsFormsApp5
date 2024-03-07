namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEnDusuk = new System.Windows.Forms.TextBox();
            this.btnAdSoyad = new System.Windows.Forms.TextBox();
            this.btnDersNotu = new System.Windows.Forms.TextBox();
            this.txtEnYuksek = new System.Windows.Forms.TextBox();
            this.txtOltalama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnEnYuksek = new System.Windows.Forms.Button();
            this.btnEnDusuk = new System.Windows.Forms.Button();
            this.txtOrtalama = new System.Windows.Forms.Button();
            this.lbListele = new System.Windows.Forms.Button();
            this.lbListe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtEnDusuk
            // 
            this.txtEnDusuk.Location = new System.Drawing.Point(116, 194);
            this.txtEnDusuk.Name = "txtEnDusuk";
            this.txtEnDusuk.Size = new System.Drawing.Size(100, 20);
            this.txtEnDusuk.TabIndex = 0;
            // 
            // btnAdSoyad
            // 
            this.btnAdSoyad.Location = new System.Drawing.Point(96, 57);
            this.btnAdSoyad.Name = "btnAdSoyad";
            this.btnAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.btnAdSoyad.TabIndex = 1;
            // 
            // btnDersNotu
            // 
            this.btnDersNotu.Location = new System.Drawing.Point(96, 89);
            this.btnDersNotu.Name = "btnDersNotu";
            this.btnDersNotu.Size = new System.Drawing.Size(100, 20);
            this.btnDersNotu.TabIndex = 2;
            // 
            // txtEnYuksek
            // 
            this.txtEnYuksek.Location = new System.Drawing.Point(116, 166);
            this.txtEnYuksek.Name = "txtEnYuksek";
            this.txtEnYuksek.Size = new System.Drawing.Size(100, 20);
            this.txtEnYuksek.TabIndex = 3;
            // 
            // txtOltalama
            // 
            this.txtOltalama.Location = new System.Drawing.Point(116, 223);
            this.txtOltalama.Name = "txtOltalama";
            this.txtOltalama.Size = new System.Drawing.Size(100, 20);
            this.txtOltalama.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "AD Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ders Notu:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(35, 134);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnEnYuksek
            // 
            this.btnEnYuksek.Location = new System.Drawing.Point(35, 163);
            this.btnEnYuksek.Name = "btnEnYuksek";
            this.btnEnYuksek.Size = new System.Drawing.Size(75, 23);
            this.btnEnYuksek.TabIndex = 8;
            this.btnEnYuksek.Text = "En Yüksek";
            this.btnEnYuksek.UseVisualStyleBackColor = true;
            this.btnEnYuksek.Click += new System.EventHandler(this.btnEnYuksek_Click);
            // 
            // btnEnDusuk
            // 
            this.btnEnDusuk.Location = new System.Drawing.Point(35, 192);
            this.btnEnDusuk.Name = "btnEnDusuk";
            this.btnEnDusuk.Size = new System.Drawing.Size(75, 23);
            this.btnEnDusuk.TabIndex = 9;
            this.btnEnDusuk.Text = "En Düşük";
            this.btnEnDusuk.UseVisualStyleBackColor = true;
            this.btnEnDusuk.Click += new System.EventHandler(this.btnEnDusuk_Click);
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(35, 221);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(75, 23);
            this.txtOrtalama.TabIndex = 10;
            this.txtOrtalama.Text = "Ortalama";
            this.txtOrtalama.UseVisualStyleBackColor = true;
            this.txtOrtalama.Click += new System.EventHandler(this.btnOltalama_Click);
            // 
            // lbListele
            // 
            this.lbListele.Location = new System.Drawing.Point(373, 220);
            this.lbListele.Name = "lbListele";
            this.lbListele.Size = new System.Drawing.Size(75, 23);
            this.lbListele.TabIndex = 11;
            this.lbListele.Text = "Listere";
            this.lbListele.UseVisualStyleBackColor = true;
            this.lbListele.Click += new System.EventHandler(this.btnListere_Click);
            // 
            // lbListe
            // 
            this.lbListe.FormattingEnabled = true;
            this.lbListe.Location = new System.Drawing.Point(247, 70);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(120, 173);
            this.lbListe.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.lbListele);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.btnEnDusuk);
            this.Controls.Add(this.btnEnYuksek);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOltalama);
            this.Controls.Add(this.txtEnYuksek);
            this.Controls.Add(this.btnDersNotu);
            this.Controls.Add(this.btnAdSoyad);
            this.Controls.Add(this.txtEnDusuk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnDusuk;
        private System.Windows.Forms.TextBox btnAdSoyad;
        private System.Windows.Forms.TextBox btnDersNotu;
        private System.Windows.Forms.TextBox txtEnYuksek;
        private System.Windows.Forms.TextBox txtOltalama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnEnYuksek;
        private System.Windows.Forms.Button btnEnDusuk;
        private System.Windows.Forms.Button txtOrtalama;
        private System.Windows.Forms.Button lbListele;
        private System.Windows.Forms.ListBox lbListe;
    }
}

