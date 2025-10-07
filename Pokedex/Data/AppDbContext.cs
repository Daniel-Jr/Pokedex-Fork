
using Microsoft.EntityFrameworkCore;
using Pokedex.Models;

namespace Pokedex.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
    {  }

    public DbSet<Genero> Generos { get; set; }
    public DbSet<Pokemon> Pokemons { get; set; }
    public DbSet<PokemonTipo> PokemonTipos { get; set; }
    public DbSet<Regiao> Regioes { get; set; }
    public DbSet<Tipo> Tipos { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<PokemonTipo>().HasKey(pt => new { pt.PokemonNumero, pt.TipoId });
    }
    
}
