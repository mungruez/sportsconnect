using Microsoft.AspNetCore.Mvc;
using SportsconnectAPI.Data;
using Microsoft.EntityFrameworkCore;
using SportsconnectAPI.Models;

namespace SportsconnectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : Controller
    {
        private readonly SportsConnectDBContext _sportsconnectDBContext;
        public EventController(SportsConnectDBContext sportsconnectDBContext)
        {
            _sportsconnectDBContext = sportsconnectDBContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEvents()
        {
            var events = await _sportsconnectDBContext.Events.ToListAsync();
            return Ok(events);
        }

        [HttpPost]
        public async Task<IActionResult> AddEvent([FromBody] Event eventRequest)
        {
            var query = from e in this._sportsconnectDBContext.Events select e.Id;

            eventRequest.Id = Guid.NewGuid();
            eventRequest.pCode = await query.CountAsync()+1;
            eventRequest.playersAttending = eventRequest.owner+",";
            await _sportsconnectDBContext.Events.AddAsync(eventRequest);
            await _sportsconnectDBContext.SaveChangesAsync();
            return Ok(eventRequest);
        }

        [HttpGet("{pCode}")]
        public async Task<IActionResult> GetEvent([FromRoute] string pCode)
        {
            var event1 = await _sportsconnectDBContext.Players.FirstOrDefaultAsync(x => x.pCode == int.Parse(pCode));
            if (event1 == null)
            {
                return NotFound();

            }
            return Ok(event1);
        }

        [HttpPut("{pCode}")]
        public async Task<IActionResult> UpdateEvent([FromRoute] string pCode, Event updateEventRequest)
        {
            var event1 = await _sportsconnectDBContext.Events.FirstOrDefaultAsync(x => x.pCode == int.Parse(pCode));
            if (event1 == null)
            {
                return NotFound();

            }

            event1.title = updateEventRequest.title;
            event1.duration = updateEventRequest.duration;
            event1.sport = updateEventRequest.sport;
            event1.owner = updateEventRequest.owner;
            event1.location = updateEventRequest.location;
            event1.startDate = updateEventRequest.startDate;
            event1.playersAttending = updateEventRequest.playersAttending;
           
            await _sportsconnectDBContext.SaveChangesAsync();
            return Ok(event1);
        }

        [HttpDelete("{pCode}")]
        public async Task<IActionResult> DeleteEvent([FromRoute] string pCode)
        {
            var event1 = await _sportsconnectDBContext.Events.FirstOrDefaultAsync(x => x.pCode == int.Parse(pCode));
            if (event1 == null)
            {
                return NotFound();

            }

            _sportsconnectDBContext.Events.Remove(event1);
            await _sportsconnectDBContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("/api/Event/Join/{pCode}")]
        public async Task<IActionResult> JoinEvent([FromRoute] string pCode, Event joinEventRequest)
        {
            string[] arr = pCode.Split(":");
            pCode = arr[arr.Length - 1];
            var player = await _sportsconnectDBContext.Players.FirstOrDefaultAsync(x => x.pCode == int.Parse(pCode));
            var event1 = await _sportsconnectDBContext.Events.FirstOrDefaultAsync(x => x.pCode == joinEventRequest.pCode);
            if (player == null || event1 ==null || event1.playersAttending.Contains(player.pCode+",")==true || player.attending.Contains(event1.pCode+",")==true)
            {
                return NotFound();

            }
            
            event1.playersAttending = player.pCode+","+event1.playersAttending;
            player.attending = event1.pCode + "," + player.attending;
            player.lastActive=DateTime.UtcNow;
            
            await _sportsconnectDBContext.SaveChangesAsync();
            return Ok(player);
        }

        [HttpPut("/api/Event/Leave/{pCode}")]
        public async Task<IActionResult> LeaveEvent([FromRoute] string pCode, Event leaveEventRequest)
        {
            string[] arr = pCode.Split(":");
            pCode = arr[arr.Length - 1];
            var player = await _sportsconnectDBContext.Players.FirstOrDefaultAsync(x => x.pCode == int.Parse(pCode));
            var event1 = await _sportsconnectDBContext.Events.FirstOrDefaultAsync(x => x.pCode == leaveEventRequest.pCode);
            if (player == null || event1 == null || event1.playersAttending.Contains(player.pCode+",") == false || player.attending.Contains(event1.pCode+",") == false)
            {
                return NotFound();

            }

            event1.playersAttending=event1.playersAttending.Remove(event1.playersAttending.IndexOf(pCode.ToString()), pCode.ToString().Length+1);
            player.attending = player.attending.Remove(player.attending.IndexOf(event1.pCode.ToString()), event1.pCode.ToString().Length+1);

            await _sportsconnectDBContext.SaveChangesAsync();
            return Ok(player);
        }
    }
}
