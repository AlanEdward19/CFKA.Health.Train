using CFKA.Health.Train.Application.Commands.CreateUpdateUser;
using Microsoft.AspNetCore.Mvc;

namespace CFKA.Health.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly CommandHandler _commandHandler;
        private readonly QueryHandler<User> _queryHandler;

        public UserController(CreateUpdateUserCommandHandler commandHandler, GetUserHandler queryHandler)
        {
            _commandHandler = new(commandHandler);
            _queryHandler = new(queryHandler);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id) => Ok(await _queryHandler.Handle(id));

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _queryHandler.Handle());

        [HttpPut]
        public async Task Update([FromBody] CreateUpdateUserCommand command, Guid id) =>
            await _commandHandler.Handle(command, id);

        [HttpDelete]
        public async Task Delete(Guid id) => await _commandHandler.Handle(id);

        [HttpPost]
        public async Task Insert([FromBody] CreateUpdateUserCommand command) => await _commandHandler.Handle(command);
    }
}
