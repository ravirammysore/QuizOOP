using System.Text.Json;

namespace QuizOOP;

public class QuestionsParser
{
    public static Question[] ReadQuestionsFromFile(string questionsFile)
    {
        string pathToRoot = @"..\..\..\";
        string filePath = Path.Combine(pathToRoot, questionsFile);
        string json = File.ReadAllText(filePath);

        var questions = JsonSerializer.Deserialize<Question[]>(json);

        if (questions == null)
            throw new InvalidOperationException("Unable to parse questions from the file.");

        return questions;
    }
}
