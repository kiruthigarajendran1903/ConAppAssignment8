using System;

namespace ConAppAssignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Salary Calculator");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Choose Employee Type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software Developer");

            int employeeType = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter WorkingHours:");
            int WHour=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter working Days");
            int WDays=int.Parse(Console.ReadLine());

            double salary = CalculateSalary(employeeType,WHour,WDays);


            Console.WriteLine("Monthly Salary: " + salary);
            Console.ReadLine();
        }

        static double CalculateSalary(int employeeType, int workingHour , int numberOfWorkingDays , int projectHandles = 1, int extras = 0)
        {
            double monthlySalary = 0;

            switch (employeeType)
            {
                case 1: // HR
                    monthlySalary = workingHour * numberOfWorkingDays * 100;
                    break;
                case 2: // Admin
                    monthlySalary = workingHour * numberOfWorkingDays * 100 + projectHandles * 3000;
                    break;
                case 3: // Software Developer
                    monthlySalary = workingHour * numberOfWorkingDays * 100 + projectHandles * 3000 + extras * 2000;
                    break;
                default:
                    Console.WriteLine("Invalid employee type.");
                    break;
            }

            return monthlySalary;
        }
    }
}
