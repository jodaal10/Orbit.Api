using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation.Results;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orbit.BM.Student;
using Orbit.DT.Student;
using Orbit.DT.Utilities.FluentValidator;

namespace OrbitTest.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IBMStudent _ObjStudent;
        private readonly IMapper _Objmapper;

        public StudentController(IBMStudent IStudent,IMapper mapper)
        {
            _ObjStudent = IStudent;
            _Objmapper = mapper;
        }

        [HttpGet]
        [Route("GetAllStudents")]
        public ActionResult<List<DTStudent>> GetAllStudents()
        {
            List<DTStudent> objStudents = new List<DTStudent>();
            objStudents = _ObjStudent.GetAllStudents();
            return objStudents;
        }

        [HttpGet]
        [Route("DeleteStudent")]
        public ActionResult<DTResponse> DeleteStudent(int IdStudent)
        {
            return _ObjStudent.DeleteStudent(IdStudent); ;
        }

        [HttpPost]
        [Route("ModifyStudent")]
        public ActionResult<DTResponse> ModifyStudent(DTStudent objStudent)
        {
            DTResponse Resp = new DTResponse();
            DTStudentValidator objStudentValidator = new DTStudentValidator();
            ValidationResult result = new ValidationResult();

            //Validate fields required
            result = objStudentValidator.Validate(objStudent);
            if (result.IsValid)
            {
                Resp = _ObjStudent.ModifyStudent(objStudent);
            }
            else
            {
                Resp.response = false;
                foreach (var failure in result.Errors)
                {
                    Resp.message += "Error was: " + failure.ErrorMessage + "-> ";
                }
            }

            return Resp;
        }

        [HttpPost]
        [Route("CreateStudent")]
        public ActionResult<DTResponse> CreateStudent(DTStudent objStudent)
        {
            DTResponse Resp = new DTResponse();
            DTStudentValidator objStudentValidator = new DTStudentValidator();
            ValidationResult result = new ValidationResult();

            //Validate fields required
            result = objStudentValidator.Validate(objStudent);
            if (result.IsValid)
            {
                Resp = _ObjStudent.CreateStudent(objStudent);
            }
            else
            {
                Resp.response = false;
                foreach (var failure in result.Errors)
                {
                    Resp.message += "Error was: " + failure.ErrorMessage + "-> ";
                }
            }

            return Resp;
        }
    }
}