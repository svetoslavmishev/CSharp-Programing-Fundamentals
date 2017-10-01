using System;

namespace _08.Employee_Data
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalId = long.Parse(Console.ReadLine());
            int employeeNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("First name: " + firstName + Environment.NewLine + "Last name: " + lastName + Environment.NewLine +
                "Age: " + age + Environment.NewLine + "Gender: " + gender + Environment.NewLine + "Personal ID: " + personalId +
                Environment.NewLine + "Unique Employee number: " + employeeNumber);
        }
    }
}
