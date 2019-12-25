using AutoMapper;
using DataAccessLayer.Models;
using Services.Models.UserModels;

namespace Services.Mapper
{
    class ServicesMapperProfiler : Profile
    {
        public ServicesMapperProfiler()
        {
            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();
        }
    }
}
