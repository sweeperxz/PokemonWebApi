using ClearEduc.Application.Interfaces;
using ClearEduc.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClearEduc.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PokemonController(IPokemonRepository pokemonRepository) : Controller
{
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
    public IActionResult GetPokemons()
    {
        return !ModelState.IsValid ? BadRequest(ModelState) : Ok(pokemonRepository.GetPokemons());
    }
}