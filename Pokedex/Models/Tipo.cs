
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models;

[Table("Tipo")]
public class Tipo
{
    [Key]
    public uint Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o nome do tipo do Pokemon!")]
    [StringLength(30)]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Por favor, informe a cor do tipo do Pokemon!")]
    [StringLength(25)]
    public string Cor { get; set; }

    public List<PokemonTipo> Pokemons { get; set; }
}   
