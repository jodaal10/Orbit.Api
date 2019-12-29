//####################################################################
// Project:         OrbitTest
// Author:          Jonathan Dávila A.
// DATA:            29/12/2019
// Comment:         interface for bussines layer
//####################################################################
namespace Orbit.BM.Student
{
    using Orbit.DT.Student;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IBMStudent
    {
        DTResponse CreateStudent(DTStudent objStudent);
        DTResponse ModifyStudent(DTStudent objStudent);
        DTResponse DeleteStudent(int IdStudent);
        List<DTStudent> GetAllStudents();
    }
}
