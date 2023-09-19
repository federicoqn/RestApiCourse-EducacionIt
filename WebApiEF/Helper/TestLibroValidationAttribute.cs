using System.ComponentModel.DataAnnotations;

namespace WebApiEF.Helper
{
    public class TestLibroValidationAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validation)
        {
            if (value != null && !string.IsNullOrEmpty(value.ToString()))
            {
                char firtCharacter = value.ToString()[0];
                if (char.IsUpper(firtCharacter))
                { 
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult(("El caracter debe estar en mayusculas"));

        }
    }
}
