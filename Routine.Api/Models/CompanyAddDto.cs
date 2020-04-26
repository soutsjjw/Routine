using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Routine.Api.Models
{
    public class CompanyAddDto
    {
        [Display(Name = "公司名稱")]
        [Required(ErrorMessage = "{0}這個字段是必填的")]
        [MaxLength(100, ErrorMessage = "{0}的最大長度不可以超過{1}")]
        public string Name { get; set; }

        [Display(Name = "簡介")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "{0}的長度範圍從{2}到{1}")]
        public string Introduction { get; set; }

        public ICollection<EmployeeAddDto> Employees { get; set; } = new List<EmployeeAddDto>();
    }
}
