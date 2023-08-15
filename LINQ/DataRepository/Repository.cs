using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public  class Repository
    {
        public static IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee>
            {
                new Employee
                {
                        Id = 1001,
                        EmployeeNumber = "2017-FI-1222",
                        FirstName = "Cochran",
                        LastName = "Cole",
                        HireDate = new DateTime(2017, 11, 2),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 103200m
                },
                new Employee
                {
                        Id = 1002,
                        EmployeeNumber = "2013-FI-1322",
                        FirstName = "Jaclyn",
                        LastName = "Wolfe",
                        HireDate = new DateTime(2018, 4, 14),
                        Gender = "female",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 192400m
                },
                new Employee
                {
                        Id = 1003,
                        EmployeeNumber = "2017-IT-1232",
                        FirstName = "Warner",
                        LastName = "Jones",
                        HireDate = new DateTime(2016, 12, 13),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 172800m
                },
                new Employee
                {
                        Id = 1004,
                        EmployeeNumber = "2018-FI-1292",
                        FirstName = "Hester",
                        LastName = "Evans",
                        HireDate = new DateTime(2016, 8, 17),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 155500m
                },
                new Employee
                {
                        Id = 1005,
                        EmployeeNumber = "2017-IT-1229",
                        FirstName = "Wallace",
                        LastName = "Buck",
                        HireDate = new DateTime(2014, 5, 12),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 315800m
                },
                new Employee
                {
                        Id = 1006,
                        EmployeeNumber = "2016-IT-1220",
                        FirstName = "Acevedo",

                        LastName = "Wall",
                        HireDate = new DateTime(2020, 10, 30),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 343700m
                },
                new Employee
                {
                        Id = 1007,
                        EmployeeNumber = "2019-IT-1120",

                        FirstName = "Jacqueline",
                        LastName = "Pickett",
                        HireDate = new DateTime(2021, 2, 17),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 370000m
                },
                new Employee
                {
                        Id = 1008,
                        EmployeeNumber = "2019-HR-1200",

                        FirstName = "Oconnor",
                        LastName = "Espinoza",
                        HireDate = new DateTime(2017, 3, 12),
                        Gender = "male",
                        Department = "HR",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 155600m
                },
                new Employee
                {
                        Id = 1009,
                        EmployeeNumber = "2012-AC-1320",

                        FirstName = "Allie",
                        LastName = "Elliott",
                        HireDate = new DateTime(2020, 4, 20),
                        Gender = "female",
                        Department = "Accounting",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 315400m
                },
                new Employee
                {
                        Id = 1010,
                        EmployeeNumber = "2015-HR-1420",

                        FirstName = "Elva",
                        LastName = "Decker",
                        HireDate = new DateTime(2016, 9, 6),
                        Gender = "female",
                        Department = "HR",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 345900m
                },
                new Employee
                {
                        Id = 1011,
                        EmployeeNumber = "2015-HR-1450",
                        FirstName = "Hayes",
                        LastName = "Beasley",
                        HireDate = new DateTime(2020, 4, 25),
                        Gender = "male",
                        Department = "HR",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 372700m
                },
                
            };
        }
    }
}
