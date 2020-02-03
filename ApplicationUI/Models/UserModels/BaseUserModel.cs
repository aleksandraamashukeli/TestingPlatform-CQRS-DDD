using System.ComponentModel.DataAnnotations;

namespace ApplicationUI.Models.UserModels
{
    public class BaseUserModel
    {
        public int Id { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
