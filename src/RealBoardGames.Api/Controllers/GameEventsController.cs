using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealBoardGames.Domain;
using RealBoardGames.Persistence;

namespace RealBoardGames.Api.Controllers;

[Route("api/game-events")]
public class GameEventsController : BaseApiController
{
    private readonly DatabaseSqliteContext _context;

    public GameEventsController(DatabaseSqliteContext context)
    {
      _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<GameEvent>>> GetGameEvents()
    {
      return await _context.GameEvents.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GameEvent?>> GetGameEvent(Guid id)
    {
      return await _context.GameEvents.FindAsync(id);
    }

}