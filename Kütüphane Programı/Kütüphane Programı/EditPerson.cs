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
    public partial class EditPerson : Form
    {
        DataGridView kisiListesiDataView;
        int index;
        public EditPerson(DataGridView view, int rowIndex)
        {
            InitializeComponent();
            kisiListesiDataView = view;
            index = rowIndex;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tcTextBox.Text))
            {
                PersonDB person = new PersonDB();
                person.TCNO = tcTextBox.Text;
                person.Name = nameTextBox.Text;
                person.Surname = surnameTextBox.Text;
                person.BirthDate = birthdayTextBox.Text;
                person.Sex = sexComboBox.SelectedItem.ToString();
                person.PhoneNumber = phoneTextBox.Text;
                person.Email = emailTextBox.Text;
                person.Address = addressTextBox.Text;
                person.AddedDate = String.Format("{0} {1}:{2}", DateTime.Today.ToString("dd.MM.yyyy"), DateTime.Now.Hour, DateTime.Now.Minute);

                try
                {
                    DatabaseManager.Update(person);
                    kisiListesiDataView.Rows.Clear();
                    DatabaseManager.UpdateDataView(kisiListesiDataView, false);
                    MessageBox.Show("Kişi Başarıyla Kaydedildi", "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kişi Kaydedilirken Bir Hata Oluştu Hata :" + ex.Message, "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }

        private void EditPerson_Load(object sender, EventArgs e)
        {
            tcTextBox.Text = kisiListesiDataView.Rows[index].Cells[0].Value.ToString();
            nameTextBox.Text = kisiListesiDataView.Rows[index].Cells[1].Value.ToString();
            surnameTextBox.Text = kisiListesiDataView.Rows[index].Cells[2].Value.ToString();
            birthdayTextBox.Text = kisiListesiDataView.Rows[index].Cells[3].Value.ToString();
            sexComboBox.Text = kisiListesiDataView.Rows[index].Cells[4].Value.ToString();
            phoneTextBox.Text = kisiListesiDataView.Rows[index].Cells[5].Value.ToString();
            emailTextBox.Text = kisiListesiDataView.Rows[index].Cells[6].Value.ToString();
            addressTextBox.Text = kisiListesiDataView.Rows[index].Cells[7].Value.ToString();
        }
    }
}
