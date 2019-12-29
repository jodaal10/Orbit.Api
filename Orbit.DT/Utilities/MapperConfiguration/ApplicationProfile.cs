//####################################################################
// Project:         Orbittest
// Author:          Jonathan Dávila A.
// DATA:            29/12/2019
// Comment:         Mapper profiles
//####################################################################
namespace Orbit.DT.Utilities.MapperConfiguration
{
    using Orbit.DT.Student;
    using Orbit.DM.Database.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Student, DTStudent>().ReverseMap();
        }
    }
}
