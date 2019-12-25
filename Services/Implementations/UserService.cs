using AutoMapper;
using DataAccessLayer;
using DataAccessLayer.Models;
using Services.Interfaces;
using Services.Mapper;
using Services.Models.UserModels;
using System.Linq;

namespace Services.Implementations
{
    public class UserService : IUserService
    {
        private IRepository<User> _repository { get; set; }
        private IMapper _mapper { get; set; }

        public UserService(IRepository<User> repository)
        {
            _repository = repository;
            _mapper = ServicesMapperConfiguration.GetMapper();
        }

        public  void RegisterUser(UserDTO createUserModel)
        {
            var user = _mapper.Map<User>(createUserModel);
            _repository.Add(user);
        }

        public bool CanAuthenticate(UserDTO readUserModel)
        {
            var user = _mapper.Map<User>(readUserModel);
            foreach (var item in _repository.GetAll())
            {
                if (user.Email == item.Email && user.Password == item.Password)
                {
                    return true;
                }
            }
            return false;
        }

        public void EditUser(UserDTO editUserModel)
        {
            var user = _mapper.Map<User>(editUserModel);
            _repository.Edit(user);
        }

        public UserDTO GetUser(UserDTO userModel)
        {
            var user = _repository.GetAll().FirstOrDefault(u => u.Email == userModel.Email);
            var userDTO = _mapper.Map<UserDTO>(user);
            return userDTO;
        }
    }
}
