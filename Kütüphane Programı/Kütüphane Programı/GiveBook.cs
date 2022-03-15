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
            sexComboBox.SelectedIndex = 0;
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
            oduncDB.DateOfTaken = "-";

            if (isbnTextBox.Text != string.Empty && tcnoTextBox.Text != string.Empty)
            {

                if (!DatabaseManager.CheckOduncExist(oduncDB.TCNO, oduncDB.ISBN))
                {
                    if (DatabaseManager.CheckPersonExist(oduncDB.TCNO))
                    {
                        if (DatabaseManager.CheckBookExist(oduncDB.ISBN))
                        {
                            try
                            {
                                DatabaseManager.Insert(oduncDB);
                                oduncListesiDataView.Rows.Clear();
                                DatabaseManager.UpdateOduncDataView(oduncListesiDataView);
                                MessageBox.Show("Ödünç Verme İşlemi Başarıyla Tamamlandı", "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ödünç Verme İşlemi Başarısız Oldu Hata :" + ex.Message, "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Bu ISBN Numarası Kayıtlı Değil Yinede Devam Etmek İstiyormusunuz ?", "Kütüphane Otomasyon Programı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {
                                try
                                {
                                    DatabaseManager.Insert(oduncDB);
                                    oduncListesiDataView.Rows.Clear();
                                    DatabaseManager.UpdateOduncDataView(oduncListesiDataView);
                                    MessageBox.Show("Ödünç Verme İşlemi Başarıyla Tamamlandı", "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Ödünç Verme İşlemi Başarısız Oldu Hata :" + ex.Message, "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Bu TCNO Kayıtlı Değil Yinede Devam Etmek İstiyormusunuz ?", "Kütüphane Otomasyon Programı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            if (DatabaseManager.CheckBookExist(oduncDB.ISBN))
                            {
                                try
                                {
                                    DatabaseManager.Insert(oduncDB);
                                    oduncListesiDataView.Rows.Clear();
                                    DatabaseManager.UpdateOduncDataView(oduncListesiDataView);
                                    MessageBox.Show("Ödünç Verme İşlemi Başarıyla Tamamlandı", "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Ödünç Verme İşlemi Başarısız Oldu Hata :" + ex.Message, "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                DialogResult res = MessageBox.Show("Bu ISBN Numarası Kayıtlı Değil Yinede Devam Etmek İstiyormusunuz ?", "Kütüphane Otomasyon Programı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (res == DialogResult.Yes)
                                {
                                    try
                                    {
                                        DatabaseManager.Insert(oduncDB);
                                        oduncListesiDataView.Rows.Clear();
                                        DatabaseManager.UpdateOduncDataView(oduncListesiDataView);
                                        MessageBox.Show("Ödünç Verme İşlemi Başarıyla Tamamlandı", "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Ödünç Verme İşlemi Başarısız Oldu Hata :" + ex.Message, "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bu Bilgiler Zaten Kayıtlı", "Kütüphane Otomasyon Progarmı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("TCNO veya ISBN Boş Bırakılamaz","Kütüphane Otomasyon Programı",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            else
            {
                bookNameTextBox.Text = string.Empty;
                bookAuthorTextBox.Text = string.Empty;
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
            else
            {
                nameSurnameTextBox.Text = string.Empty;
                sexComboBox.SelectedIndex = 0;
            }
        }
    }
}
