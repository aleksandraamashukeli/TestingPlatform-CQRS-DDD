namespace ApplicationUI.Models.UserModels
{
    public class UserProfileViewModel : BaseUserModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string ProfileImage { get; set; }

        public string OldPassword { get; set; }

        public string NewPassword { get; set; }
    }
}
