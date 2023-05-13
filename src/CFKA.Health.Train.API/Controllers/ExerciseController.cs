using Microsoft.AspNetCore.Mvc;

namespace CFKA.Health.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly CommandHandler _commandHandler;
        private readonly QueryHandler<Exercise> _queryHandler;

        public ExerciseController(CreateUpdateExerciseCommandHandler commandHandler, GetExerciseHandler queryHandler)
        {
            _commandHandler = new(commandHandler);
            _queryHandler = new(queryHandler);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) => Ok(await _queryHandler.Handle(id));

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _queryHandler.Handle());

        [HttpPut]
        public async Task Update([FromBody] CreateUpdateExerciseCommand command, int id) =>
            await _commandHandler.Handle(command, id);

        [HttpDelete]
        public async Task Delete(int id) => await _commandHandler.Handle(id);

        [HttpPost]
        public async Task Insert([FromBody]CreateUpdateExerciseCommand command) => await _commandHandler.Handle(command);
    }
}
