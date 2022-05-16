using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners();

        Owner GetOwner(int ownerId);        

        ICollection<Owner> GetOwnersOfAPokemon(int ownerId);     
        ICollection<Pokemon> GetPokemonByOwner(int ownerId);    
        bool OwnerExists(int ownerId);
        bool CreateOwner(Owner ownerId);
        bool UpdateOwner(Owner owner);  
        bool DeleteOwner(Owner owner);
        bool Save();


    }
}
