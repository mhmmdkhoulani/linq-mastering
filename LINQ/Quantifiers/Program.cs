using DataRepository;

namespace Quantifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example03();
            Console.ReadKey();
        }


        //Any
        static void Example01()
        {
            var employees = Repository.LoadEmployees();

            //Check if there is an employee with Name starts with 'jac'
            var result = employees.Any(x => x.FirstName.StartsWith("jac", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(result);
        }

        //All
        static void Example02()
        {
            var employees = Repository.LoadEmployees();

            //Check if all employees have value for email
            var result = employees.All(x => (!string.IsNullOrWhiteSpace(x.EmployeeNumber)));
            Console.WriteLine(result);
        }

        //Contains
        static void Example03()
        {
            var employees = Repository.LoadEmployees();

            //Check if all employees have value for email
            var result = employees.Any(x => x.FirstName.Contains("ee"));
            Console.WriteLine(result);

            var employee = new Employee { FirstName = "Cochran" };

            var result2 = employees.Contains(employee);
            Console.WriteLine(result2); // Here will give us false until we implement the equality on the Employee class because it's refrence type
        }
    }
}