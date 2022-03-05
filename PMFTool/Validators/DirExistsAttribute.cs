using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFTool.Validators
{
	public class DirExistsAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is string path && (Directory.Exists(path) || Directory.Exists(path)))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult($"The Directory '{value}' is not found.");
        }
    }

}
