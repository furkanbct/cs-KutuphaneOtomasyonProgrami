using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Programı
{
    public partial class AddBook : Form
    {
        CameraBarcodeReader kameraBarkodOkuyucu;
        DataGridView kitapListesiDataView;
        public AddBook(DataGridView view)
        {
            InitializeComponent();
            kitapListesiDataView = view;
            bookTypeComboBox.SelectedIndex = 0;
            teminTypeComboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)//Kamera Butonu
        {
            if (kameraBarkodOkuyucu == null)
            {
                kameraBarkodOkuyucu = new CameraBarcodeReader(this);
                kameraBarkodOkuyucu.Show();
            }
            else
            {
                kameraBarkodOkuyucu.Show();
            }
        }
        public void GetValuesFromBarcodeReaders(Book book)
        {
            isbnTextBox.Text = book.ISBN;
            authorTextBox.Text = book.Author;
            bookNameTextBox.Text = book.BookName;
            publisherTextBox.Text = book.Publisher;
            pageCountTextBox.Text = book.PageCount;
            kameraBarkodOkuyucu.Dispose();
            if (kameraBarkodOkuyucu.videoCaptureDevice != null)
            {
                if (kameraBarkodOkuyucu.videoCaptureDevice.IsRunning)
                {
                    kameraBarkodOkuyucu.videoCaptureDevice.SignalToStop();
                }
            }
            kameraBarkodOkuyucu.Close();
            kameraBarkodOkuyucu = null;
        }

        private void isbnTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            ClearValues();
        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
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

                if (!DatabaseManager.CheckBookExist(book.ISBN))
                {
                    try
                    {
                        DatabaseManager.Insert(book);
                        MessageBox.Show("Kitap Başarıyla Eklendi", "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kitap Ekleme Başarısız Oldu Hata Kodu :" + ex.Message, "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    kitapListesiDataView.Rows.Clear();
                    DatabaseManager.UpdateDataView(kitapListesiDataView, true);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bu ISBN Numarası Zaten Kayıtlı","Kütüphane Otomasyon Programı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                ClearValues();
            }
            else
            {
                MessageBox.Show("ISBN Numarası Boş Bırakılamaz","Kütüphane Otomasyon Programı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
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
