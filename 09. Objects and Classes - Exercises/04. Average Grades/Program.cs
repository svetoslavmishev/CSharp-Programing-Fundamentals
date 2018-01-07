using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {

        class Student
        {
            public string Name { get; set; }
            public double[] Grade { get; set; }
            public double AverageGrade => Grade.Average();
        }

        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> studentList = new List<Student>();


            for (int i = 0; i < numberOfStudents; i++)
            {
                var input = Console.ReadLine().Split();

                Student student = new Student();
                student.Name = input[0];
                student.Grade = input.Skip(1).Select(double.Parse).ToArray();

                studentList.Add(student);
            }
            
            studentList.Where(s => s.AverageGrade >= 5.00)
            .OrderBy(s => s.Name)
            .ThenByDescending(s => s.AverageGrade)
            .ToList().ForEach(s => Console.WriteLine($"{s.Name} -> {s.AverageGrade:f2}")); // za podredeni List

            //foreach (var student in students)                    //  ако не ползваме ламбда --> .ForEach(s => Console.WriteLine($"{s.Name} -> {s.AverageGrade:f2}")
            //{
            //    Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            //}
        }
    }
}