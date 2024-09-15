using MultiChannelAPI.Model.Validations;
using System.ComponentModel.DataAnnotations;

namespace MultiChannelAPI.Model
{
    internal class Cliente
    {
        [Required(ErrorMessage = "A identificação do cliente é obrigatório!")]
        [Range(1, int.MaxValue, ErrorMessage ="A identificação do cliente ultrapassou o valor desejado!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório!")]
        [StringLength(300, ErrorMessage = "O tamanho máximo do nome é de 300 caracteres!")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O e-mail é obrigatório!")]
        [StringLength(100, ErrorMessage = "O tamanho máximo do e-mail é de 100 caracteres!")]
        [EmailAddress(ErrorMessage ="E-mail inválido!")]
        public string Email { get; set; } = string.Empty;


        [Required(ErrorMessage = "O CPF é obrigatório!")]
        [StringLength(14, ErrorMessage = "O tamanho máximo do CPF é de 14 caracteres!")]
        [CPFValidation]
        public string CPF { get; set; } = string.Empty;


        //testar esta regex:(^[0-9]{2})?(\s|-)?(9?[0-9]{4})-?([0-9]{4}$)
        [Required(ErrorMessage = "O número do telefone é obrigatório!")]
        [StringLength(14, ErrorMessage = "O tamanho máximo do Telefone é de 14 caracteres!")]
        [RegularExpression(@"^\(?(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])\)? ?(?:[2-8]|9[0-9])[0-9]{3}\-?[0-9]{4}$", ErrorMessage = "Telefone Inválido!")]
        public string Telefone { get; set; } = string.Empty;


        [Required(ErrorMessage = "O CEP é obrigatório!")]
        [StringLength(9, ErrorMessage = "O tamanho máximo do CEP é de 9 caracteres!")]
        [RegularExpression(@"(^[0-9]{5})-?([0-9]{3}$)", ErrorMessage = "CEP Inválido!")]
        public string Cep { get; set; } = string.Empty;


        [Required(ErrorMessage = "O Endereço é obrigatório!")]
        [StringLength(500, ErrorMessage = "O tamanho máximo do e-mail é de 500 caracteres!")]
        public string Endereco { get; set; } = string.Empty;
    }
}