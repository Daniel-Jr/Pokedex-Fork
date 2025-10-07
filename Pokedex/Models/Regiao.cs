using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models;

[Table("Regiao")]
public class Regiao
{

    [Key]
    public uint Id { get; set; }
    
    [Required(ErrorMessage = "Por favor, informe o nome do Regiao do Pokemon!")]
    [StringLength(30)]
    public string Nome { get; set; }
    
}
