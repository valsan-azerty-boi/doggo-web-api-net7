using Doggo.Api.ViewModels;
using MediatR;

namespace Doggo.Api.Queries
{
    public class GetSomeDoggoBreedQuery : IRequest<IEnumerable<DoggoBreedViewModel>>
    {
        public int Limit { get; set; }
    }
}
