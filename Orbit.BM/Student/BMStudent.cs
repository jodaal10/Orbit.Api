//####################################################################
// Project:         OrbitTest
// Author:          Jonathan Dávila A.
// DATA:            29/12/2019
// Comment:         layer of businnes
//####################################################################
namespace Orbit.BM.Student
{
    using AutoMapper;
    using Orbit.DM.Students;
    using Orbit.DT.Student;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Orbit.DM.Database.Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    public class BMStudent: IBMStudent
    {
        private IStudentRepository _ObjStudentRepository;
        private readonly IMapper _Objmapper;

        //Constructor
        public BMStudent(IStudentRepository StudentRepository, IMapper mapper)
        {
            _ObjStudentRepository = StudentRepository;
            _Objmapper = mapper;
        }

        /// <summary>
        /// Insert new students
        /// </summary>
        /// <param name="objStudent"></param>
        /// <returns>DTResponse</returns>
        public DTResponse CreateStudent(DTStudent objStudent)
        {
            DTResponse Resp = new DTResponse();
            try
            {
                var StudentBD = _Objmapper.Map<Student>(objStudent);
                _ObjStudentRepository.Create(StudentBD);
                Resp.response = true;
                Resp.message = "Success";
            }
            catch (Exception ex)
            {
                Resp.message = ex.Message;
            }
            return Resp;
        }

        /// <summary>
        /// Modify data of Student
        /// </summary>
        /// <param name="objStudent"></param>
        /// <returns></returns>
        public DTResponse ModifyStudent (DTStudent objStudent)
        {
            DTResponse Resp = new DTResponse();
            try
            {
                var student = _ObjStudentRepository.GetAllBy(i => i.Id == objStudent.Id).FirstOrDefault();
                if (student != null)
                {
                    student = _Objmapper.Map<Student>(objStudent);
                    _ObjStudentRepository.Update(student);
                    Resp.response = true;
                    Resp.message = "Success";
                }
                else {
                    Resp.response = false;
                    Resp.message = "Not found";
                }
            }
            catch (Exception ex)
            {
                Resp.response = false;
                Resp.message = ex.Message;
            }
            return Resp;
        }

        /// <summary>
        /// Delete all data of student
        /// </summary>
        /// <param name="IdStudent"></param>
        /// <returns></returns>
        public DTResponse DeleteStudent(int IdStudent)
        {
            DTResponse Resp = new DTResponse();
            try
            {
                var student = _ObjStudentRepository.GetAllBy(i => i.Id == IdStudent).FirstOrDefault();
                if (student != null)
                {
                    _ObjStudentRepository.Delete(student);
                    Resp.response = true;
                    Resp.message = "Success";
                }
                else {
                    Resp.response = false;
                    Resp.message = "Not found";
                }
            }
            catch (Exception ex)
            {
                Resp.response = false;
                Resp.message = ex.Message;
            }
            return Resp;
        }

        /// <summary>
        /// Get all students of data base
        /// </summary>
        public List<DTStudent> GetAllStudents()
        {
            List<DTStudent> ListStudents = new List<DTStudent>();
            try
            {
                var Query = _ObjStudentRepository.GetAll();
                if (Query != null)
                {
                    foreach (Student item in Query)
                    {
                        var objStudent= _Objmapper.Map<DTStudent>(item);
                        ListStudents.Add(objStudent);
                    }
                }
                return ListStudents;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
