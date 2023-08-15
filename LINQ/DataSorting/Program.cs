using DataRepository;

namespace DataSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example04();
            Console.ReadKey();
        }

        static void Example01()
        {
            string[] fruits = { "apricot", "orange", "banana", "mango", "apple", "grape", "strawberry" };

            var orderFruits = fruits.OrderBy(f => f); //ASC
            orderFruits.Print("Fruit Asc order (Method)");

            var orderFruits01 = from f in fruits
                                orderby f
                                select f;
            orderFruits01.Print("Fruit Asc order (Query)");

            var orderFruitsDesc = fruits.OrderByDescending(f => f); //Desc
            orderFruitsDesc.Print("Fruit Desc order (Method)");

        }


        //Primary and Secondary sorting
        static void Example02()
        {
            var emps = Repository.LoadEmployees();

            var sortedEmps = emps.OrderBy(x => x.FirstName).ThenBy(x => x.Salary); //Asc

            sortedEmps.Print("Sorted employess by first name then salary");

            var sortedEmpsDes = emps.OrderBy(x => x.FirstName).ThenByDescending(x => x.Salary); //Desc

            sortedEmpsDes.Print("Sorted employess by first name then salary Desc");


        }

        //Custom Compare
        static void Example03()
        {
            IEnumerable<Employee> employees = Repository.LoadEmployees();
            //IOrderedEnumerable<Employee> sortedEmps = employees.OrderBy(e => e.EmployeeNumber);
            IOrderedEnumerable<Employee> sortedEmps = employees.OrderBy(e => e, new EmployeeComparer());

            sortedEmps.Print("Sorted Emps by employee number");
        }

        //Reverse 
        static void Example04()
        {
            string[] fruits = { "apricot", "orange", "banana", "mango", "apple", "grape", "strawberry" };
            var reverseOrder = fruits.Reverse();
            reverseOrder.Print("Reverse Order");
        }

    }
}