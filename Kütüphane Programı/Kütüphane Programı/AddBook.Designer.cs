
namespace Kütüphane_Programı
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.pageCountTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.bookTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.teminTypeComboBox = new System.Windows.Forms.ComboBox();
            this.teminDatePicker = new System.Windows.Forms.DateTimePicker();
            this.donatorTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.stokCountTextBox = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.stokCountTextBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.BackColor = System.Drawing.Color.Silver;
            this.isbnTextBox.Location = new System.Drawing.Point(108, 11);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(150, 20);
            this.isbnTextBox.TabIndex = 0;
            this.isbnTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isbnTextBox_KeyPress);
            // 
            // authorTextBox
            // 
            this.authorTextBox.BackColor = System.Drawing.Color.Silver;
            this.authorTextBox.Location = new System.Drawing.Point(108, 63);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(150, 20);
            this.authorTextBox.TabIndex = 2;
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.BackColor = System.Drawing.Color.Silver;
            this.bookNameTextBox.Location = new System.Drawing.Point(108, 37);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.bookNameTextBox.TabIndex = 1;
            // 
            // pageCountTextBox
            // 
            this.pageCountTextBox.BackColor = System.Drawing.Color.Silver;
            this.pageCountTextBox.Location = new System.Drawing.Point(108, 89);
            this.pageCountTextBox.Name = "pageCountTextBox";
            this.pageCountTextBox.Size = new System.Drawing.Size(150, 20);
            this.pageCountTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Colonna MT", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(74, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Kamera İle ISBN Okut";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ISBN Numarası :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.BackColor = System.Drawing.Color.Silver;
            this.publisherTextBox.Location = new System.Drawing.Point(108, 115);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(150, 20);
            this.publisherTextBox.TabIndex = 4;
            // 
            // bookTypeComboBox
            // 
            this.bookTypeComboBox.BackColor = System.Drawing.Color.Silver;
            this.bookTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookTypeComboBox.FormattingEnabled = true;
            this.bookTypeComboBox.Items.AddRange(new object[] {
            "Aile",
            "Anı-Mektup-Günlük",
            "Anlatı",
            "Antoloji",
            "Antropoloji-Etnoloji",
            "Araştırma-İnceleme",
            "Aşk",
            "Astroloji-Fal-Rüya Tabirleri",
            "Bilgisayar-İnternet",
            "Bilim-Kurgu",
            "Bilim-Teknoloji-Mühendislik",
            "Biyografi",
            "Çizgi-Roman",
            "Çocuk",
            "Deneme-İnceleme",
            "Dergi",
            "Ders Kitapları",
            "Diğer İnançlar",
            "Dilbilimi-Etimoloji",
            "Din",
            "Dünya Klasikleri",
            "Edebiyat",
            "Efsaneler-Destanlar",
            "Eğitim",
            "Eğlence-Mizah",
            "Ekoloji",
            "Ekonomi-Emek-İş Dünyası",
            "Eleştiri-Kuram",
            "Fantastik",
            "Felsefe-Düşünce",
            "Gençlik",
            "Gezi",
            "Halk Edebiyatı",
            "Hikaye",
            "Hobi",
            "Hukuk",
            "İletişim-Medya",
            "İnsan ve Toplum",
            "Kadın",
            "Kadın-Erkek",
            "Kişisel Gelişim",
            "Korku-Gerilim",
            "Kültür",
            "Macera-Aksiyon",
            "Manga",
            "Masal",
            "Mitolojiler",
            "Moda",
            "Müzik",
            "Özlü Sözler-Duvar Yazıları",
            "Parapsikoloji-Spiritüalizm",
            "Psikoloji",
            "Roman",
            "Sağlık-Tıp",
            "Sanat",
            "Senaryo-Oyun",
            "Şiir",
            "Sinema",
            "Siyaset-Politika",
            "Sosyoloji",
            "Söyleşi-Röportaj",
            "Sözlük-Kılavuz Kitap-Ansiklopedi",
            "Spor",
            "Tarih",
            "Tasavvuf-Meshepler-Tarikatlar",
            "Tiyatro",
            "Türk Klasikleri",
            "Temek",
            "Yeraltı Edebiyatı",
            "Diğer"});
            this.bookTypeComboBox.Location = new System.Drawing.Point(366, 10);
            this.bookTypeComboBox.Name = "bookTypeComboBox";
            this.bookTypeComboBox.Size = new System.Drawing.Size(150, 21);
            this.bookTypeComboBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kitap Adı :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazar :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sayfa Sayısı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Yayın Evi :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(270, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kitap Türü :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(270, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Temin Türü :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(270, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Temin Tarihi :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teminTypeComboBox
            // 
            this.teminTypeComboBox.BackColor = System.Drawing.Color.Silver;
            this.teminTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teminTypeComboBox.FormattingEnabled = true;
            this.teminTypeComboBox.Items.AddRange(new object[] {
            "Bağış",
            "Satın Alma",
            "Diğer"});
            this.teminTypeComboBox.Location = new System.Drawing.Point(366, 36);
            this.teminTypeComboBox.Name = "teminTypeComboBox";
            this.teminTypeComboBox.Size = new System.Drawing.Size(150, 21);
            this.teminTypeComboBox.TabIndex = 6;
            // 
            // teminDatePicker
            // 
            this.teminDatePicker.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.teminDatePicker.Location = new System.Drawing.Point(366, 63);
            this.teminDatePicker.Name = "teminDatePicker";
            this.teminDatePicker.Size = new System.Drawing.Size(150, 20);
            this.teminDatePicker.TabIndex = 7;
            // 
            // donatorTextBox
            // 
            this.donatorTextBox.BackColor = System.Drawing.Color.Silver;
            this.donatorTextBox.Location = new System.Drawing.Point(366, 89);
            this.donatorTextBox.Name = "donatorTextBox";
            this.donatorTextBox.Size = new System.Drawing.Size(150, 20);
            this.donatorTextBox.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(270, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Bağışlayan Kişi :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(270, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Stok Sayısı :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Control;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Colonna MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addButton.Location = new System.Drawing.Point(410, 150);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(122, 37);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "EKLE";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.BackColor = System.Drawing.SystemColors.Control;
            this.cleanButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cleanButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cleanButton.Font = new System.Drawing.Font("Colonna MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cleanButton.Location = new System.Drawing.Point(282, 150);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(122, 37);
            this.cleanButton.TabIndex = 13;
            this.cleanButton.Text = "Girdileri Temizle";
            this.cleanButton.UseVisualStyleBackColor = false;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // stokCountTextBox
            // 
            this.stokCountTextBox.BackColor = System.Drawing.Color.Silver;
            this.stokCountTextBox.Location = new System.Drawing.Point(366, 115);
            this.stokCountTextBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.stokCountTextBox.Name = "stokCountTextBox";
            this.stokCountTextBox.Size = new System.Drawing.Size(150, 20);
            this.stokCountTextBox.TabIndex = 9;
            this.stokCountTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Colonna MT", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(165, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "Barkod Okuyucu İle ISBN Okut";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(6, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 37);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Otomatik Doldur";
            this.toolTip1.SetToolTip(this.checkBox1, "Bu seçenek işartelendiğinde okunan ISBN numarası Google Books veritabanında arana" +
        "rak kitap bilgileri otomatik olarak doldurulur (İnternet bağlantısı gerektirir)");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(4, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 52);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // AddBook
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.CancelButton = this.cleanButton;
            this.ClientSize = new System.Drawing.Size(536, 197);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stokCountTextBox);
            this.Controls.Add(this.teminDatePicker);
            this.Controls.Add(this.teminTypeComboBox);
            this.Controls.Add(this.bookTypeComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.donatorTextBox);
            this.Controls.Add(this.pageCountTextBox);
            this.Controls.Add(this.bookNameTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.isbnTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddBook";
            this.Text = "Kitap Ekle";
            this.Load += new System.EventHandler(this.KitapEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stokCountTextBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.TextBox pageCountTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.ComboBox bookTypeComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox teminTypeComboBox;
        private System.Windows.Forms.DateTimePicker teminDatePicker;
        private System.Windows.Forms.TextBox donatorTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.NumericUpDown stokCountTextBox;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}