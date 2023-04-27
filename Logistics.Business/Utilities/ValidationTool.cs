using FluentValidation;


namespace Logistics.Business.Utilities
{
    public static class ValidationTool    //static class
    {
        public static void Validate(IValidator validator, object entity)    //static method
        {
            var result = validator.Validate((IValidationContext)entity);

            //var context = new ValidationContext<object>(entity);
            //var result = validator.Validate(context);

            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
