namespace Doggo.Infrastructure;

public interface IDoggoRepository
{
    IEnumerable<Domain.Doggo> GetDoggoName(dynamic query);
}
