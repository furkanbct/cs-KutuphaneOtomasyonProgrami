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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Kitap İşlemleri Butonu
        {
            BookList bookList = new BookList();
            bookList.Show();
        }

        private void button2_Click(object sender, EventArgs e)//Kişi İşlemleri Butonu
        {
            PersonList personList = new PersonList();
            personList.Show();
        }

        private void button3_Click(object sender, EventArgs e)//Ödünç İşlemleri Butonu
        {
            OduncList oduncList = new OduncList();
            oduncList.Show();
        }
    }
}
