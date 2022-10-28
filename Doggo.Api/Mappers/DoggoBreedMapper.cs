using Doggo.Api.ViewModels;

namespace Doggo.Api.Mappers
{
    public static class DoggoBreedMapper
    {
        public static DoggoBreedViewModel ToViewModel(this Domain.DoggoBreed source)
        {
            return new DoggoBreedViewModel
            {
                Breed = source.Breed
            };
        }

        public static IEnumerable<DoggoBreedViewModel> ToViewModel(this IEnumerable<Domain.DoggoBreed> source)
        {
            return source.Select(doggoBreed => doggoBreed.ToViewModel()).ToList();
        }
    }
}
