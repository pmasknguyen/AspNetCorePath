using AutoMapper;
using CourseLibraryAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibraryAPI.Profiles
{
    public class CourseProfile:Profile
    {
        public CourseProfile()
        {
            CreateMap<CourseLibrary.API.Entities.Course, CourseDto>();
        }
    }
}
