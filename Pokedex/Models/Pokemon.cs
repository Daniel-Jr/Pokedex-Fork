
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models;

[Table("Pokemon")]
public class Pokemon
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public uint Numero { get; set; }

    public uint RegiaoId { get; set; }

    [ForeignKey("RegiaoId")]
    public Regiao Regiao { get; set; }

    public uint GeneroId { get; set; }

    [ForeignKey("GeneroId")]
    public Genero Genero { get; set; }


    [Required(ErrorMessage = "Por favor, informe o nome do Pokemon!")]
    [StringLength(30)]
    public string Nome { get; set; }

    [StringLength(1000)]
    public string Descricao { get; set; }

    [Column(TypeName = "double(7,3)")]
    [Required(ErrorMessage = "Por favor, informe a Altura de seu Pokemon!")]
    public double Altura { get; set; }

    [Column(TypeName = "double(7,3)")]
    [Required(ErrorMessage = "Por favor, informe o Peso de seu Pokemon!")]
    public double Peso { get; set; }

    [StringLength(200)]
    public string Imagem { get; set; }

    [StringLength(400)]
    public string Animacao { get; set; }

    public List<PokemonTipo> Tipos { get; set; }
}
