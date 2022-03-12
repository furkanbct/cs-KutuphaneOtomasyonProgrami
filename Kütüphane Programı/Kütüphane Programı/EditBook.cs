using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Programı
{
    public partial class EditBook : Form
    {
        DataGridView kitapListesiDataView;
        int index;
        public EditBook(DataGridView view,int rowIndex)
        {
            InitializeComponent();
            kitapListesiDataView = view;
            index = rowIndex;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(isbnTextBox.Text))
            {
                BookDB book = new BookDB();
                book.ISBN = isbnTextBox.Text;
                book.BookName = bookNameTextBox.Text;
                book.Author = authorTextBox.Text;
                book.PageCount = pageCountTextBox.Text;
                book.Publisher = publisherTextBox.Text;
                book.BookType = bookTypeComboBox.SelectedItem.ToString();
                book.TeminType = teminTypeComboBox.SelectedItem.ToString();
                book.TeminDate = teminDatePicker.Value.ToString("dd.MM.yyyy");
                book.Donator = donatorTextBox.Text;
                book.StokCount = stokCountTextBox.Text;
                book.AddedDate = String.Format("{0} {1}:{2}", DateTime.Today.ToString("dd.MM.yyyy"), DateTime.Now.Hour, DateTime.Now.Minute);

                try
                {
                    DatabaseManager.Update(book);
                    kitapListesiDataView.Rows.Clear();
                    DatabaseManager.UpdateDataView(kitapListesiDataView, true);
                    MessageBox.Show("Kitap Başarıyla Kaydedildi", "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Kitap Kaydedilirken Bir Hata Oluştu Hata :"+ex.Message,"Kütüphane Otomasyon Programı",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            this.Close();
        }

        private void EditBook_Load(object sender, EventArgs e)
        {
            isbnTextBox.Text = kitapListesiDataView.Rows[index].Cells[0].Value.ToString();
            bookNameTextBox.Text = kitapListesiDataView.Rows[index].Cells[1].Value.ToString();
            authorTextBox.Text = kitapListesiDataView.Rows[index].Cells[2].Value.ToString();
            pageCountTextBox.Text = kitapListesiDataView.Rows[index].Cells[3].Value.ToString();
            publisherTextBox.Text = kitapListesiDataView.Rows[index].Cells[4].Value.ToString();
            bookTypeComboBox.Text = kitapListesiDataView.Rows[index].Cells[5].Value.ToString();
            teminTypeComboBox.Text = kitapListesiDataView.Rows[index].Cells[6].Value.ToString();
            teminDatePicker.Text = kitapListesiDataView.Rows[index].Cells[7].Value.ToString();
            donatorTextBox.Text = kitapListesiDataView.Rows[index].Cells[8].Value.ToString();
            stokCountTextBox.Text = kitapListesiDataView.Rows[index].Cells[9].Value.ToString();
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            ClearValues();
        }
        void ClearValues()
        {
            isbnTextBox.Text = bookNameTextBox.Text = authorTextBox.Text = pageCountTextBox.Text = publisherTextBox.Text = donatorTextBox.Text = string.Empty;
            stokCountTextBox.Value = 0;
            bookTypeComboBox.SelectedIndex = teminTypeComboBox.SelectedIndex = 0;
            teminDatePicker.Value = DateTime.Today;
        }
    }
}
