﻿using CFKA.Health.Train.Application.Handler;
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

        [HttpPost]
        public async Task<IActionResult> BuildTrainingSheet([FromBody] BuildTrainingSheetQuery query) => Ok(await _handler.BuildTrainingSheet(query));
    }
}
