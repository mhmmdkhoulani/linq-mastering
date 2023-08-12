using DataRepository;
using System.Collections;

namespace LinqCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();

            //My impelmentation of filter vs LINQ Where method

            //var femaleWithFirstNameStartWithS01 = employees.Filter(x => x.FirstName.ToLower().StartsWith("s") && x.Gender == "female");
            //femaleWithFirstNameStartWithS01.Print("Female WithFirst Name Starts With S / Filter");

            //var femaleWithFirstNameStartWithS02 = employees.Where(x => x.FirstName.ToLower().StartsWith("s") && x.Gender == "female");
            //femaleWithFirstNameStartWithS02.Print("Female WithFirst Name Starts With S / Where");



            //How to write Linq 
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            ////1
            //var evenNumbersUsingExtensionWhere = numbers.Where(n => n % 2 == 0);
            //evenNumbersUsingExtensionWhere.Print("Even Numbers Using Extension Where");

            ////2
            //var evenNumbersUsingEnumerableWhereMethod = Enumerable.Where(numbers, n => n % 2 == 0);
            //evenNumbersUsingEnumerableWhereMethod.Print("Even Numbers Using Enumerable Where Method");

            ////3
            //var evenNumbersUsingQuerySyntax = from n in numbers
            //                                  where n % 2 == 0
            //                                  select n;
            //evenNumbersUsingQuerySyntax.Print("Even Numbers Using Query Syntax");


            var empMale = employees.Where(e => e.Gender.ToLower() == "male");
            empMale.Print("Male Employees");
            var empSalaryOver300K = employees.Where(e => e.Salary >= 300_000);
            empSalaryOver300K.Print("Empolyees with salary more than 300K");

            Console.ReadKey();
        }
    }
}