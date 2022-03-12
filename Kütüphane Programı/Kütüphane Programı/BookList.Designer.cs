
namespace Kütüphane_Programı
{
    partial class BookList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.booksDataView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalBookCountTextLabel = new System.Windows.Forms.Label();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.pageCountTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.stokCountTextBox = new System.Windows.Forms.TextBox();
            this.donatorTextBox = new System.Windows.Forms.TextBox();
            this.teminDateTextBox = new System.Windows.Forms.TextBox();
            this.addedDateTextBox = new System.Windows.Forms.TextBox();
            this.teminTypeTextBox = new System.Windows.Forms.TextBox();
            this.bookTypeTextBox = new System.Windows.Forms.TextBox();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.totalBookCountLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataView)).BeginInit();
            this.dataViewContextMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // booksDataView
            // 
            this.booksDataView.AllowUserToAddRows = false;
            this.booksDataView.AllowUserToDeleteRows = false;
            this.booksDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.booksDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.booksDataView.ContextMenuStrip = this.dataViewContextMenu;
            this.booksDataView.Location = new System.Drawing.Point(12, 170);
            this.booksDataView.MultiSelect = false;
            this.booksDataView.Name = "booksDataView";
            this.booksDataView.ReadOnly = true;
            this.booksDataView.Size = new System.Drawing.Size(960, 279);
            this.booksDataView.TabIndex = 0;
            this.booksDataView.SelectionChanged += new System.EventHandler(this.booksDataView_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ISBN";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kitap Adı";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Yazar";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sayfa Sayısı";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Yayın Evi";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Kitap Türü";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Temin Türü";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Temin Tarihi";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Bağışlayan";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Stok";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Eklenme Tarihi";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // dataViewContextMenu
            // 
            this.dataViewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopyalaToolStripMenuItem});
            this.dataViewContextMenu.Name = "dataViewContextMenu";
            this.dataViewContextMenu.Size = new System.Drawing.Size(117, 26);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ara";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(104, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aranacak Değer :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arama Türü :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Silver;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ISBN",
            "Kitap Adı",
            "Yazar",
            "Sayfa Sayısı",
            "Yayın Evi",
            "Kitap Türü",
            "Temin Türü",
            "Temin Tarihi",
            "Bağışlayan",
            "Stok",
            "Eklenme Tarihi"});
            this.comboBox1.Location = new System.Drawing.Point(104, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.refreshButton);
            this.groupBox2.Controls.Add(this.totalBookCountLabel);
            this.groupBox2.Controls.Add(this.totalBookCountTextLabel);
            this.groupBox2.Controls.Add(this.publisherTextBox);
            this.groupBox2.Controls.Add(this.pageCountTextBox);
            this.groupBox2.Controls.Add(this.authorTextBox);
            this.groupBox2.Controls.Add(this.bookNameTextBox);
            this.groupBox2.Controls.Add(this.stokCountTextBox);
            this.groupBox2.Controls.Add(this.donatorTextBox);
            this.groupBox2.Controls.Add(this.teminDateTextBox);
            this.groupBox2.Controls.Add(this.addedDateTextBox);
            this.groupBox2.Controls.Add(this.teminTypeTextBox);
            this.groupBox2.Controls.Add(this.bookTypeTextBox);
            this.groupBox2.Controls.Add(this.isbnTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(249, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(723, 152);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Bilgileri";
            // 
            // totalBookCountTextLabel
            // 
            this.totalBookCountTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalBookCountTextLabel.Location = new System.Drawing.Point(504, 42);
            this.totalBookCountTextLabel.Name = "totalBookCountTextLabel";
            this.totalBookCountTextLabel.Size = new System.Drawing.Size(213, 56);
            this.totalBookCountTextLabel.TabIndex = 2;
            this.totalBookCountTextLabel.Text = "Kayıtlı Kitap Sayısı";
            this.totalBookCountTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.BackColor = System.Drawing.Color.Silver;
            this.publisherTextBox.Location = new System.Drawing.Point(112, 120);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.ReadOnly = true;
            this.publisherTextBox.Size = new System.Drawing.Size(121, 20);
            this.publisherTextBox.TabIndex = 1;
            // 
            // pageCountTextBox
            // 
            this.pageCountTextBox.BackColor = System.Drawing.Color.Silver;
            this.pageCountTextBox.Location = new System.Drawing.Point(112, 94);
            this.pageCountTextBox.Name = "pageCountTextBox";
            this.pageCountTextBox.ReadOnly = true;
            this.pageCountTextBox.Size = new System.Drawing.Size(121, 20);
            this.pageCountTextBox.TabIndex = 1;
            // 
            // authorTextBox
            // 
            this.authorTextBox.BackColor = System.Drawing.Color.Silver;
            this.authorTextBox.Location = new System.Drawing.Point(112, 68);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.ReadOnly = true;
            this.authorTextBox.Size = new System.Drawing.Size(121, 20);
            this.authorTextBox.TabIndex = 1;
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.BackColor = System.Drawing.Color.Silver;
            this.bookNameTextBox.Location = new System.Drawing.Point(112, 42);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.ReadOnly = true;
            this.bookNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.bookNameTextBox.TabIndex = 1;
            // 
            // stokCountTextBox
            // 
            this.stokCountTextBox.BackColor = System.Drawing.Color.Silver;
            this.stokCountTextBox.Location = new System.Drawing.Point(357, 120);
            this.stokCountTextBox.Name = "stokCountTextBox";
            this.stokCountTextBox.ReadOnly = true;
            this.stokCountTextBox.Size = new System.Drawing.Size(121, 20);
            this.stokCountTextBox.TabIndex = 1;
            // 
            // donatorTextBox
            // 
            this.donatorTextBox.BackColor = System.Drawing.Color.Silver;
            this.donatorTextBox.Location = new System.Drawing.Point(357, 94);
            this.donatorTextBox.Name = "donatorTextBox";
            this.donatorTextBox.ReadOnly = true;
            this.donatorTextBox.Size = new System.Drawing.Size(121, 20);
            this.donatorTextBox.TabIndex = 1;
            // 
            // teminDateTextBox
            // 
            this.teminDateTextBox.BackColor = System.Drawing.Color.Silver;
            this.teminDateTextBox.Location = new System.Drawing.Point(357, 68);
            this.teminDateTextBox.Name = "teminDateTextBox";
            this.teminDateTextBox.ReadOnly = true;
            this.teminDateTextBox.Size = new System.Drawing.Size(121, 20);
            this.teminDateTextBox.TabIndex = 1;
            // 
            // addedDateTextBox
            // 
            this.addedDateTextBox.BackColor = System.Drawing.Color.Silver;
            this.addedDateTextBox.Location = new System.Drawing.Point(596, 17);
            this.addedDateTextBox.Name = "addedDateTextBox";
            this.addedDateTextBox.ReadOnly = true;
            this.addedDateTextBox.Size = new System.Drawing.Size(121, 20);
            this.addedDateTextBox.TabIndex = 1;
            // 
            // teminTypeTextBox
            // 
            this.teminTypeTextBox.BackColor = System.Drawing.Color.Silver;
            this.teminTypeTextBox.Location = new System.Drawing.Point(357, 42);
            this.teminTypeTextBox.Name = "teminTypeTextBox";
            this.teminTypeTextBox.ReadOnly = true;
            this.teminTypeTextBox.Size = new System.Drawing.Size(121, 20);
            this.teminTypeTextBox.TabIndex = 1;
            // 
            // bookTypeTextBox
            // 
            this.bookTypeTextBox.BackColor = System.Drawing.Color.Silver;
            this.bookTypeTextBox.Location = new System.Drawing.Point(357, 16);
            this.bookTypeTextBox.Name = "bookTypeTextBox";
            this.bookTypeTextBox.ReadOnly = true;
            this.bookTypeTextBox.Size = new System.Drawing.Size(121, 20);
            this.bookTypeTextBox.TabIndex = 1;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.BackColor = System.Drawing.Color.Silver;
            this.isbnTextBox.Location = new System.Drawing.Point(112, 16);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.ReadOnly = true;
            this.isbnTextBox.Size = new System.Drawing.Size(121, 20);
            this.isbnTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sayfa Sayısı :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(251, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Stok :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Yazar :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(251, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Bağışlayan :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(251, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Temin Tarihi :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(490, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Eklenme Tarihi :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(251, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Temin Türü :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(251, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kitap Türü :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yayın Evi :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kitap Adı :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "ISBN :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kitabı Düzenle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Kitabı Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(116, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "Yeni Kitap Ekle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // totalBookCountLabel
            // 
            this.totalBookCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalBookCountLabel.Location = new System.Drawing.Point(504, 89);
            this.totalBookCountLabel.Name = "totalBookCountLabel";
            this.totalBookCountLabel.Size = new System.Drawing.Size(213, 25);
            this.totalBookCountLabel.TabIndex = 2;
            this.totalBookCountLabel.Text = "153";
            this.totalBookCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refreshButton
            // 
            this.refreshButton.Image = global::Kütüphane_Programı.Properties.Resources.refresh_icon;
            this.refreshButton.Location = new System.Drawing.Point(493, 106);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(40, 40);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // KitapListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.booksDataView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "KitapListesi";
            this.Text = "KitapListesi";
            this.Load += new System.EventHandler(this.KitapListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataView)).EndInit();
            this.dataViewContextMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView booksDataView;
        private System.Windows.Forms.ContextMenuStrip dataViewContextMenu;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox pageCountTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookTypeTextBox;
        private System.Windows.Forms.TextBox donatorTextBox;
        private System.Windows.Forms.TextBox teminDateTextBox;
        private System.Windows.Forms.TextBox teminTypeTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalBookCountTextLabel;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox stokCountTextBox;
        private System.Windows.Forms.TextBox addedDateTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label totalBookCountLabel;
        private System.Windows.Forms.Button refreshButton;
    }
}