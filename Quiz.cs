namespace QuizOOP;

public class Quiz(Question[] questions)
{
    private readonly Question[] _questions = questions;
    private int _questionsAsked;     
    public int TotalScore { get; private set; }
    private Random _random = new Random();
    

    public void Start()
    {
        _questionsAsked = 0;

        while (_questionsAsked < _questions.Length)
        {
            int index = _random.Next(_questions.Length);
            var question = _questions[index];

            if (question.IsAsked) continue;
                       
            Console.WriteLine($"Question: {question.Text} ({question.Points} points)");
            string userAnswer = Console.ReadLine();

            if (userAnswer.Equals(question.Answer, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correct!");
                TotalScore += question.Points;
            }
            else
            {
                Console.WriteLine($"Wrong! The correct answer is {question.Answer}.");
            }

            question.IsAsked = true;
            _questionsAsked++;
        }

        Console.WriteLine($"Quiz over! Your score: {TotalScore}");
    }
}
