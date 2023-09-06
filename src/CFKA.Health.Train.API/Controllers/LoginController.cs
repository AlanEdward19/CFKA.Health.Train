using CFKA.Health.Infrastructure.Context;
using CFKA.Health.Train.Application.Commands.CreateUpdateUser;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CFKA.Health.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly CFKATrainDbContext _context;

        public LoginController(CFKATrainDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Login([FromQuery] GetLoginQuery query)
        {
            User user = await _context.Users.FirstOrDefaultAsync(x =>
                x.Email.ToLower().Equals(query.Email.ToLower()) &&
                x.Password.ToLower().Equals(query.Password.ToLower()));

            return user == null ? BadRequest(new{Error = "Invalid email and password combination" }) : Ok(new{Id = user.Id });
        }

    }
}
