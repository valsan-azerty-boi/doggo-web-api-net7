namespace Doggo.Infrastructure;

public interface IDoggoBreedRepository
{
    IEnumerable<Domain.DoggoBreed> GetDoggoBreed(dynamic query);
}
