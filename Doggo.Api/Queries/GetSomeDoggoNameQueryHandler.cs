using Doggo.Api.Mappers;
using Doggo.Api.ViewModels;
using Doggo.Infrastructure;
using MediatR;

namespace Doggo.Api.Queries
{
    public class GetSomeDoggoNameQueryHandler : IRequestHandler<GetSomeDoggoNameQuery, IEnumerable<DoggoViewModel>>
    {
        private readonly IDoggoRepository _doggoRepository;

        public GetSomeDoggoNameQueryHandler(IDoggoRepository doggoRepo)
        {
            _doggoRepository = doggoRepo;
        }

        public async Task<IEnumerable<DoggoViewModel>> Handle(GetSomeDoggoNameQuery request, CancellationToken cancellationToken)
        {
            return _doggoRepository.GetDoggoName(request).ToViewModel();
        }
    }
}
