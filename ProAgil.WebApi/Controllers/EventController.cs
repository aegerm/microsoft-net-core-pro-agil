using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProAgil.WebApi.Data;
using ProAgil.WebApi.Model;

namespace ProAgil.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {
        private readonly DataContext _context;

        public EventController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<Event>> GetEvent()
        {
            var _event = await _context.Events.ToListAsync();

            if (_event == null)
            {
                return NotFound();
            }

            return Ok(_event);
        }

        [HttpPost]
        public async Task<ActionResult<Event>> InsertEvent(Event _event)
        {
            _context.Events.Add(_event);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEvent), new { id = _event.Id }, _event);
        }
    }
}