
namespace Kütüphane_Programı
{
    partial class EditBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBook));
            this.stokCountTextBox = new System.Windows.Forms.NumericUpDown();
            this.teminDatePicker = new System.Windows.Forms.DateTimePicker();
            this.teminTypeComboBox = new System.Windows.Forms.ComboBox();
            this.bookTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cleanButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.donatorTextBox = new System.Windows.Forms.TextBox();
            this.pageCountTextBox = new System.Windows.Forms.TextBox();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.stokCountTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // stokCountTextBox
            // 
            this.stokCountTextBox.BackColor = System.Drawing.Color.Silver;
            this.stokCountTextBox.Location = new System.Drawing.Point(367, 114);
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
            // teminDatePicker
            // 
            this.teminDatePicker.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.teminDatePicker.Location = new System.Drawing.Point(367, 62);
            this.teminDatePicker.Name = "teminDatePicker";
            this.teminDatePicker.Size = new System.Drawing.Size(150, 20);
            this.teminDatePicker.TabIndex = 7;
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
            this.teminTypeComboBox.Location = new System.Drawing.Point(367, 35);
            this.teminTypeComboBox.Name = "teminTypeComboBox";
            this.teminTypeComboBox.Size = new System.Drawing.Size(150, 21);
            this.teminTypeComboBox.TabIndex = 6;
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
            this.bookTypeComboBox.Location = new System.Drawing.Point(367, 9);
            this.bookTypeComboBox.Name = "bookTypeComboBox";
            this.bookTypeComboBox.Size = new System.Drawing.Size(150, 21);
            this.bookTypeComboBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Yayın Evi :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(271, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Stok Sayısı :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(271, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Bağışlayan Kişi :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Sayfa Sayısı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Yazar :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(271, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Temin Tarihi :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(13, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Kitap Adı :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(271, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Temin Türü :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(271, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kitap Türü :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ISBN Numarası :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cleanButton
            // 
            this.cleanButton.BackColor = System.Drawing.SystemColors.Control;
            this.cleanButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cleanButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cleanButton.Font = new System.Drawing.Font("Colonna MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cleanButton.Location = new System.Drawing.Point(12, 155);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(122, 37);
            this.cleanButton.TabIndex = 10;
            this.cleanButton.Text = "Girdileri Temizle";
            this.cleanButton.UseVisualStyleBackColor = false;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Colonna MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.Location = new System.Drawing.Point(395, 155);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(122, 37);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "KAYDET";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.BackColor = System.Drawing.Color.Silver;
            this.publisherTextBox.Location = new System.Drawing.Point(109, 114);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(150, 20);
            this.publisherTextBox.TabIndex = 4;
            // 
            // donatorTextBox
            // 
            this.donatorTextBox.BackColor = System.Drawing.Color.Silver;
            this.donatorTextBox.Location = new System.Drawing.Point(367, 88);
            this.donatorTextBox.Name = "donatorTextBox";
            this.donatorTextBox.Size = new System.Drawing.Size(150, 20);
            this.donatorTextBox.TabIndex = 8;
            // 
            // pageCountTextBox
            // 
            this.pageCountTextBox.BackColor = System.Drawing.Color.Silver;
            this.pageCountTextBox.Location = new System.Drawing.Point(109, 88);
            this.pageCountTextBox.Name = "pageCountTextBox";
            this.pageCountTextBox.Size = new System.Drawing.Size(150, 20);
            this.pageCountTextBox.TabIndex = 3;
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.BackColor = System.Drawing.Color.Silver;
            this.bookNameTextBox.Location = new System.Drawing.Point(109, 36);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.bookNameTextBox.TabIndex = 1;
            // 
            // authorTextBox
            // 
            this.authorTextBox.BackColor = System.Drawing.Color.Silver;
            this.authorTextBox.Location = new System.Drawing.Point(109, 62);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(150, 20);
            this.authorTextBox.TabIndex = 2;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.BackColor = System.Drawing.Color.Silver;
            this.isbnTextBox.Location = new System.Drawing.Point(109, 10);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(150, 20);
            this.isbnTextBox.TabIndex = 0;
            // 
            // EditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(536, 200);
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
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.donatorTextBox);
            this.Controls.Add(this.pageCountTextBox);
            this.Controls.Add(this.bookNameTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.isbnTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditBook";
            this.Text = "Kitabı Düzenle";
            this.Load += new System.EventHandler(this.EditBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stokCountTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown stokCountTextBox;
        private System.Windows.Forms.DateTimePicker teminDatePicker;
        private System.Windows.Forms.ComboBox teminTypeComboBox;
        private System.Windows.Forms.ComboBox bookTypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox donatorTextBox;
        private System.Windows.Forms.TextBox pageCountTextBox;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox isbnTextBox;
    }
}