namespace DevQuiz.WEB.Models
{
    public class Question
    {
        public string Text { get; set; }
        public List<string> Answer { get; set; }
        public int RightAnswer { get; set; }
    }

}
