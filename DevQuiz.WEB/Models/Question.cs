namespace DevQuiz.WEB.Models
{
    public class Question
    {
        public string Text { get; set; }
        public List<string> Options { get; set; }
        public int CorrectAnswer { get; set; }
    }
}
