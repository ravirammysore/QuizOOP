namespace QuizOOP;

public class Question(string text, string answer, int points)
{    
    public string Text { get; } = text;
    public string Answer { get; } = answer;
    public int Points { get; } = points;
    public bool IsAsked { get; set; }        
    
}