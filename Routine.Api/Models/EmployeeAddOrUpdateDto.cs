using Routine.Api.Entities;
using Routine.Api.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Routine.Api.Models
{
    [EmployeeNoMustDifferentFromFirstName(ErrorMessage = "員工編號必須和名不一樣！！")]
    public class EmployeeAddOrUpdateDto : IValidatableObject
    {
        [Display(Name = "員工號")]
        [Required(ErrorMessage = "{0}是必填項")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "{0}的長度是{1}")]
        public string EmployeeNo { get; set; }

        [Display(Name = "名")]
        [Required(ErrorMessage = "{0}是必填項")]
        [MaxLength(50, ErrorMessage = "{0}的長度不能超過{1}")]
        public string FirstName { get; set; }

        [Display(Name = "名")]
        [Required(ErrorMessage = "{0}是必填項")]
        [MaxLength(50, ErrorMessage = "{0}的長度不能超過{1}")]
        public string LastName { get; set; }

        [Display(Name = "性別")]
        public Gender Gender { get; set; }

        [Display(Name = "出生日期")]
        public DateTime DateOfBirth { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (FirstName == LastName)
            {
                yield return new ValidationResult("姓和名不能一樣",
                    new[] { nameof(FirstName), nameof(LastName) });
            }
        }
    }
}
