namespace PokemonReviewApp.Models
{
    public class PokemonOwner
    {

        public int PokemonId { get; set; }

        public int ownerId { get; set; }

        public  Pokemon Pokemon { get; set; }

        public Owner Owner { get; set; }
    }
}
