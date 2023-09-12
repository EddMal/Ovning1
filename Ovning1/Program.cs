using System.Transactions;

namespace Ovning1
{
    internal class Program
    {
        public const int maxNumberOfEmployees = 100;
        public const int maxNumberLetters = 30;
        public static string[] EmployeeName = new string[maxNumberLetters];
        public static int[] EmployeeWage = new int[maxNumberOfEmployees];
        public static int numberOfEmployees = 0;
        public static bool exit = false;
        static void Main(string[] args)
        {
            
            while (exit == false)
            {
                Console.WriteLine("Register Options:");
                Console.WriteLine("1. Register employee with name and wage.");
                Console.WriteLine("2. Print list.");
                Console.WriteLine("3. Exit.");
                int number = int.Parse(Console.ReadLine());
                register.SelectOption(number);
            }
        }


        class register
        {
            public static void SelectOption(int number)
            {         
                switch (number)
                {
                    case 1:
                        numberOfEmployees++;

                        Console.WriteLine("Enter emplyees name:");
                        EmployeeName[numberOfEmployees] = Console.ReadLine();
                        Console.WriteLine("Enter emplyees wage:");
                        EmployeeWage[numberOfEmployees] = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("List of employees:");
                        for(var NumberEmployees = numberOfEmployees; NumberEmployees > 0; NumberEmployees--)
                        {
                            Console.WriteLine("Employee ID: {0}", NumberEmployees);
                            Console.WriteLine("Name : {0}", EmployeeName[NumberEmployees]);
                            Console.WriteLine("Wage: {0}", EmployeeWage[NumberEmployees]);
                        }
                        break;
                    case 3:
                        exit = true;
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();

            }

        }

    }
}