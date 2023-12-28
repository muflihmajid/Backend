using System.IO;
using System.Net.Mime;
using System.Threading.Tasks;
using SceletonAPI.Application.UseCases.RegisterUser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SceletonAPI.Presenter.Controllers.Register {
    [ApiController]
    [Produces (MediaTypeNames.Application.Json)]
    [Route("/user")]
    public class RegisterController : BaseController {
        [HttpPost]
        [Route ("/user/register")]
        [ProducesResponseType (StatusCodes.Status200OK)]
        public async Task<ActionResult<RegisterUserDto>> Register ([FromBody] RegisterUserCommand Payload) {
            return Ok (await Mediator.Send (Payload));
        }

        [HttpPost]
        [Route ("/user/login")]
        [ProducesResponseType (StatusCodes.Status200OK)]
        public async Task<ActionResult<RegisterUserDto>> Login ([FromBody] RegisterUserCommand Payload) {
            return Ok (await Mediator.Send (Payload));
        }
    }
}