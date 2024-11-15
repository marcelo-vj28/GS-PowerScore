using System;
using System.ComponentModel.DataAnnotations;

namespace GS_PowerScore.Domain.Entities
{
    public class BeneficiarioEntity
    {
        [Key]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome não pode ter mais de 100 caracteres.")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve ter exatamente 11 caracteres.")]
        public required string Cpf { get; set; }

        [Phone(ErrorMessage = "O telefone não é válido.")]
        [StringLength(15, ErrorMessage = "O telefone não pode ter mais de 15 caracteres.")]
        public required string Telefone { get; set; }

        [EmailAddress(ErrorMessage = "O e-mail não é válido.")]
        [StringLength(100, ErrorMessage = "O e-mail não pode ter mais de 100 caracteres.")]
        public required string Email { get; set; }

        [StringLength(255, ErrorMessage = "O endereço não pode ter mais de 255 caracteres.")]
        public required string Endereco { get; set; }
    }
}
