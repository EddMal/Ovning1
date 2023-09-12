using System.Transactions;

namespace Ovning1
{
    internal class Program
    {
        public static string[] EmployeeName;
        public static int[] EmployeeWage;
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Register Options:");
                Console.WriteLine("1. Register employee with name and wage.");
                Console.WriteLine("2. Print list.");
                Console.WriteLine("3. Exit.");
                int number = (int)Console.ReadLine();
                register.SelectOption(number);
            }


        }


        class register
        {
            private static void SelectOption(int number)
            {
                while bool (Exit == false)
                {

                }
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Enter emplyees name:");
                        EmployeeName = Console.ReadLine();

                        Console.WriteLine("Enter emplyees wage:");
                        EmployeeWage = Console.ReadLine();

                        break;
                    case 2:
                        foreach (var NumberEmployees in listEmployees)
                        {
                            Console.WriteLine("Employee: ");
                            Console.WriteLine(EmployeeName);
                            Console.WriteLine("Wage: {0}", EmployeeWage);
                            break;
                    case 3:


                        break;
                    default:
                        break;
                }
            }

        }

    }
}