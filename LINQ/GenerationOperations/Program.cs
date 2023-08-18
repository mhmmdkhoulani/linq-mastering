using QuestionRepository;

namespace GenerationOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example04();
            Console.ReadKey();
        }

        //Empty
        static void Example01()
        {
            var questions = new List<Question>(); //Empty list
            var questions2 = Enumerable.Empty<Question>(); //Empty list ==> Better
        }
        //DefaultIfEmpty
        static void Example02()
        {
            //Every thing in programming has defualt value
            int x; // 0 is the default value
            //Console.WriteLine(default(int)); // 0
            //Console.WriteLine(default(DateTime)); // 01-01-0001 12:00:00 AM
            //Console.WriteLine(default(Object)); // NULL

            var questions = new List<Question>();
            var questions2 = questions.DefaultIfEmpty(); // here will check if the list is empty will return the default value of question
            var questions3 = questions.DefaultIfEmpty(Question.Default); //will return the default  question

            foreach (var q in questions3)
            {
                questions3.ToQuiz();
            }
        }

        //Range
        static void Example03()
        {
            var range = Enumerable.Range(1, 10);

            //int[] range2 = new int[10];
            //for (int i = 0; i < range2.Length; i++)
            //{
            //    range2[i] = i;

            //}
            //for (int i = 0; i < range2.Length; i++)
            //{
            //    Console.WriteLine(range2[i]);

            //}

            //foreach (var item in range)
            //{
            //    Console.WriteLine(item);
            //}


            var questions = QuestionBank.GetQuestionRange(range);
            questions.ToQuiz();
        }

        //Repeat
        static void Example04()
        {
            var q = QuestionBank.PickOne();
            var questions = Enumerable.Repeat(q,12);
            questions.ToQuiz();
        }
    }
}