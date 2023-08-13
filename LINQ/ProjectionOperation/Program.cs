using DataRepository;

namespace ProjectionOperation;
class Program
{
    static void Main(string[] args)
    {
        RunExample02();
        Console.ReadKey();
    }

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

        });


        foreach (var number in result)
        {
            Console.WriteLine(number);
        }
    }

    class EmployeeDto
    {

    }
}


