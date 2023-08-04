using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);
        decimal GetPokemonRating(int pokeId);
        bool PokemonExists(int pokeId);
        bool PokemonCreate(int ownerId, int categoryId, Pokemon pokemon);
        

        //Ми так робимо, бо в нас є ManyToMany
        bool UpdatePkemon(int ownerId, int categoryId, Pokemon pokemon);

        bool DeletePokemon(Pokemon pokemon);

        bool Save();
    }   
}
