using UserJWT.Domain.Models;

namespace UserJWT.Application.Interfaces;

public interface IPokemonRepository
{
    ICollection<Pokemon> GetPokemons();
}