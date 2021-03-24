using AutoMapper;
using CleanArchitectureWithDapper.Core.DTOs;
using CleanArchitectureWithDapper.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureWithDapper.Application.AutoMapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<PersonWithPhonesDTO, Person>();
        }
    }
}
