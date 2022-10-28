using Doggo.Api.ViewModels;

namespace Doggo.Api.Mappers
{
    public static class DoggoMapper
    {
        public static DoggoViewModel ToViewModel(this Domain.Doggo source)
        {
            return new DoggoViewModel
            {
                Name = source.Name
            };
        }

        public static IEnumerable<DoggoViewModel> ToViewModel(this IEnumerable<Domain.Doggo> source)
        {
            return source.Select(doggo => doggo.ToViewModel()).ToList();
        }
    }
}
