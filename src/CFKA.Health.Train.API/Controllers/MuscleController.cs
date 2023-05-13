using Microsoft.AspNetCore.Mvc;

namespace CFKA.Health.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MuscleController : ControllerBase
    {
        private readonly CommandHandler _commandHandler;
        private readonly QueryHandler<Muscle> _queryHandler;

        public MuscleController(CreateUpdateMuscleCommandHandler commandHandler, GetMuscleHandler queryHandler)
        {
            _commandHandler = new(commandHandler);
            _queryHandler = new(queryHandler);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) => Ok(await _queryHandler.Handle(id));

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _queryHandler.Handle());

        [HttpPut]
        public async Task Update([FromBody] CreateUpdateMuscleCommand command, int id) =>
            await _commandHandler.Handle(command, id);

        [HttpDelete]
        public async Task Delete(int id) => await _commandHandler.Handle(id);

        [HttpPost]
        public async Task Insert([FromBody]CreateUpdateMuscleCommand command) => await _commandHandler.Handle(command);
    }
}
