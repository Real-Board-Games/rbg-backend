namespace RealBoardGames.Domain;
public class GameEvent
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public DateTime Date { get; set; }
    public string BoardGame { get; set; } = null!;
    public string Location { get; set; } = null!;
    public string? ImageUrl { get; set; }
    public int CurrentNumberOfPlayers { get; set; }
    public int MaxNumberOfPlayers { get; set; }
    public int Price { get; set; }
    public double DistanceFromVenue { get; set; }
}
