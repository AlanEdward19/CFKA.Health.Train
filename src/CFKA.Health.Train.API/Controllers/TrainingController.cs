using CFKA.Health.Domain.Interfaces.Handler;
using CFKA.Health.Train.Application.Commands.CreateUpdateTraining;
using CFKA.Health.Train.Application.Handler;
using CFKA.Health.Train.Application.Queries.BuildTrainingSheet;
using Microsoft.AspNetCore.Mvc;

namespace CFKA.Health.Train.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly CommandHandler _commandHandler;
        private readonly TrainingHandler _handler;

        public TrainingController(TrainingHandler handler, CreateUpdateTrainingCommandHandler commandHandler)
        {
            _handler = handler;
            _commandHandler = new(commandHandler);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) => Ok(await _handler.GetById(Request.Headers["api-key"],id));

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _handler.GetAll(Request.Headers["api-key"]));

        [HttpPut]
        public async Task Update([FromBody] CreateUpdateTrainingCommand command, int id) => await _commandHandler.Handle(command, id);

        [HttpDelete]
        public async Task Delete(int id) => await _commandHandler.Handle(id);

        [HttpPost]
        public async Task Insert([FromBody] CreateUpdateTrainingCommand command) => await _commandHandler.Handle(command);
    }
}
