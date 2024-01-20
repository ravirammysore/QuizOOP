
using QuizOOP;

Console.Clear();
Console.WriteLine("Let's beging first quiz!");

var questions = QuestionsParser.ReadQuestionsFromFile("bolly.json");

var bollyQuiz = new Quiz(questions);
bollyQuiz.Start();

Console.WriteLine("---------------------------------------");

Console.WriteLine("Let's beging another quiz!");

questions = QuestionsParser.ReadQuestionsFromFile("geo.json");

var geoQuiz = new Quiz(questions);
geoQuiz.Start();

Console.WriteLine("---------------- Bye! --------------------");