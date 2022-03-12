using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Programı
{
    class BookDB
    {
        public string ISBN { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string PageCount { get; set; }
        public string Publisher { get; set; }
        public string BookType { get; set; }
        public string TeminType { get; set; }
        public string TeminDate { get; set; }
        public string Donator { get; set; }
        public string StokCount { get; set; }
        public string AddedDate{ get; set; }
    }
}
