using BlazorApp1.Server.Data;
using BlazorApp1.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<xlnuser>>> GetUsers()
        {
            var users = await _context.customers.ToListAsync();
            return Ok(users);

        }

        [HttpGet("faults")]

        public async Task<ActionResult<List<Fault>>> GetFaults()

        {
            var faults = await _context.errors.ToListAsync();
            return Ok(faults);
        }


        [HttpGet]
        [Route("{id}")]

        public async Task<ActionResult<xlnuser>> GetSingleUser(int id)
        {
            var user = await _context.customers
                .Include(h => h.Fault)
                .FirstOrDefaultAsync(h => h.Id == id);
            if (user == null)
            {
                return NotFound("Sorry, no user here. ");
            }
            return Ok(user);
        }

    }
}
