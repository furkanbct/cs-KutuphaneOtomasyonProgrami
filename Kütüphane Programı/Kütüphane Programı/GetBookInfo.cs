using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Net;
using System.Globalization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Kütüphane_Programı
{
    class GetBookInfo
    {
        static string apiUrl = "https://www.googleapis.com/books/v1/volumes?q=isbn:";
        static string volumeApiUrl = "https://www.googleapis.com/books/v1/volumes/";
        public static Book BookInfo(string barcode)
        {
            try
            {
                if (new Ping().Send("www.google.com.mx").Status == IPStatus.Success)
                {
                    try
                    {
                        var json = new WebClient().DownloadString(apiUrl + barcode);
                        JObject _js = JObject.Parse(json);
                        JToken _items = _js["items"][0];
                        JToken _infos = _items["volumeInfo"];
                        JToken id = _items["id"];
                        var realJson = new WebClient().DownloadString(volumeApiUrl + id.ToString());
                        JObject js = JObject.Parse(realJson);
                        JToken items = js;
                        JToken infos = items["volumeInfo"];

                        string author = infos["authors"][0].ToString();
                        byte[] aouthor_bytes = Encoding.Default.GetBytes(author);
                        author = Encoding.UTF8.GetString(aouthor_bytes);
                        author = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(author.ToLower());

                        string bookName = infos["title"].ToString();
                        byte[] bookName_bytes = Encoding.Default.GetBytes(bookName);
                        bookName = Encoding.UTF8.GetString(bookName_bytes);
                        bookName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(bookName.ToLower());

                        string pageCount = infos["pageCount"].ToString();
                        byte[] pageCount_bytes = Encoding.Default.GetBytes(pageCount);
                        pageCount = Encoding.UTF8.GetString(pageCount_bytes);
                        pageCount = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(pageCount.ToLower());

                        string publisher = infos["publisher"].ToString();
                        byte[] publishedDate_bytes = Encoding.Default.GetBytes(publisher);
                        publisher = Encoding.UTF8.GetString(publishedDate_bytes);
                        publisher = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(publisher.ToLower());

                        Book book = new Book();
                        book.ISBN = barcode;
                        book.BookName = bookName;
                        book.Author = author;
                        book.Publisher = publisher;
                        book.PageCount = pageCount;
                        return book;
                    }
                    catch
                    {
                        MessageBox.Show("Kitap Veritabanında Bulunamadı");
                        Book nullBook = new Book();
                        return nullBook;
                    }
                }
                else
                {
                    Book nullBook = new Book();
                    return nullBook;
                }
            }
            catch
            {
                Book nullBook = new Book();
                return nullBook;
            }
        }
    }
}
