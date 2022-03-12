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
    public partial class AddPerson : Form
    {
        DataGridView kisiListesiDataView;
        public AddPerson(DataGridView view)
        {
            InitializeComponent();
            kisiListesiDataView = view;
            sexComboBox.SelectedIndex = 0;
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            ClearValues();
        }

        private void birthdayTextBox_Click(object sender, EventArgs e)
        {
            birthdayTextBox.Select(0,0);
        }

        private void birthdayTextBox_Validating(object sender, CancelEventArgs e)
        {
            DateTime rs;
            CultureInfo ci = new CultureInfo("tr-TR");
            if(!DateTime.TryParseExact(birthdayTextBox.Text,"dd/MM/yyyy",ci,DateTimeStyles.None,out rs))
            {
                birthdayTextBox.Text = string.Empty;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tcTextBox.Text))
            {
                PersonDB kisi = new PersonDB();
                kisi.TCNO = tcTextBox.Text;
                kisi.Name = nameTextBox.Text;
                kisi.Surname = surnameTextBox.Text;
                kisi.BirthDate = birthdayTextBox.Text;
                kisi.Sex = sexComboBox.SelectedItem.ToString();
                kisi.PhoneNumber = phoneTextBox.Text;
                kisi.Email = emailTextBox.Text;
                kisi.Address = addressTextBox.Text;
                kisi.AddedDate = String.Format("{0} {1}:{2}", DateTime.Today.ToString("dd.MM.yyyy"), DateTime.Now.Hour, DateTime.Now.Minute);

                if (!DatabaseManager.CheckPersonExist(kisi.TCNO))
                {
                    try
                    {
                        DatabaseManager.Insert(kisi);
                        MessageBox.Show("Kişi Başarıyla Eklendi", "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kişi Ekleme Başarısız Oldu Hata Kodu :" + ex.Message, "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    kisiListesiDataView.Rows.Clear();
                    DatabaseManager.UpdateDataView(kisiListesiDataView, false);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bu TCNO Zaten Kayıtlı", "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                ClearValues();
            }
            else
            {
                MessageBox.Show("TCNO Boş Bırakılamaz", "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ClearValues()
        {
            tcTextBox.Text = nameTextBox.Text = surnameTextBox.Text = phoneTextBox.Text = emailTextBox.Text = addressTextBox.Text = string.Empty;
            birthdayTextBox.Text = DateTime.Today.ToString();
            sexComboBox.SelectedIndex = 0;
        }

        private void tcTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
