using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08.Mentor_Group
{
    class Student
    {
        public List<string> Comments { get; set; }
        public List<DateTime> DatesAttended { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Student> studentsList = new SortedDictionary<string, Student>();
            var line = Console.ReadLine();

            while (line != "end of dates")
            {
                var input = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                List<DateTime> attended = new List<DateTime>();

                if (input.Length > 1)
                {
                    string[] date = input[1].Split(',');

                    for (int i = 0; i < date.Length; i++)
                    {
                        DateTime current = DateTime.ParseExact(date[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                        attended.Add(current);
                    }
                }

                Student student = new Student();

                if (!studentsList.ContainsKey(name))
                {
                    studentsList.Add(name, student);
                    student.DatesAttended = attended;
                    student.Comments = new List<string>();
                }
                else
                {
                    studentsList[name].DatesAttended.AddRange(attended);
                }

                line = Console.ReadLine();
            }

            var nextLine = Console.ReadLine();

            while (nextLine != "end of comments")
            {
                List<string> comments = new List<string>();

                var input = nextLine.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                var users = input[0];
                var comment = input[1];

                comments.Add(comment);

                if (studentsList.ContainsKey(users))
                {
                    if (studentsList[users].Comments.Count > 0)
                    {
                        studentsList[users].Comments.AddRange(comments);
                    }
                    else
                    {
                        studentsList[users].Comments = comments;
                    }
                }

                nextLine = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Student> s in studentsList)
            {
                string user = s.Key;
                Student student = s.Value;

                //List<DateTime> datesAttended = student.DatesAttended;
                //List<string> comments = student.Comments;

                Console.WriteLine(user);
                Console.WriteLine("Comments:");

                foreach (var comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");

                foreach (DateTime date in student.DatesAttended.OrderBy(d => d))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }
        }
    }
}
