using System.Transactions;

namespace Ovning1
{
    internal class Program
    {
        public static string[] EmployeeName;
        public static int[] EmployeeWage;
        public static int EmployeeID;
        public static int numberOfEmployees = 0;
        static void Main(string[] args)
        {
            static void Main(string[] args)
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
                bool exit = false;
                while (exit == false)
                {
                    switch (number)
                    {
                        case 1:

                            numberOfEmployees++;

                            Console.WriteLine("Enter emplyees name:");
                            EmployeeName[EmployeeID] = Console.ReadLine();

                            Console.WriteLine("Enter emplyees wage:");
                            EmployeeWage[EmployeeID] = int.Parse(Console.ReadLine());

                            break;
                        case 2:
                            Console.WriteLine("List of employees:");
                            for(var NumberEmployees = 0; NumberEmployees == numberOfEmployees; NumberEmployees--)
                            {
                                Console.WriteLine("Employee ID: {0}", NumberEmployees);
                                Console.WriteLine(EmployeeName);
                                Console.WriteLine("Wage: {0}", EmployeeWage);
                            }
                            break;
                        case 3:
                            exit = false;

                            break;
                        default:
                            break;
                    }
                   
                }
            }

        }

    }
}