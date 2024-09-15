using System.ComponentModel.DataAnnotations;

namespace MultiChannelAPI.Model.Validations
{
    internal class CPFValidation : ValidationAttribute
    {

        internal CPFValidation() : base("{0} não é um CPF válido!")
        { }

        protected override ValidationResult? IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
                return new ValidationResult("Valor do CPF é obrigatório!");

            var strValue = value != null? value.ToString() : string.Empty;

            if (Util.ValidaCPF(strValue))
                return null;

            return new ValidationResult(base.FormatErrorMessage(validationContext.MemberName)
                , new string[] { validationContext.MemberName });
        }
    }
}