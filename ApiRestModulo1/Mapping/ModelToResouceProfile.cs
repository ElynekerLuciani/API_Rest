using ApiRestModulo1.Domain.Models;
using ApiRestModulo1.Resources;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestModulo1.Mapping
{
    public class ModelToResouceProfile : Profile
    {

        public ModelToResouceProfile()
        {
            CreateMap<Category, CategoryResource>();
        }
    }
}
