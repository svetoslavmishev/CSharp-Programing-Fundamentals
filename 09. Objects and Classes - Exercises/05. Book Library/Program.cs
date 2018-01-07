using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
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
   
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> Book = new List<Book>();
            
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();

                Book books = new Book();
                books.Title = line[0];
                books.Author = line[1];
                books.Publisher = line[2];
                books.ReleaseDate = DateTime.ParseExact(line[3], "d.M.yyyy", CultureInfo.InvariantCulture);
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
            // Print the total sum of prices by author, ordered descending by price and then by author’s name lexicographically.
            // dict.OrderByDescending(b => b.Value).ThenBy(b => b.Key); - taka izneseno ne sraboti, zashtoto trqbwa da e zapazeno v promenliva

            foreach (var item in dict.OrderByDescending(b => b.Value).ThenBy(b => b.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}