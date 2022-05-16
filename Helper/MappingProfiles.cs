using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //Mapping for Pokemon
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<PokemonDto, Pokemon>();
            // Mapping for Category
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            // Mapping for Country 
            CreateMap<Country, CountryDto>();
            CreateMap<CountryDto, Country>();
            // Mapping for Owner
            CreateMap<Owner, OwnerDto>();
            CreateMap<OwnerDto, Owner>();
            // Mapping for Review
            CreateMap<Review, ReviewDto>();
            CreateMap<ReviewDto, Review>();
            // Mapping for Reviewer
            CreateMap<Reviewer, ReviewerDto>();
            CreateMap<ReviewerDto, Reviewer>(); 


        }
    }
}
