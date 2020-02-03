namespace ApplicationUI.Models.TestModels
{
    public class CreateAnswerViewModel
    {
        public int QuestionId { get; set; }
        public string BackgroundImage { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
    }
}