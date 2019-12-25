namespace DataAccessLayer.Models
{
    public class Answer : Entity
    {
        public AnswerBody AnswerBody { get; set; }

        public string Body { get; set; }

        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }

        public Question Question { get; set; }
    }
}