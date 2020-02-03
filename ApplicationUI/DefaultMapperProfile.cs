using ApplicationUI.Models.TestModels;
using ApplicationUI.Models.UserModels;
using AutoMapper;
using DataAccessLayer.Models;
using Services.Models.AnswerModels;
using Services.Models.QuestionModels;
using Services.Models.TestModels;
using Services.Models.UserModels;

namespace ApplicationUI
{
    public class DefaultMapperProfile : Profile
    {
        public DefaultMapperProfile()
        {
            CreateMap<UserLoginViewModel, SignInUserModel>();
            CreateMap<UserRegisterViewModel, SignUpUserModel>();

            CreateMap<CreateTestViewModel, CreateTestModel>();
            CreateMap<CreateAnswerViewModel, CreateAnswerModel>();
            CreateMap<CreateQuestionViewModel, CreateQuestionModel>();
        }
    }
}
