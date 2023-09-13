namespace Ovning1
{
    internal class PayRoll
    {   // List name employees, parameters for every
        // employee is found in "Employees".
        private List<Employee> employees;

        // Constructor
        public PayRoll()
        {
            employees = new List<Employee>();
        }

        // Method for functions to add employees.
        internal void AddEmployees(string name, int salary)
        {
            //.Add adds paraneters to end of a list.
            employees.Add(new Employee(name, salary));
        }

        internal List<Employee> GetEmployees()
        {
            //Not good practise, FIX.
            return employees;
        }

    }
}