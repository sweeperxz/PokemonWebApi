using Microsoft.AspNetCore.Mvc;
using UserJWT.Application.Interfaces;
using UserJWT.Domain.Models;

namespace UserJWT.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PokemonController(IPokemonRepository pokemonRepository) : Controller
{
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
    public IActionResult GetPokemons()
    {
        var pokemons = pokemonRepository.GetPokemons();
        if (!ModelState.IsValid) return BadRequest(ModelState);
        return Ok(pokemons);
    }
}