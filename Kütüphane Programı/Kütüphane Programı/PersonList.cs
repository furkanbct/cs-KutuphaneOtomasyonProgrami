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
    public partial class PersonList : Form
    {
        string[] comboBoxEng = new string[] { "TCNO", "Name", "Surname", "Birthdate", "Sex", "PhoneNumber", "Email", "Address", "AddedDate"};//Combobox seçilen değerin db deki karşılığı
        public PersonList()
        {
            InitializeComponent();
        }

        private void PersonList_Load(object sender, EventArgs e)
        {
            DatabaseManager.CheckAndCreateDB();
            DatabaseManager.UpdateDataView(personsDataView,false);
            comboBox1.SelectedIndex = 0;
            totalPersonCountLabel.Text = personsDataView.Rows.Count.ToString();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string value = personsDataView.CurrentCell.Value.ToString();
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
                DatabaseManager.SearchPerson(personsDataView, filter, searchValue);
            }
            else
            {
                personsDataView.Rows.Clear();
                DatabaseManager.UpdateDataView(personsDataView, false);
            }
        }
        private void personsDataView_SelectionChanged(object sender, EventArgs e)
        {
            PersonDB person = DatabaseManager.GetPerson(personsDataView.CurrentCell.OwningRow.Cells[0].Value.ToString());
            tcnoTextBox.Text = person.TCNO;
            nameTextBox.Text = person.Name;
            surnameTextBox.Text = person.Surname;
            birthdateTextBox.Text = person.BirthDate;
            sexTextBox.Text = person.Sex;
            phoneNumberTextBox.Text = person.PhoneNumber;
            emailTextBox.Text = person.Email;
            addressTextBox.Text = person.Address;
            addedDateTextBox.Text = person.AddedDate;
        }

        private void button3_Click(object sender, EventArgs e)//Yeni kitap ekleme butonu
        {
            AddPerson addPerson = new AddPerson(personsDataView);
            addPerson.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            personsDataView.Rows.Clear();
            DatabaseManager.UpdateDataView(personsDataView, false);
            totalPersonCountLabel.Text = personsDataView.Rows.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)//Kişiyi Sil Butonu
        {
            if(personsDataView.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("Seçilen Kişiyi Silmek İstediğine Eminmisin ?", "Kütüphane Otomasyon Programı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DatabaseManager.DeletePerson(personsDataView, personsDataView.CurrentCell.OwningRow.Cells[0].Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Bir Kişi Seçiniz", "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)//Kişiyi Düzenle Butonu
        {
            if(personsDataView.CurrentCell != null)
            {
                EditPerson editPerson = new EditPerson(personsDataView, personsDataView.CurrentCell.RowIndex);
                editPerson.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Bir Kişi Seçiniz", "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
