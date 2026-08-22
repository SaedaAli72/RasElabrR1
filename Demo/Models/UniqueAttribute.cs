using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class UniqueAttribute :ValidationAttribute
    {
        //protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        //{

        //    string name = value?.ToString();

        //    ITIContext context = new ITIContext();
        //    bool exists = context.Employees.Any(e => e.Name == name);

        //    if (exists)
        //    {
        //        return new ValidationResult("Name Already Exists");
        //    }
        //    return ValidationResult.Success;
        //}
    }
}
