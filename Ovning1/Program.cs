using System.Transactions;

namespace Ovning1
{
    internal class Program
    {
        // Declare object payRoll of class PayRoll.
        private static PayRoll payRoll;
        static void Main(string[] args)
        {
            // Use constructor PayRoll(), content which is a list "employees".
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
            Console.WriteLine("1. Register employee with name and salary.");
            Console.WriteLine("2. Print list.");
            Console.WriteLine("3. Exit.");
        }

        private static void SelectOption(string menuInput)
        {
            switch (menuInput)
            {
                case "1":
                    RegisterEmployee();
                    break;
                case "2":
                    DisplayPayRoll();
                   
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }

            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

        }

        private static void DisplayPayRoll()
        {
            List<Employee> employees = payRoll.GetEmployees();

            Console.WriteLine("List of employees:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
            }
        }

        private static void RegisterEmployee()
        {
            Console.WriteLine("Enter employee's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter employee's salary: ");
            int salary = InputSalary();
            payRoll.AddEmployees(name, salary);
        }

        private static int InputSalary()
        {
            int salary;
            bool validationPassed = false;
            do
            {
                string salaryInput = Console.ReadLine();
                (validationPassed, salary) = ValidateNumberInputFromString(salaryInput);
            } while (validationPassed == false);

            return salary;

        }
        /// <summary>
        /// This method validates whether string input consist of numbers only.
        /// </summary>
        /// <param>
        /// <c>numberInput</c> is the string input for validation.
        /// </param>
        /// <returns>
        /// <c>validationPassed</c> True if the input of <c>numberInput</c> consist of 
        /// numbers only; otherwise returns false. 
        /// <c>number</c> is the string input converted to int, if string contains
        /// illegal characters the value defaults to 0.
        /// </returns>
        private static (bool, int) ValidateNumberInputFromString(string numberInput)
        {
            int number = 0;
            bool validationPassed = false;
                //check if number contains valid characters (numbers).
                if (!int.TryParse(numberInput, out number))
                {
                    Console.WriteLine($"\"{numberInput}\" is not a valid input, use numbers only:");
                }
                else
                {
                    validationPassed = true;
                }
            // If parsing failed, number will deafult to 0 and validationPassed set to false,
            // else number will be assigned the expected int value and validationPassed true.

            return (validationPassed, number);
        }
    }
}