using EmployeeRepository;

namespace JoinOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example04();
            Console.ReadKey();
        }

        //Join Method Syntax
        static void Example01()
        {
            var employees = Repository.LoadEmployees();
            var departements = Repository.LoadDepartment();

            var result = employees.Join(
                departements, 
                e => e.DepartmentId, 
                d => d.Id, 
                (emp, dep) => new EmployeeDto { FullName = emp.FullName, Departement = dep.Name}
                );

            foreach (var emp in result)
            {
                Console.WriteLine($"{emp.FullName} {emp.Departement}");
            }
        }

        //Join Query Syntax
        static void Example02()
        {
            var employees = Repository.LoadEmployees();
            var departements = Repository.LoadDepartment();

            var result = from emp in employees
                         join dep in departements
                         on emp.DepartmentId equals dep.Id
                         select new EmployeeDto { FullName = emp.FullName, Departement = dep.Name };


            foreach (var emp in result)
            {
                Console.WriteLine($"{emp.FullName} {emp.Departement}");
            }
        }

        //Group Join Method Syntax
        static void Example03()
        {
            var employees = Repository.LoadEmployees();
            var departements = Repository.LoadDepartment();

            var result = departements.GroupJoin(employees, dep => dep.Id, emp => emp.DepartmentId, (dep, emps) => new Group { Departement = dep.Name, Employees = emps.Select(x => x.FullName).ToList() }); ;

            foreach (var group in result)
            {
                Console.WriteLine($"============{group.Departement}===============");
                foreach (var emp in group.Employees)
                {
                    Console.WriteLine($"{emp}");
                }
            }
        }

        //Group Join Query Syntax 
        static void Example04()
        {
            var employees = Repository.LoadEmployees();
            var departements = Repository.LoadDepartment();

            var result = from dep in departements
                         join emp in employees
                         on dep.Id equals emp.DepartmentId into empGroup
                         select empGroup;

            foreach (var group in result)
            {
                Console.WriteLine($"============Group===============");
                foreach (var emp in group)
                {
                    Console.WriteLine($"{emp.FullName}");
                }
            }
        }
    }

   class Group
    {
        public string Departement { get; set; }
        public List<string> Employees { get; set;   }
    }
}