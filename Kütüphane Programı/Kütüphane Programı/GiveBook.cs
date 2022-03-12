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
    public partial class GiveBook : Form
    {
        DataGridView oduncListesiDataView;
        public GiveBook(DataGridView view)
        {
            InitializeComponent();
            oduncListesiDataView = view;
        }

        private void GiveBook_Load(object sender, EventArgs e)
        {
            giveDatePicker.Value = DateTime.Today;
            takeDatePicker.Value = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)//Kamera ile okut butonu
        {
            CameraBarcodeReader reader = new CameraBarcodeReader(this);
            reader.Show();
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            tcnoTextBox.Text = nameSurnameTextBox.Text = isbnTextBox.Text = bookNameTextBox.Text = bookAuthorTextBox.Text = string.Empty;
            sexComboBox.SelectedIndex = 0;
            giveDatePicker.Value = takeDatePicker.Value = DateTime.Today;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            OduncDB oduncDB = new OduncDB();

            oduncDB.TCNO = tcnoTextBox.Text;
            oduncDB.NameSurname = nameSurnameTextBox.Text;
            oduncDB.Sex = sexComboBox.SelectedItem.ToString();

            oduncDB.ISBN = isbnTextBox.Text;
            oduncDB.BookName = bookNameTextBox.Text;
            oduncDB.BookAuthor = bookAuthorTextBox.Text;

            oduncDB.DateOfGive = giveDatePicker.Value.ToString("dd.MM.yyyy");
            oduncDB.DateOfTake = takeDatePicker.Value.ToString("dd.MM.yyyy");
            oduncDB.IsTaken = "Hayır";

            try
            {
                DatabaseManager.Insert(oduncDB);
                MessageBox.Show("Ödünç Verme İşlemi Başarıyla Tamamlandı","Kütüphane Otomasyon Programı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                oduncListesiDataView.Rows.Clear();
                DatabaseManager.UpdateOduncDataView(oduncListesiDataView);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ödünç Verme İşlemi Başarısız Oldu Hata :"+ex.Message,"Kütüphane Otomasyon Programı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void isbnTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DatabaseManager.CheckBookExist(isbnTextBox.Text))
            {
                BookDB book = DatabaseManager.GetBook(isbnTextBox.Text);
                bookNameTextBox.Text = book.BookName;
                bookAuthorTextBox.Text = book.Author;
            }
        }

        private void tcnoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DatabaseManager.CheckPersonExist(tcnoTextBox.Text))
            {
                PersonDB person = DatabaseManager.GetPerson(tcnoTextBox.Text);
                nameSurnameTextBox.Text = person.Name + " " + person.Surname;
                sexComboBox.SelectedIndex = sexComboBox.Items.IndexOf(person.Sex);
            }
        }
    }
}
