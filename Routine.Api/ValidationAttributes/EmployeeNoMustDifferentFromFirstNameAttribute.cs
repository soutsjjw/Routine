using Routine.Api.Models;
using System.ComponentModel.DataAnnotations;

namespace Routine.Api.ValidationAttributes
{
    public class EmployeeNoMustDifferentFromFirstNameAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var addDto = (EmployeeAddDto)validationContext.ObjectInstance;

            if (addDto.EmployeeNo == addDto.FirstName)
            {
                return new ValidationResult("員工編號不可以等於名",
                    new[] { nameof(EmployeeAddDto) });
            }

            return ValidationResult.Success;
        }
    }
}
