using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Book_Library_Modification
{
    class Library
    {
        public string Name { get; set; }
        public List<Book> Book { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }

    class StartUp
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("../../input.txt");
            List<Book> Book = new List<Book>();

            int bookNumber = int.Parse(input[0]);

            for (int i = 1; i <= bookNumber; i++)
            {
                var line = input[i].Split();

                Book books = new Book();
                books.Title = line[0];
                books.Author = line[1];
                books.Publisher = line[2];
                books.ReleaseDate = DateTime.ParseExact(line[3], "dd.M.yyyy", CultureInfo.InvariantCulture);
                books.ISBN = line[4];
                books.Price = double.Parse(line[line.Length - 1]);
                Book.Add(books);
            }

            var date = DateTime.ParseExact(input[input.Length - 1], "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Library library = new Library() { Name = "National Library", Book = Book };

            List<Book> modifiedList = new List<Book>();

            foreach (var book in Book)
            {
                if (date < book.ReleaseDate) // print all titles released after given date, not date <= book.ReleaseDate
                {
                    modifiedList.Add(book);
                }
            }

            var result = modifiedList.OrderBy(b => b.ReleaseDate).ThenBy(b => b.Title);

            foreach (var item in result)
            {
                string output = $"{item.Title} -> {item.ReleaseDate.ToString("dd.MM.yyyy") + Environment.NewLine}";
                File.AppendAllText("../../output.txt", output);
            }
        }
    }
}













