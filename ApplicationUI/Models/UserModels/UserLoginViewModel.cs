using System.ComponentModel.DataAnnotations;

namespace ApplicationUI.Models.UserModels
{
    public class UserLoginViewModel : BaseUserModel
    {
        [Display(Name ="Remember me")]
        public bool RememberMe { get; set; }
    }
}
