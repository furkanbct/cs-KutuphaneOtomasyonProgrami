
namespace Kütüphane_Programı
{
    partial class GiveBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiveBook));
            this.giveDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cleanButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.tcnoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.takeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nameSurnameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bookAuthorTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // giveDatePicker
            // 
            this.giveDatePicker.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.giveDatePicker.Location = new System.Drawing.Point(99, 90);
            this.giveDatePicker.Name = "giveDatePicker";
            this.giveDatePicker.Size = new System.Drawing.Size(150, 20);
            this.giveDatePicker.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Verilme Tarihi :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(272, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "TCNO :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cleanButton
            // 
            this.cleanButton.BackColor = System.Drawing.SystemColors.Control;
            this.cleanButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cleanButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cleanButton.Font = new System.Drawing.Font("Colonna MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cleanButton.Location = new System.Drawing.Point(268, 145);
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
            this.saveButton.Location = new System.Drawing.Point(396, 145);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(122, 37);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "KAYDET";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tcnoTextBox
            // 
            this.tcnoTextBox.BackColor = System.Drawing.Color.Silver;
            this.tcnoTextBox.Location = new System.Drawing.Point(368, 12);
            this.tcnoTextBox.Name = "tcnoTextBox";
            this.tcnoTextBox.Size = new System.Drawing.Size(150, 20);
            this.tcnoTextBox.TabIndex = 3;
            this.tcnoTextBox.TextChanged += new System.EventHandler(this.tcnoTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(272, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Alınacak Tarih :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // takeDatePicker
            // 
            this.takeDatePicker.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.takeDatePicker.Location = new System.Drawing.Point(368, 90);
            this.takeDatePicker.Name = "takeDatePicker";
            this.takeDatePicker.Size = new System.Drawing.Size(150, 20);
            this.takeDatePicker.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 52);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Colonna MT", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(6, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kamera İle ISBN Okut";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Colonna MT", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(102, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "Barkod Okuyucu İle ISBN Okut";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // nameSurnameTextBox
            // 
            this.nameSurnameTextBox.BackColor = System.Drawing.Color.Silver;
            this.nameSurnameTextBox.Location = new System.Drawing.Point(368, 38);
            this.nameSurnameTextBox.Name = "nameSurnameTextBox";
            this.nameSurnameTextBox.Size = new System.Drawing.Size(150, 20);
            this.nameSurnameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(272, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Ad Soyad :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(272, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Cinsiyet :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.BackColor = System.Drawing.Color.Silver;
            this.isbnTextBox.Location = new System.Drawing.Point(99, 12);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(150, 20);
            this.isbnTextBox.TabIndex = 0;
            this.isbnTextBox.TextChanged += new System.EventHandler(this.isbnTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "ISBN :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.BackColor = System.Drawing.Color.Silver;
            this.bookNameTextBox.Location = new System.Drawing.Point(99, 38);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.bookNameTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Kitap Adı :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bookAuthorTextBox
            // 
            this.bookAuthorTextBox.BackColor = System.Drawing.Color.Silver;
            this.bookAuthorTextBox.Location = new System.Drawing.Point(99, 64);
            this.bookAuthorTextBox.Name = "bookAuthorTextBox";
            this.bookAuthorTextBox.Size = new System.Drawing.Size(150, 20);
            this.bookAuthorTextBox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Kitap Yazarı :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(343, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "Bilgi : Eğer girilen ISBN veya TCNO kayıtlı ise bilgiler otomatik doldurulur";
            // 
            // sexComboBox
            // 
            this.sexComboBox.BackColor = System.Drawing.Color.Silver;
            this.sexComboBox.Items.AddRange(new object[] {
            "Erkek",
            "Kadın",
            "Diğer",
            "Belirtilmemiş"});
            this.sexComboBox.Location = new System.Drawing.Point(368, 64);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(150, 21);
            this.sexComboBox.TabIndex = 5;
            // 
            // GiveBook
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(536, 196);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.takeDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.giveDatePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.bookAuthorTextBox);
            this.Controls.Add(this.bookNameTextBox);
            this.Controls.Add(this.isbnTextBox);
            this.Controls.Add(this.nameSurnameTextBox);
            this.Controls.Add(this.tcnoTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GiveBook";
            this.Text = "Ödünç Ver";
            this.Load += new System.EventHandler(this.GiveBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker giveDatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox tcnoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker takeDatePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nameSurnameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox bookAuthorTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox sexComboBox;
    }
}