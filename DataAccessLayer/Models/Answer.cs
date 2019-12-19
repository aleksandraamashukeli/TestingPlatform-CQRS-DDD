namespace DataAccessLayer.Models
{
    public class Answer
    {
        public int Id { get; set; }

        public AnswerBody AnswerBody { get; set; }

        public string Body { get; set; }

        public bool IsCorrect { get; set; }



        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}