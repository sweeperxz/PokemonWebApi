using ClearEduc.Application.Interfaces;
using ClearEduc.Domain.Models;
using ClearEduc.Infrastructure.Data;

namespace ClearEduc.Infrastructure.Repository;

public class PokemonRepository(DataContext context) : IPokemonRepository
{
    public ICollection<Pokemon> GetPokemons()
    {
        return context.Pokemon.OrderBy(p => p.Id).ToList();
    }
}