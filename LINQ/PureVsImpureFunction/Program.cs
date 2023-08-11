namespace PureVsImpureFunction;
class Program
{
    static List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
    static void Main(string[] args)
    {
        Print(numbers);
        //AddInteger1(3);

        //var x = 2;
        //AddInteger2(ref x);
        //AddInteger3();
        AddInteger4(numbers, 4);
        Print(numbers);
        
    }

    static void Print(List<int> source)
    {
        foreach (var item in source)
        {
            Console.Write($" {item}");
        }
        Console.WriteLine();
    }

    static void AddInteger1(int number)
    {
        numbers.Add(number); //impure mutate global variable
    }

    static void AddInteger2(ref int num)
    {
        num++;
        numbers.Add(num); //impure mutate parameter
    }

    static void AddInteger3()
    {
        numbers.Add(new Random().Next()); //impure interaction with outside world
    }

    static List<int> AddInteger4(List<int> numbers, int num)
    {
        var result = new List<int>(numbers);
        result.Add(num);
        return result;
    }
}

