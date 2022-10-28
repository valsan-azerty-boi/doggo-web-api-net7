using Doggo.Api.Queries;
using Doggo.Api.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Doggo.Api.Controllers
{
    [ApiController]
    [Route("doggo")]
    public class DoggoController : ControllerBase
    {
        private readonly ISender _mediator;

        public DoggoController(ISender mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get some doggo name
        /// </summary>
        /// <param name="limit">Limit number of result</param>
        /// <returns>200 OK if success</returns>
        [HttpGet]
        [Route("name")]
        [ProducesResponseType(typeof(IEnumerable<DoggoViewModel>), StatusCodes.Status200OK)]
        [Produces(System.Net.Mime.MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetSomeDoggoName([FromQuery]int limit = 10)
        {
            return Ok(await _mediator.Send(new GetSomeDoggoNameQuery { Limit = limit }));
        }

        /// <summary>
        /// Get some doggo breed
        /// </summary>
        /// <param name="limit">Limit number of result</param>
        /// <returns>200 OK if success</returns>
        [HttpGet]
        [Route("breed")]
        [ProducesResponseType(typeof(IEnumerable<DoggoBreedViewModel>), StatusCodes.Status200OK)]
        [Produces(System.Net.Mime.MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetSomeDoggoBreed([FromQuery] int limit = 10)
        {
            return Ok(await _mediator.Send(new GetSomeDoggoBreedQuery { Limit = limit }));
        }
    }
}
