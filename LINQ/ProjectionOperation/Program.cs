using DataRepository;

namespace ProjectionOperation;
class Program
{
    static void Main(string[] args)
    {
        RunExample06();
        Console.ReadKey();
    }

    //Select
    private static void RunExample01()
    {
        List<string> words = new List<string> { "I", "love", "asp.net", "core" };

        var result = words.Select(x => x.ToUpper());

        var result01 = from w in words
                       select w.ToUpper();
        foreach (var word in result)
        {
            Console.WriteLine(word);
        }
    }

    private static void RunExample02()
    {
        List<int> numbers = new() { 1, 2, 3, 4, 5, 6 };

        var result = numbers.Select(x => x * x);

        var result01 = from n in numbers
                       select n * n;

        foreach (var number in result)
        {
            Console.WriteLine(number);
        }
    }

    private static void RunExample03()
    {
        var employees = Repository.LoadEmployees();
        List<int> numbers = new() { 1, 2, 3, 4, 5, 6 };

        var result = employees.Select(x => {
            return new EmployeeDto
            {
                Name = $"{x.FirstName} {x.LastName}",
                Price = x.Salary
            };
        });


        foreach (var employee in result)
        {
            Console.WriteLine(employee);
        }
    }

    //Select Many
    private static void RunExample04()
    {
        string[] sentences =  { 
            "I love asp.net core",
            "I aslo love sql server",
            "In general I love programming"
        };
        var result = sentences.SelectMany(x => x.Split(' '));
        
        var result2 = from sentence in sentences
                      from words in sentence
                      select words;

        foreach (var word in result)
        {
            Console.WriteLine(word);
        }
    }

    //Zip
    private static void RunExample05()
    {
        string[] colorName = { "Red", "Green", "Blue" };
        string[] colorHEX = { "FF0000", "00FF00", "0000FF" };

        var colors = colorName.Zip(colorHEX, (name, hex) => $"{name} ({hex})");
        foreach (var color in colors)
        {
            Console.WriteLine(color);
        }
    }

    private static void RunExample06()
    {
        var employees = Repository.LoadEmployees().ToArray();
        var firstThreeEmployees = employees[..3];
        var lastThreeEmployees = employees[^3..];

        var teams = firstThreeEmployees.Zip(lastThreeEmployees, (first, last) => $"[{first.FirstName} with {first.FirstName}]");

        
        foreach (var team in teams)
        {
            Console.WriteLine(team);
        }
    }

}


