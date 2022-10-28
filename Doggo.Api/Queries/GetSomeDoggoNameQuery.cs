using Doggo.Api.ViewModels;
using MediatR;

namespace Doggo.Api.Queries
{
    public class GetSomeDoggoNameQuery : IRequest<IEnumerable<DoggoViewModel>>
    {
        public int Limit { get; set; }
    }
}
