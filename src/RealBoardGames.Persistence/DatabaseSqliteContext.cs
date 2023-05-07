using Microsoft.EntityFrameworkCore;
using RealBoardGames.Domain;

namespace RealBoardGames.Persistence;

public class DatabaseSqliteContext : DbContext
{
    public DatabaseSqliteContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<GameEvent> GameEvents { get; set; } = null!;
}