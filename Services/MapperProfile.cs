using AutoMapper;
using Services.Models.AnswerModels;
using Services.Models.QuestionModels;
using Services.Models.TestModels;
using Services.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            
            CreateMap<CreateTestModel, DataAccessLayer.Models.Test>();
            CreateMap< DataAccessLayer.Models.Test, Services.Models.TestModels.DisplayTestModel >();
            CreateMap<CreateQuestionModel, DataAccessLayer.Models.Question>();
            CreateMap<CreateAnswerModel, DataAccessLayer.Models.Answer>();
            CreateMap<SignUpUserModel, DataAccessLayer.Models.User>();
              
        }
    }
}
