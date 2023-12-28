using System.IO;
using System.Net.Mime;
using System.Threading.Tasks;
using SceletonAPI.Application.UseCases.RegisterUser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SceletonAPI.Presenter.Controllers.Register {
    [ApiController]
    [Produces (MediaTypeNames.Application.Json)]
    public class LoginController : BaseController {
        [HttpPost]
        [Route ("/login/user")]
        [ProducesResponseType (StatusCodes.Status200OK)]
        public async Task<ActionResult<RegisterUserDto>> Register ([FromBody] RegisterUserCommand Payload) {
            return Ok (await Mediator.Send (Payload));
        }
    }
}