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
    public partial class OduncList : Form
    {
        string[] comboBoxEng = new string[] { "TCNO", "NameSurname", "Sex", "ISBN", "BookName", "BookAuthor", "DateOfGive", "DateOfTake", "IsTaken" };//Combobox seçilen değerin db deki karşılığı
        public OduncList()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void OduncList_Load(object sender, EventArgs e)
        {
            DatabaseManager.CheckAndCreateDB();
            DatabaseManager.UpdateOduncDataView(oduncDataView);
            UpdateInfoLabels();
        }

        private void button3_Click(object sender, EventArgs e)//Ödünç ver butonu
        {
            GiveBook giveBook = new GiveBook(oduncDataView);
            giveBook.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filter = comboBoxEng[comboBox1.SelectedIndex];
            string searchValue = textBox1.Text;
            searchValue = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchValue.ToLower());
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                DatabaseManager.SearchOdunc(oduncDataView, filter, searchValue);
            }
            else
            {
                oduncDataView.Rows.Clear();
                DatabaseManager.UpdateOduncDataView(oduncDataView);
            }
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string value = oduncDataView.CurrentCell.Value.ToString();
            if (!string.IsNullOrEmpty(value))
            {
                Clipboard.SetText(value);
            }
            else
            {
                Clipboard.SetText(" ");
            }
        }

        private void oduncDataView_SelectionChanged(object sender, EventArgs e)
        {
            OduncDB oduncDB = DatabaseManager.GetOdunc(oduncDataView.CurrentCell.OwningRow.Cells[0].Value.ToString(),oduncDataView.CurrentCell.OwningRow.Cells[3].Value.ToString());
            tcnoTextBox.Text = oduncDB.TCNO;
            nameSurnameTextBox.Text = oduncDB.NameSurname;
            sexTextBox.Text = oduncDB.Sex;
            isbnTextBox.Text = oduncDB.ISBN;
            bookNameTextBox.Text = oduncDB.BookName;
            bookAuthorTextBox.Text = oduncDB.BookAuthor;
            dateOfGiveTextBox.Text = oduncDB.DateOfGive;
            dateOfTakeTextBox.Text = oduncDB.DateOfTake;
            isTakenTextBox.Text = oduncDB.IsTaken;
        }

        private void oduncDataView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            UpdateInfoLabels();
        }

        public void UpdateInfoLabels()
        {
            List<DataGridViewRow> takenTodayRows = new List<DataGridViewRow>();
            List<DataGridViewRow> gecikmisRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in oduncDataView.Rows)
            {
                if (row.Cells[7].Value.ToString() == DateTime.Today.ToString("dd.MM.yyyy"))
                {
                    takenTodayRows.Add(row);
                    row.DefaultCellStyle.BackColor = SystemColors.Highlight;
                }
                if (row.Cells[8].Value.ToString() == "Hayır")
                {
                    if (DateTime.ParseExact(row.Cells[7].Value.ToString(), "dd.MM.yyyy", CultureInfo.CurrentCulture) < DateTime.Today)
                    {
                        gecikmisRows.Add(row);
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Lime;
                }
            }
            alinacakLabel.Text = takenTodayRows.Count.ToString();
            gecikmisLabel.Text = gecikmisRows.Count.ToString();
        }

        private void oduncDataView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateInfoLabels();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            oduncDataView.Rows.Clear();
            DatabaseManager.UpdateOduncDataView(oduncDataView);
            UpdateInfoLabels();
        }

        private void button1_Click(object sender, EventArgs e)//Teslim Al Butonu
        {
            if(oduncDataView.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("Seçilen Kitabı Teslim Almak İstediğine Emin misin ?", "Kütüphane Otomasyon Programı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow oduncRowView = oduncDataView.CurrentCell.OwningRow;
                    OduncDB odunc = new OduncDB();
                    odunc.TCNO = oduncRowView.Cells[0].Value.ToString();
                    odunc.NameSurname = oduncRowView.Cells[1].Value.ToString();
                    odunc.Sex = oduncRowView.Cells[2].Value.ToString();
                    odunc.ISBN = oduncRowView.Cells[3].Value.ToString();
                    odunc.BookName = oduncRowView.Cells[4].Value.ToString();
                    odunc.BookAuthor = oduncRowView.Cells[5].Value.ToString();
                    odunc.DateOfGive = oduncRowView.Cells[6].Value.ToString();
                    odunc.DateOfTake = oduncRowView.Cells[7].Value.ToString();
                    odunc.IsTaken = "Evet";
                    odunc.DateOfTaken = String.Format("{0} {1}:{2}", DateTime.Today.ToString("dd.MM.yyyy"), DateTime.Now.Hour, DateTime.Now.Minute);
                    DatabaseManager.Update(odunc);
                    oduncDataView.Rows.Clear();
                    DatabaseManager.UpdateOduncDataView(oduncDataView);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Bir Ödünç Seçiniz", "Kütüphane Otomasyon Programı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
