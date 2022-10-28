using Doggo.Api.Mappers;
using Doggo.Api.ViewModels;
using Doggo.Infrastructure;
using MediatR;

namespace Doggo.Api.Queries
{
    public class GetSomeDoggoBreedQueryHandler : IRequestHandler<GetSomeDoggoBreedQuery, IEnumerable<DoggoBreedViewModel>>
    {
        private readonly IDoggoBreedRepository _doggoBreedRepository;

        public GetSomeDoggoBreedQueryHandler(IDoggoBreedRepository doggoBreedRepo)
        {
            _doggoBreedRepository = doggoBreedRepo;
        }

        public async Task<IEnumerable<DoggoBreedViewModel>> Handle(GetSomeDoggoBreedQuery request, CancellationToken cancellationToken)
        {
            return _doggoBreedRepository.GetDoggoBreed(request).ToViewModel();
        }
    }
}
