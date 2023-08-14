namespace DataRepository
{
    public class EmployeeDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return
                    string.Format($"" +
                  
                    $"Name: {Name}"  +
                    $" Salary: ${Price.ToString("0.00")}");
        }
    }
}
