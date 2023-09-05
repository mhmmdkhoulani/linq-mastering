using QuestionRepository;

namespace EqualityOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example03();
            Console.ReadKey();
        }

        static void Example01()
        {
            var q1 = QuestionBank.PickOne();
            var q2 = QuestionBank.PickOne();
            var q3 = QuestionBank.PickOne();

            var quiz1 = new List<Question>( new[] {q1, q2, q3 });  
            var quiz2 = new List<Question>( new[] {q1, q2, q3 });

            var equal = quiz1.SequenceEqual(quiz2);
            Console.WriteLine($"Quiz1 and Quiz2 {(equal? "are" : "are not")} equal");
        }

        static void Example02()
        {
            var randomFourQustion = QuestionBank.GetQuestionRange(Enumerable.Range(1,4));

            var quiz1 = randomFourQustion;
            var quiz2 = randomFourQustion;

            var equal = quiz1.SequenceEqual(quiz2);
            Console.WriteLine($"Quiz1 and Quiz2 {(equal ? "are" : "are not")} equal");
        }

        static void Example03()
        {

            var quiz1 = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4));
            var quiz2 = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4));

            var equal = quiz1.SequenceEqual(quiz2);
            Console.WriteLine($"Quiz1 and Quiz2 {(equal ? "are" : "are not")} equal");
        }
    }
}