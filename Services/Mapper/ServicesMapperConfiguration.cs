using AutoMapper;
using DataAccessLayer.Models;
using Services.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Mapper
{
    public static class ServicesMapperConfiguration
    {
        public static IMapper GetMapper()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<ServicesMapperProfiler>();
            });
            return config.CreateMapper();
        }
    }
}
