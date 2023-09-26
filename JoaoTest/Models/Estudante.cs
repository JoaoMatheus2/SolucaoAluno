using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JoaoTest.Models
{
  public class Estudante
  {
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o nome")]
    [StringLength(80, ErrorMessage = "O nome deve contar até 80 caracteres")]
    [MinLength(5, ErrorMessage = "O nome deve contar pelo 5 caracteres")]
    [DisplayName("Nome Completo")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe o E-mail")]
    [EmailAddress(ErrorMessage = "E-mail inválido")]
    [DisplayName("E-mail")]
    public string Email { get; set; } = string.Empty;

    public List<Premium> Premiums { get; set; } = new();
  }
}
