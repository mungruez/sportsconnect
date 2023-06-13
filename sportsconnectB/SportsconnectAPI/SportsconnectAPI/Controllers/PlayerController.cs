using Microsoft.AspNetCore.Mvc;
using SportsconnectAPI.Data;
using Microsoft.EntityFrameworkCore;
using SportsconnectAPI.Models;

namespace SportsconnectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : Controller
    {
        private readonly SportsConnectDBContext _sportsconnectDBContext;

        public PlayerController(SportsConnectDBContext sportsconnectDBContext)
        {
            _sportsconnectDBContext = sportsconnectDBContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPlayers()
        {
            var players = await _sportsconnectDBContext.Players.ToListAsync();
            return Ok(players);
        }

        [HttpPost]
        public async Task<IActionResult> AddPlayer(Player playerRequest)
        {
            var query = from p in this._sportsconnectDBContext.Players select p.Id;
            
            playerRequest.Id = new Guid();
            playerRequest.pCode= await query.CountAsync()+1;
            playerRequest.attending = "NoEvents";
            playerRequest.lastActive = DateTime.UtcNow;
            
            await _sportsconnectDBContext.Players.AddAsync(playerRequest);
            await _sportsconnectDBContext.SaveChangesAsync();
            return Ok(playerRequest.Id);
        }

        

        [HttpGet("{pCode}")]
        public async Task<IActionResult> GetPlayer([FromRoute] string pCode)
        {
            var player = await _sportsconnectDBContext.Players.FirstOrDefaultAsync(x => x.pCode == int.Parse(pCode));
            if(player == null)
            {
                return NotFound();

            }
            return Ok(player);
        }

        [HttpPut("{pCode}")]
        public async Task<IActionResult> UpdatePlayer([FromRoute] string pCode, Player updatePlayerRequest)
        {
            var player = await _sportsconnectDBContext.Players.FirstOrDefaultAsync(x => x.pCode == int.Parse(pCode));
            if (player == null)
            {
                return NotFound();

            }

            player.name = updatePlayerRequest.name;
            player.age = updatePlayerRequest.age;
            player.sport = updatePlayerRequest.sport;
            player.phone = updatePlayerRequest.phone;
            player.address = updatePlayerRequest.address;
            player.lastActive = updatePlayerRequest.lastActive;
            player.attending = updatePlayerRequest.attending;
            
            await _sportsconnectDBContext.SaveChangesAsync();
            return Ok(player);
        }

        [HttpDelete("{pCode}")]
        public async Task<IActionResult> DeletePlayer([FromRoute] string pCode)
        {
            var player = await _sportsconnectDBContext.Players.FirstOrDefaultAsync(x => x.pCode == int.Parse(pCode));
            if (player == null)
            {
                return NotFound();

            }

            _sportsconnectDBContext.Players.Remove(player);
            await _sportsconnectDBContext.SaveChangesAsync();

            return Ok();
        }
    }
}
