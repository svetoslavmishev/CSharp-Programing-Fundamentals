using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Book_Library
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
                books.ReleaseDate = DateTime.ParseExact(line[3], "dd.MM.yyyy",CultureInfo.InvariantCulture);
                books.ISBN = line[4];
                books.Price = double.Parse(line[line.Length - 1]);
                Book.Add(books);
            }

            Library library = new Library() { Name = "National Library", Book = Book };

            Dictionary<string, double> dict = new Dictionary<string, double>();

            foreach (var eachBook in library.Book)
            {
                if (!dict.ContainsKey(eachBook.Author))
                {
                    dict[eachBook.Author] = eachBook.Price;
                }
                else
                {
                    dict[eachBook.Author] += eachBook.Price;
                }
            }

            foreach (var item in dict.OrderByDescending(b => b.Value).ThenBy(b => b.Key))
            {
                string output = $"{item.Key} -> {item.Value:F2}" + Environment.NewLine;
                File.AppendAllText("../../output.txt", output);
            }            
        }
    }
}





