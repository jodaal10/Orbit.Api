//####################################################################
// Project:         OrbitTest
// Author:          Jonathan Dávila A.
// DATA:            29/12/2019
// Comment:         Class repository Student
//####################################################################
namespace Orbit.DM.Students
{
    using Orbit.DM.Repository;
    using Orbit.DM.Database.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Orbit.DM.Database.Context;

    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(OrbitDbContext Db) : base(Db)
        {

        }
    }
}
