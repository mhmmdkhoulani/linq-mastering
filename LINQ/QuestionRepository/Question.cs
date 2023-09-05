namespace QuestionRepository
{
    public class Question
    {


        public string Title { get; set; }
        public List<Choice> Choices { get; set; } = new();

        public int CorrectAnswer { get; set; }


        // Question.Default
        public readonly static Question Default = new Question
        {
            Title = "<<<<< QUESTION TITLE GOES HERE >>>>>",
            Choices = new List<Choice>
            {
                new Choice { Order = 1, Description = "<<<<< CHOICE #1 GOES HERE >>>>>" },
                new Choice { Order = 2, Description = "<<<<< CHOICE #2 GOES HERE >>>>>" },
                new Choice { Order = 3, Description = "<<<<< CHOICE #3 GOES HERE >>>>>" },
                new Choice { Order = 4, Description = "<<<<< CHOICE #4 GOES HERE >>>>>" }
            },
            CorrectAnswer = 0
        };


        public override string ToString()
        {
            var choices = "";

            foreach (var item in Choices)
            {
                choices += $"\n\t{item.Order}) {item.Description}";
            }

            return $"{Title}" +
                   $"{choices}";
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            Question question = (Question)obj;

            return Title.Equals(question.Title)
                && CorrectAnswer == question.CorrectAnswer
                && Choices.SequenceEqual(question.Choices);
        }

        public override int GetHashCode()
        {

            int hash = 17;
            hash = hash * 23 + Title.GetHashCode();
            hash = hash * 23 + CorrectAnswer.GetHashCode();
            hash = hash * 23 + Choices.GetHashCode();

            return hash;
        }
    }
}