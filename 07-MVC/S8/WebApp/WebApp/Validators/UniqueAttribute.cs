using System.ComponentModel.DataAnnotations;
using WebApp.Context;

namespace WebApp.Validators
{
    public class UniqueAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            // 1. Manually resolve the DbContext from the validationContext
            var _context = (SchoolDbContext)validationContext.GetService(typeof(SchoolDbContext))!;

            // 2. Perform your logic (example for a 'Name' property)
            // Note: You may want to pass the Property Name or Type as a constructor parameter 
            // to make this attribute reusable.
            var entityExists = _context.Students.Any(s => s.Name == value.ToString());

            if (entityExists)
            {
                return new ValidationResult("This value is already in use.");
            }

            return ValidationResult.Success;
        }
        //public override bool IsValid(object? value)
        //{
        //    SchoolDbContext context = new SchoolDbContext();

        //    string name = value.ToString();

        //   var student = context.Students.FirstOrDefault(s => s.Name == name);
        //    if (student == null)
        //    {
        //        return true;
        //    }

        //    return false;
        //}
    }
}
