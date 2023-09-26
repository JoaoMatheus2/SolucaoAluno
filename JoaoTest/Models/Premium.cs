using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JoaoTest.Models
{
  public class Premium
  {
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o título do Premium")]
    [StringLength(80, ErrorMessage = "O título deve contar até 80 caracteres")]
    [MinLength(5, ErrorMessage = "O título deve conter pelo menos 5 caracteres")]
    [DisplayName("Título")]
    public string Titulo { get; set; } = string.Empty;

    [DataType(DataType.DateTime)]
    //[GreaterThanToday]
    [DisplayName("Início")]
    public DateTime Inicio { get; set; }

    [DataType(DataType.DateTime)]
    //[GreaterThanToday]
    [DisplayName("Final")]
    public DateTime Final { get; set; }

    [DisplayName("Aluno")]
    [Required(ErrorMessage = "Aluno inválido")]
    public int EstudanteId { get; set; }

    public Estudante? Estudante { get; set; }

  }
}
