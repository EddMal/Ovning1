using System.Transactions;

namespace Ovning1
{
    internal class Program
    {

        private static PayRoll payRoll;
        static void Main(string[] args)
        {
            payRoll = new PayRoll();

            while (true)
            {
                ShowMenu();
                String menuInput = Console.ReadLine();
                SelectOption(menuInput);
            }
        }
        private static void ShowMenu()
        {

            Console.WriteLine("Register Options:");
            Console.WriteLine("1. Register employee with name and wage.");
            Console.WriteLine("2. Print list.");
            Console.WriteLine("3. Exit.");
        }

        private static void SelectOption(string menuInput)
        {
            switch (menuInput)
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