using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Average_Grades
{
    namespace _08.Average_Grades
    {
        class StartUp
        {
            class Student
            {
                public string Name { get; set; }
                public double[] Grade { get; set; }
                public double AverageGrade => Grade.Average();
            }

            static void Main()
            {
                var input = File.ReadAllLines("../../input.txt");
                List<Student> studentList = new List<Student>();

                int numberOfStudents = int.Parse(input[0]);

                for (int i = 1; i <= numberOfStudents; i++)
                {
                    var studentInfo = input[i].Split().ToArray();

                    Student student = new Student();
                    student.Name = studentInfo[0];
                    student.Grade = studentInfo.Skip(1).Select(double.Parse).ToArray();

                    studentList.Add(student);
                }

                var modifiedList = studentList.Where(s => s.AverageGrade >= 5.00)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrade)
                .ToList();

                var printList = new List<string>();

                foreach (var s in modifiedList)
                {
                    printList.Add($"{s.Name} -> {s.AverageGrade:f2}");
                }

                File.WriteAllLines("../../output.txt", printList);

            }
        }
    }
}