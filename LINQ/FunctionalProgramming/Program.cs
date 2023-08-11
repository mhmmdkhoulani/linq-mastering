namespace FunctionalProgramming
{
    //delegate void MDelegate();
    //Action void no paramater
    //Func return a value and take paramaters
    //Pred return bool and take paramters
    internal class Program
    {
        static void Main(string[] args)
        {
            //M2(() => M1());
            //RunExtensionProcedural();
            //RunExtensionFunctional01();
            RunExtensionFunctional02();
            Console.ReadKey();
        }


        //static void M1()
        //{
        //    Console.WriteLine("M1");
        //}
        //static void M2(Action action)
        //{
        //    action();
        //    Console.WriteLine("M2");
        //}

        private static void RunExtensionProcedural()
        {
            var q1 = ExtnensionProcedural.GetEmployeesWithFirstNameStartsWith("ma");
            ExtnensionProcedural.Print(q1, "Employees with first name starts with 'ma'");

            var q2 = ExtnensionProcedural.GetEmployeesWithLastNameStartsWith("ju");
            ExtnensionProcedural.Print(q2, "Employees with last name starts with 'ju'");

            var q3 = ExtnensionProcedural.GetEmployeesWithDepartmentEqualsTo("hr");
            ExtnensionProcedural.Print(q3, "Employees in 'HR' department");

            var q4 = ExtnensionProcedural.GetEmployeesByGender("female");
            ExtnensionProcedural.Print(q4, "Female employees");

            var q5 = ExtnensionProcedural.GetEmployeesHiredInYear(2018);
            ExtnensionProcedural.Print(q5, "Employees hired in '2018'");

            var q6 = ExtnensionProcedural.GetEmployeesWithPensionPlanValueEqualsTo(true);
            ExtnensionProcedural.Print(q6, "Employees with Pension Plan");

            var q7 = ExtnensionProcedural.GetEmployeesWithHealthInsuranceValueEqualsTo(false);
            ExtnensionProcedural.Print(q7, "Employees without Health insurance");

            var q8 = ExtnensionProcedural.GetEmployeesWithSalaryEqualsTo(103200);
            ExtnensionProcedural.Print(q8, "Employees with Salary = $103200");

            var q9 = ExtnensionProcedural.GetEmployeesWithSalaryGreaterThan(107000);
            ExtnensionProcedural.Print(q9, "Employees with Salary > $107000");

            var q10 = ExtnensionProcedural.GetEmployeesWithSalaryLessThan(107000);
            ExtnensionProcedural.Print(q10, "Employees with Salary < $107000");

        }
        private static void RunExtensionFunctional01()
        {
            var employees = Repository.LoadEmployees();
            var q1 = ExtensionFunctional01.Filter(employees, e => e.FirstName.ToLowerInvariant().StartsWith("ma"));
            ExtensionFunctional01.Print(q1, "Employees with first name starts with 'ma'");

            var q2 = ExtensionFunctional01.Filter(employees, e => e.LastName.ToLowerInvariant().StartsWith("ju"));
            ExtensionFunctional01.Print(q2, "Employees with last name starts with 'ju'");

            var q3 = ExtensionFunctional01.Filter(employees, e => e.Department.ToLowerInvariant() == "hr");
            ExtensionFunctional01.Print(q3, "Employees in 'HR' department");

            var q4 = ExtensionFunctional01.Filter(employees, e => e.Gender.ToLowerInvariant() == "female".ToLowerInvariant());
            ExtensionFunctional01.Print(q4, "Female employees");

            var q5 = ExtensionFunctional01.Filter(employees, e => e.HireDate.Year == 2018);
            ExtensionFunctional01.Print(q5, "Employees hired in '2018'");

            var q6 = ExtensionFunctional01.Filter(employees, e => e.HasPensionPlan == true);
            ExtensionFunctional01.Print(q6, "Employees with Pension Plan");

            var q7 = ExtensionFunctional01.Filter(employees, e => e.HasHealthInsurance == false);
            ExtensionFunctional01.Print(q7, "Employees without Health insurance");

            var q8 = ExtensionFunctional01.Filter(employees, e => e.Salary == 103200);
            ExtensionFunctional01.Print(q8, "Employees with Salary = $103200");

            var q9 = ExtensionFunctional01.Filter(employees, e => e.Salary > 103200);
            ExtensionFunctional01.Print(q9, "Employees with Salary > $107000");

            var q10 = ExtensionFunctional01.Filter(employees, e => e.Salary < 103200);
            ExtensionFunctional01.Print(q10, "Employees with Salary < $107000");

        }

        private static void RunExtensionFunctional02()
        {
            var employees = Repository.LoadEmployees();
            var q1 = employees.Filter(e => e.FirstName.ToLowerInvariant().StartsWith("ma"));
            q1.Print( "Employees with first name starts with 'ma'");

            var q2 = employees.Filter(e => e.LastName.ToLowerInvariant().StartsWith("ju"));
            q2.Print( "Employees with last name starts with 'ju'");

            var q3 = employees.Filter( e => e.Department.ToLowerInvariant() == "hr");
            q3.Print( "Employees in 'HR' department");

            var q4 = employees.Filter( e => e.Gender.ToLowerInvariant() == "female".ToLowerInvariant());
            q4.Print( "Female employees");

            var q5 = employees.Filter( e => e.HireDate.Year == 2018);
            q5.Print( "Employees hired in '2018'");

            var q6 = employees.Filter( e => e.HasPensionPlan == true);
            q6.Print( "Employees with Pension Plan");

            var q7 = employees.Filter( e => e.HasHealthInsurance == false);
            q7.Print( "Employees without Health insurance");

            var q8 = employees.Filter( e => e.Salary == 103200);
            q8.Print( "Employees with Salary = $103200");

            var q9 = employees.Filter( e => e.Salary > 103200);
            q9.Print( "Employees with Salary > $107000");

            var q10 = employees.Filter(e => e.Salary < 103200);
            q10.Print("Employees with Salary < $107000");

        }
    }
}