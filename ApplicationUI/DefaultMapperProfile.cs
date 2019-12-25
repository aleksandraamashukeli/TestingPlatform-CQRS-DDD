using AutoMapper;
using Services.Models.UserModels;
using ApplicationUI.Models.UserModels;

namespace ApplicationUI
{
    public class DefaultMapperProfile : Profile
    {
        public DefaultMapperProfile()
        {
            CreateMap<UserRegisterViewModel, UserDTO>();
            CreateMap<UserLoginViewModel, UserDTO>();
            CreateMap<BaseUserModel,UserDTO>();
            CreateMap<UserDTO, UserProfileViewModel>();
        }
    }
}
