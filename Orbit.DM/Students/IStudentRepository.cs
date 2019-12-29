//####################################################################
// Project:         OrbitTest
// Author:          Jonathan Dávila A.
// DATA:            29/12/2019
// Comment:         Interface repository student
//####################################################################
namespace Orbit.DM.Students
{
    using Orbit.DM.Database.Entities;
    using Orbit.DM.Repository;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IStudentRepository : IBaseRepository<Student>
    {
    }
}
