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
    [Route("/task")]
    public class TaskController : BaseController {
        [HttpPost]
        [Route ("/task/addtask")]
        [ProducesResponseType (StatusCodes.Status200OK)]
        public async Task<ActionResult<RegisterUserDto>> Add ([FromBody] RegisterUserCommand Payload) {
            return Ok (await Mediator.Send (Payload));
        }

        [HttpPost]
        [Route ("/task/edittask")]
        [ProducesResponseType (StatusCodes.Status200OK)]
        public async Task<ActionResult<RegisterUserDto>> Update ([FromBody] RegisterUserCommand Payload) {
            return Ok (await Mediator.Send (Payload));
        }
        [HttpPost]
        [Route ("/task/deletetask")]
        [ProducesResponseType (StatusCodes.Status200OK)]
        public async Task<ActionResult<RegisterUserDto>> Delete ([FromBody] RegisterUserCommand Payload) {
            return Ok (await Mediator.Send (Payload));
        }
        [HttpGet]
        [Route ("/task/gettask")]
        [ProducesResponseType (StatusCodes.Status200OK)]
        public async Task<ActionResult<RegisterUserDto>> GetTask ([FromBody] RegisterUserCommand Payload) {
            return Ok (await Mediator.Send (Payload));
        }
    }
}