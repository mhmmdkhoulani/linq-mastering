using DataRepository;

namespace GroupingData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example02();
            Console.ReadKey();
        }

        //GroupBy
        static void Example01()
        {
            var employees = Repository.LoadEmployees();
            var groups = employees.GroupBy(e => e.Department);

            


            var groupsByQuery = from employee in employees
                                group employee by employee.Department;

            foreach (var group in groupsByQuery)
            {
                group.Print($"{group.Key} Group ");
            }
        }

        //ToLookUp
        static void Example02()
        {
            var employees = Repository.LoadEmployees();
            var groups = employees.ToLookup(e => e.Department);
            foreach (var group in groups)
            {
                group.Print($"{group.Key} Lookup ");
            }

        }
    }
}