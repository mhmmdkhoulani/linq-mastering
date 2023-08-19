using QuestionRepository;

namespace ElementOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example04();
            Console.ReadKey();
        }

        //ElementAt and ElementAtOrDefault
        static void Example01()
        {
            var questions = QuestionBank.All;
            var questionAt10 = questions.ElementAt(10);
            //var questionAt1000 = questions.ElementAt(1000); //ArgumentOutOfRange exeption
            var questionAt1000 = questions.ElementAtOrDefault(1000); //Will return null without any exception
            Console.WriteLine(questionAt1000);
        }

        //First and FirstOrDefault
        static void Example02()
        {
            var questions = QuestionBank.All;
            var firstQuestion = questions.First();
            Console.WriteLine(firstQuestion);

            //var SomeQuestion = questions.First(x => x.Title.Length == 0); // here if the delegate is not valid then will get an InvalidOperatoinException
            var SomeQuestion = questions.FirstOrDefault(x => x.Title.Length == 0); // Here will return null if the condition is not valid or return null
                                                                                      
            Console.WriteLine(SomeQuestion);
        }

        //Last and LastOrDefault
        static void Example03()
        {
            var questions = QuestionBank.All;
            var lastQuestion = questions.Last();
            Console.WriteLine(lastQuestion);

            //var SomeQuestion = questions.Last(x => x.Title.Length == 0); // here if the delegate is not valid then will get an InvalidOperatoinException
            var SomeQuestion = questions.LastOrDefault(x => x.Title.Length == 0); // Here will return null if the condition is not valid or return null

            Console.WriteLine(SomeQuestion);
        }

        //Last and LastOrDefault
        static void Example04()
        {
            var questions = QuestionBank.All;
            //var question = questions.Single(x => x.Title.Contains("#244"));
            //var question2 = questions.SingleOrDefault(x => x.Title.Contains("#245"));
            //var question3 = questions.Single(x => x.Title.Length == 0);
            var question4 = questions.SingleOrDefault(x => x.Title.Length == 0);
            Console.WriteLine(question3);

           
        }
    }
}