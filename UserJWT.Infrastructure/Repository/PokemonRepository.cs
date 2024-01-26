using UserJWT.Application.Interfaces;
using UserJWT.Domain.Models;
using UserJWT.Infrastructure.Data;

namespace UserJWT.Infrastructure.Repository;

public class PokemonRepository(DataContext context) : IPokemonRepository
{
    public ICollection<Pokemon> GetPokemons()
    {
        return context.Pokemon.OrderBy(p => p.Id).ToList();
    }
}