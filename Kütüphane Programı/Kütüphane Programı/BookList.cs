using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Programı
{
    public partial class BookList : Form
    {
        string[] comboBoxEng = new string[] {"ISBN","BookName","Author","PageCount","Publisher","BookType","TeminType","TeminDate","Donator","StokCount","AddedDate"};//Combobox seçilen değerin db deki karşılığı
        public BookList()
        {
            InitializeComponent();
        }

        private void KitapListesi_Load(object sender, EventArgs e)
        {
            DatabaseManager.CheckAndCreateDB();
            DatabaseManager.UpdateDataView(booksDataView,true);
            comboBox1.SelectedIndex = 0;
            totalBookCountLabel.Text = booksDataView.Rows.Count.ToString();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string value = booksDataView.CurrentCell.Value.ToString();
            if (!string.IsNullOrEmpty(value))
            {
                Clipboard.SetText(value);
            }
            else
            {
                Clipboard.SetText(" ");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//Arama Text Box
        {
            string filter = comboBoxEng[comboBox1.SelectedIndex];
            string searchValue = textBox1.Text;
            searchValue = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchValue.ToLower());
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                DatabaseManager.SearchBook(booksDataView, filter, searchValue);
            }
            else
            {
                booksDataView.Rows.Clear();
                DatabaseManager.UpdateDataView(booksDataView,true);
            }
        }

        private void booksDataView_SelectionChanged(object sender, EventArgs e)
        {
            BookDB book = DatabaseManager.GetBook(booksDataView.CurrentCell.OwningRow.Cells[0].Value.ToString());
            isbnTextBox.Text = book.ISBN;
            bookNameTextBox.Text = book.BookName;
            authorTextBox.Text = book.Author;
            pageCountTextBox.Text = book.PageCount;
            publisherTextBox.Text = book.Publisher;
            bookTypeTextBox.Text = book.BookType;
            teminTypeTextBox.Text = book.TeminType;
            teminDateTextBox.Text = book.TeminDate;
            donatorTextBox.Text = book.Donator;
            stokCountTextBox.Text = book.StokCount;
            addedDateTextBox.Text = book.AddedDate;
        }

        private void button3_Click(object sender, EventArgs e)//Yeni kitap ekleme butonu
        {
            AddBook kitapEkle = new AddBook(booksDataView);
            kitapEkle.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            booksDataView.Rows.Clear();
            DatabaseManager.UpdateDataView(booksDataView, true);
            totalBookCountLabel.Text = booksDataView.Rows.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)//Kitabı Sil Butonu
        {
            if (booksDataView.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("Seçilen Kitabı Silmek İstediğine Eminmisin ?", "Kütüphane Otomasyon Programı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DatabaseManager.DeleteBook(booksDataView, booksDataView.CurrentCell.OwningRow.Cells[0].Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Bir Kitap Seçiniz", "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)//Kitabı Düzenle Butonu
        {
            if (booksDataView.CurrentCell != null)
            {
                EditBook editBook = new EditBook(booksDataView, booksDataView.CurrentCell.RowIndex);
                editBook.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Bir Kitap Seçiniz", "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
