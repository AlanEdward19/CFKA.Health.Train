using CFKA.Health.Domain.Enums;
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
        private readonly TrainingHandler _handler;

        public TrainingController(TrainingHandler handler)
        {
            _handler = handler;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id, ELanguage language) =>
            Ok(await _handler.GetById(Request.Headers["api-key"], id, language));


        [HttpGet]
        public async Task<IActionResult> GetAll(ELanguage language) => Ok(await _handler.GetAll(Request.Headers["api-key"], language));


        [HttpGet("/Trainer")]
        public async Task<IActionResult> GetClientTraining(ELanguage language, string? clientId = null) => Ok(
            string.IsNullOrWhiteSpace(clientId)
                ? await _handler.GetAllClientsTraining(Request.Headers["api-key"], language)
                : await _handler.GetClientTraining(Request.Headers["api-key"], clientId, language));


        [HttpPut]
        public async Task Update([FromBody] CreateUpdateTrainingCommand command, [FromQuery] string ownerId ,int id) =>
            await _handler.Update(command, id, ownerId, Request.Headers["api-key"]);

        [HttpDelete]
        public async Task Delete(int id, string ownerId) => await _handler.Delete(id, ownerId, Request.Headers["api-key"]);

        [HttpPost]
        public async Task Insert([FromBody] CreateUpdateTrainingCommand command, [FromQuery] string ownerId) =>
            await _handler.Insert(command, ownerId, Request.Headers["api-key"]);
    }
}
