using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace Kütüphane_Programı
{
    class DatabaseManager
    {
        static string path = "data.db";
        static string cs = @"URI=file:" + Application.StartupPath + "\\data.db";
        public static void CheckAndCreateDB()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using(var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "CREATE TABLE 'Books' ('ISBN' TEXT,'BookName' TEXT,'Author' TEXT,'PageCount' TEXT,'Publisher' TEXT,'BookType' TEXT,'TeminType' TEXT,'TeminDate' TEXT,'Donator' TEXT,'StokCount' TEXT,'AddedDate' TEXT)";
                    string sql2 = "CREATE TABLE 'Persons' ('TCNO' TEXT,'Name' TEXT,'Surname' TEXT,'BirthDate' TEXT,'Sex' TEXT,'PhoneNumber' TEXT,'Email' TEXT,'Address' TEXT,'AddedDate' TEXT)";
                    string sql3 = "CREATE TABLE 'Odunc' ('TCNO' TEXT, 'NameSurname' TEXT, 'Sex' TEXT, 'ISBN' TEXT, 'BookName' TEXT, 'BookAuthor' TEXT, 'DateOfGive' TEXT, 'DateOfTake' TEXT, 'IsTaken' TEXT, 'DateOfTaken' TEXT)";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    SQLiteCommand command2 = new SQLiteCommand(sql2, sqlite);
                    SQLiteCommand command3 = new SQLiteCommand(sql3, sqlite);
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    command3.ExecuteNonQuery();
                }
            }
        }
        public static void Insert(BookDB book)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "INSERT INTO Books(ISBN,BookName,Author,PageCount,Publisher,BookType,TeminType,TeminDate,Donator,StokCount,AddedDate) VALUES(@isbn,@bookName,@author,@pageCount,@publisher,@bookType,@teminType,@teminDate,@donator,@stokCount,@addedDate)";

            cmd.Parameters.AddWithValue("@isbn",book.ISBN);
            cmd.Parameters.AddWithValue("@bookName",book.BookName);
            cmd.Parameters.AddWithValue("@author",book.Author);
            cmd.Parameters.AddWithValue("@pageCount",book.PageCount);
            cmd.Parameters.AddWithValue("@publisher",book.Publisher);
            cmd.Parameters.AddWithValue("@bookType",book.BookType);
            cmd.Parameters.AddWithValue("@teminType",book.TeminType);
            cmd.Parameters.AddWithValue("@teminDate",book.TeminDate);
            cmd.Parameters.AddWithValue("@donator",book.Donator);
            cmd.Parameters.AddWithValue("@stokCount",book.StokCount);
            cmd.Parameters.AddWithValue("@addedDate",book.AddedDate);

            cmd.ExecuteNonQuery();
        }
        public static void Insert(PersonDB kisi)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "INSERT INTO Persons(TCNO,Name,Surname,BirthDate,Sex,PhoneNumber,EMail,Address,AddedDate) VALUES(@tcno,@name,@surname,@birthDate,@sex,@phoneNumber,@email,@address,@addedDate)";

            cmd.Parameters.AddWithValue("@tcno", kisi.TCNO);
            cmd.Parameters.AddWithValue("@name", kisi.Name);
            cmd.Parameters.AddWithValue("@surname", kisi.Surname);
            cmd.Parameters.AddWithValue("@birthDate", kisi.BirthDate);
            cmd.Parameters.AddWithValue("@sex", kisi.Sex);
            cmd.Parameters.AddWithValue("@phoneNumber", kisi.PhoneNumber);
            cmd.Parameters.AddWithValue("@email", kisi.Email);
            cmd.Parameters.AddWithValue("@address", kisi.Address);
            cmd.Parameters.AddWithValue("@addedDate", kisi.AddedDate);

            cmd.ExecuteNonQuery();
        }
        public static void Insert(OduncDB oduncDB)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "INSERT INTO Odunc(TCNO,NameSurname,Sex,ISBN,BookName,BookAuthor,DateOfGive,DateOfTake,IsTaken,DateOfTaken) VALUES(@tcno,@nameSurname,@sex,@isbn,@bookName,@bookAuthor,@dateOfGive,@dateOfTake,@isTaken,@dateOfTaken)";

            cmd.Parameters.AddWithValue("@tcno", oduncDB.TCNO);
            cmd.Parameters.AddWithValue("@nameSurname", oduncDB.NameSurname);
            cmd.Parameters.AddWithValue("@sex", oduncDB.Sex);
            cmd.Parameters.AddWithValue("@isbn", oduncDB.ISBN);
            cmd.Parameters.AddWithValue("@bookName", oduncDB.BookName);
            cmd.Parameters.AddWithValue("@bookAuthor", oduncDB.BookAuthor);
            cmd.Parameters.AddWithValue("@dateOfGive", oduncDB.DateOfGive);
            cmd.Parameters.AddWithValue("@dateOfTake", oduncDB.DateOfTake);
            cmd.Parameters.AddWithValue("@isTaken", oduncDB.IsTaken);
            cmd.Parameters.AddWithValue("@dateOfTaken", oduncDB.DateOfTaken);

            cmd.ExecuteNonQuery();
        }
        public static void Update(BookDB book)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "UPDATE Books SET ISBN=@isbn,BookName=@bookName,Author=@author,PageCount=@pageCount,Publisher=@publisher,BookType=@bookType,TeminType=@teminType,TeminDate=@teminDate,Donator=@donator,StokCount=@stokCount,AddedDate=@addedDate Where ISBN = @isbn";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@isbn", book.ISBN);
            cmd.Parameters.AddWithValue("@bookName", book.BookName);
            cmd.Parameters.AddWithValue("@author", book.Author);
            cmd.Parameters.AddWithValue("@pageCount", book.PageCount);
            cmd.Parameters.AddWithValue("@publisher", book.Publisher);
            cmd.Parameters.AddWithValue("@bookType", book.BookType);
            cmd.Parameters.AddWithValue("@teminType", book.TeminType);
            cmd.Parameters.AddWithValue("@teminDate", book.TeminDate);
            cmd.Parameters.AddWithValue("@donator", book.Donator);
            cmd.Parameters.AddWithValue("@stokCount", book.StokCount);
            cmd.Parameters.AddWithValue("@addedDate", book.AddedDate);
            cmd.ExecuteNonQuery();
        }
        public static void Update(PersonDB person)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "UPDATE Persons SET TCNO=@tcno,Name=@name,Surname=@surname,BirthDate=@birthDate,Sex=@sex,PhoneNumber=@phoneNumber,Email=@email,Address=@address,AddedDate=@addedDate Where TCNO = @tcno";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@tcno", person.TCNO);
            cmd.Parameters.AddWithValue("@name", person.Name);
            cmd.Parameters.AddWithValue("@surname", person.Surname);
            cmd.Parameters.AddWithValue("@birthDate", person.BirthDate);
            cmd.Parameters.AddWithValue("@sex", person.Sex);
            cmd.Parameters.AddWithValue("@phoneNumber", person.PhoneNumber);
            cmd.Parameters.AddWithValue("@email", person.Email);
            cmd.Parameters.AddWithValue("@address", person.Address);
            cmd.Parameters.AddWithValue("@addedDate", person.AddedDate);
            cmd.ExecuteNonQuery();
        }
        public static void Update(OduncDB oduncDB)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "UPDATE Odunc SET TCNO=@tcno,NameSurname=@nameSurname,Sex=@sex,ISBN=@isbn,BookName=@bookName,BookAuthor=@bookAuthor,DateOfGive=@dateOfGive,DateOfTake=@dateOfTake,IsTaken=@isTaken,DateOfTaken=@dateOfTaken Where TCNO = @tcno AND ISBN = @isbn";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@tcno", oduncDB.TCNO);
            cmd.Parameters.AddWithValue("@nameSurname", oduncDB.NameSurname);
            cmd.Parameters.AddWithValue("@sex", oduncDB.Sex);
            cmd.Parameters.AddWithValue("@isbn", oduncDB.ISBN);
            cmd.Parameters.AddWithValue("@bookName", oduncDB.BookName);
            cmd.Parameters.AddWithValue("@bookAuthor", oduncDB.BookAuthor);
            cmd.Parameters.AddWithValue("@dateOfGive", oduncDB.DateOfGive);
            cmd.Parameters.AddWithValue("@dateOfTake", oduncDB.DateOfTake);
            cmd.Parameters.AddWithValue("@isTaken", oduncDB.IsTaken);
            cmd.Parameters.AddWithValue("@dateOfTaken", oduncDB.DateOfTaken);
            cmd.ExecuteNonQuery();
        }
        public static void UpdateDataView(DataGridView view, bool isBook)
        {
            using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
            {
                sqlite.Open();
                var command = sqlite.CreateCommand();
                if (isBook)
                {
                    command.CommandText = @"SELECT * FROM Books";
                    using(var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            List<string> data = new List<string>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                data.Add(reader.GetString(i));
                            }
                            view.Rows.Add(data.ToArray());
                        }
                    }
                }
                else
                {
                    command.CommandText = @"SELECT * FROM Persons";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            List<string> data = new List<string>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                data.Add(reader.GetString(i));
                            }
                            view.Rows.Add(data.ToArray());
                        }
                    }
                }
            }
        }
        public static void UpdateOduncDataView(DataGridView view)
        {
            using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
            {
                sqlite.Open();
                var command = sqlite.CreateCommand();
                command.CommandText = @"SELECT * FROM Odunc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        List<string> data = new List<string>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            data.Add(reader.GetString(i));
                        }
                        view.Rows.Add(data.ToArray());
                    }
                }
            }
        }
        public static void SearchBook(DataGridView view, string filter, string searchValue)
        {
            view.Rows.Clear();
            DataTable dt = new DataTable();
            using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
            {
                sqlite.Open();
                var command = sqlite.CreateCommand();
                command.CommandText = String.Format(@"SELECT * FROM Books WHERE {0} like '%{1}%'",filter,searchValue);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        List<string> data = new List<string>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            data.Add(reader.GetString(i));
                        }
                        view.Rows.Add(data.ToArray());
                    }
                }
            }
        }
        public static void SearchPerson(DataGridView view, string filter, string searchValue)
        {
            view.Rows.Clear();
            DataTable dt = new DataTable();
            using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
            {
                sqlite.Open();
                var command = sqlite.CreateCommand();
                command.CommandText = String.Format(@"SELECT * FROM Persons WHERE {0} like '%{1}%'",filter,searchValue);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        List<string> data = new List<string>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            data.Add(reader.GetString(i));
                        }
                        view.Rows.Add(data.ToArray());
                    }
                }
            }
        }
        public static void SearchOdunc(DataGridView view, string filter, string searchValue)
        {
            view.Rows.Clear();
            DataTable dt = new DataTable();
            using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
            {
                sqlite.Open();
                var command = sqlite.CreateCommand();
                command.CommandText = String.Format(@"SELECT * FROM Odunc WHERE {0} like '%{1}%'",filter,searchValue);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        List<string> data = new List<string>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            data.Add(reader.GetString(i));
                        }
                        view.Rows.Add(data.ToArray());
                    }
                }
            }
        }
        public static BookDB GetBook(string isbn)
        {
            BookDB book = new BookDB();
            using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
            {
                sqlite.Open();
                var command = sqlite.CreateCommand();
                command.CommandText = String.Format(@"SELECT * FROM Books WHERE ISBN = '{0}'",isbn);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        List<string> data = new List<string>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            data.Add(reader.GetString(i));
                        }
                        book.ISBN = data[0];
                        book.BookName = data[1];
                        book.Author = data[2];
                        book.PageCount = data[3];
                        book.Publisher = data[4];
                        book.BookType = data[5];
                        book.TeminType = data[6];
                        book.TeminDate = data[7];
                        book.Donator = data[8];
                        book.StokCount = data[9];
                        book.AddedDate = data[10];
                    }
                }
            }
            return book;
        }
        public static PersonDB GetPerson(string tcno)
        {
            PersonDB person = new PersonDB();
            using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
            {
                sqlite.Open();
                var command = sqlite.CreateCommand();
                command.CommandText = String.Format(@"SELECT * FROM Persons WHERE TCNO = '{0}'",tcno);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        List<string> data = new List<string>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            data.Add(reader.GetString(i));
                        }
                        person.TCNO = data[0];
                        person.Name = data[1];
                        person.Surname = data[2];
                        person.BirthDate = data[3];
                        person.Sex = data[4];
                        person.PhoneNumber = data[5];
                        person.Email = data[6];
                        person.Address = data[7];
                        person.AddedDate = data[8];
                    }
                }
            }
            return person;
        }
        public static OduncDB GetOdunc(string tcno, string isbn)
        {
            OduncDB oduncDB = new OduncDB();
            using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
            {
                sqlite.Open();
                var command = sqlite.CreateCommand();
                command.CommandText = String.Format(@"SELECT * FROM Odunc WHERE TCNO = '{0}' AND ISBN = '{1}'",tcno,isbn);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        List<string> data = new List<string>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            data.Add(reader.GetString(i));
                        }
                        oduncDB.TCNO = data[0];
                        oduncDB.NameSurname = data[1];
                        oduncDB.Sex = data[2];
                        oduncDB.ISBN = data[3];
                        oduncDB.BookName = data[4];
                        oduncDB.BookAuthor = data[5];
                        oduncDB.DateOfGive = data[6];
                        oduncDB.DateOfTake = data[7];
                        oduncDB.IsTaken = data[8];
                        oduncDB.DateOfTaken = data[9];
                    }
                }
            }
            return oduncDB;
        }
        public static void DeleteBook(DataGridView view, string isbn)
        {
            var connection = new SQLiteConnection(cs);
            connection.Open();

            var command = new SQLiteCommand(connection);
            command.CommandText = String.Format("DELETE FROM Books WHERE ISBN = '{0}'",isbn);
            command.ExecuteNonQuery();

            view.Rows.Clear();
            UpdateDataView(view,true);
        }
        public static void DeletePerson(DataGridView view, string tcno)
        {
            var connection = new SQLiteConnection(cs);
            connection.Open();

            var command = new SQLiteCommand(connection);
            command.CommandText = String.Format("DELETE FROM Persons WHERE TCNO = '{0}'",tcno);
            command.ExecuteNonQuery();

            view.Rows.Clear();
            UpdateDataView(view,true);
        }
        public static bool CheckBookExist(string isbn)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = String.Format("SELECT ISBN FROM Books WHERE ISBN = '{0}'",isbn);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    List<string> data = new List<string>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        data.Add(reader.GetString(i));
                    }
                    if(data.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
        public static bool CheckPersonExist(string tcno)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = String.Format("SELECT TCNO FROM Persons WHERE TCNO = '{0}'",tcno);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    List<string> data = new List<string>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        data.Add(reader.GetString(i));
                    }
                    if(data.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
        public static bool CheckOduncExist(string tcno,string isbn)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = String.Format("SELECT TCNO, ISBN FROM Odunc WHERE TCNO = '{0}' AND ISBN = '{1}'",tcno,isbn);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    List<string> data = new List<string>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        data.Add(reader.GetString(i));
                    }
                    if(data.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
