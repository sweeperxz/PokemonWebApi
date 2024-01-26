using ClearEduc.Domain.Models;

namespace ClearEduc.Application.Interfaces;

public interface IPokemonRepository
{
    ICollection<Pokemon> GetPokemons();
}