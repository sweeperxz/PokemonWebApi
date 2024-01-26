namespace UserJWT.Domain.Models;

public class PokemonCategory
{
    public int PokemondId { get; set; }
    public int CategoryId { get; set; }
    public Pokemon Pokemon { get; set; }
    public Category Category { get; set; }
}