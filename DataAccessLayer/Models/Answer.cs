namespace DataAccessLayer.Models
{
    public class Answer : Entity
    {
        public string BackgroundImage { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }
}