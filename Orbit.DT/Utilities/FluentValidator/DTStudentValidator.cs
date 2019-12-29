using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Orbit.DT.Student;

namespace Orbit.DT.Utilities.FluentValidator
{
    public class DTStudentValidator : AbstractValidator<DTStudent>
    {
        public DTStudentValidator()
        {
            RuleFor(DTStudent => DTStudent.UserName).NotEmpty().WithMessage("Username is requeired");
            RuleFor(DTStudent => DTStudent.UserName).NotNull().WithMessage("Username is requeired");
            RuleFor(DTStudent => DTStudent.FirstName).NotEmpty().WithMessage("Fisrt Name is requeired");
            RuleFor(DTStudent => DTStudent.FirstName).NotNull().WithMessage("Fisrt Name is requeired");
            RuleFor(DTStudent => DTStudent.LastName).NotEmpty().WithMessage("Last name is requeired");
            RuleFor(DTStudent => DTStudent.LastName).NotNull().WithMessage("Last name is requeired");
            RuleFor(DTStudent => DTStudent.Age).NotEmpty().WithMessage("A is requeired");
            RuleFor(DTStudent => DTStudent.Age).NotNull().WithMessage("A is requeired");
            RuleFor(DTStudent => DTStudent.Age).NotEqual(0).WithMessage("A is requeired");
            RuleFor(DTStudent => DTStudent.Career).NotEmpty().WithMessage("Career is requeired");
            RuleFor(DTStudent => DTStudent.Career).NotNull().WithMessage("Career is requeired");
        }

    }
}
