using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealBoardGames.Domain;

namespace RealBoardGames.Persistence
{
    public class Seed
    {
        public static async Task SeedData(DatabaseSqliteContext context)
        {
            if (context.GameEvents.Any())
            {
                return;

            }

            var gameEvents = new List<GameEvent>
            {
                new GameEvent{
                    Name = "Game Event 1",
                    Description = "Description 1",
                    Date = DateTime.Now.AddDays(1),
                    BoardGame = "Board Game 1",
                    Location = "Location 1",
                    ImageUrl = "https://picsum.photos/200",
                    CurrentNumberOfPlayers = 1,
                    MaxNumberOfPlayers = 4,
                    Price = 10,
                    DistanceFromVenue = 1.5
                },
                new GameEvent{
                    Name = "Game Event 2",
                    Description = "Description 2",
                    Date = DateTime.Now.AddDays(2),
                    BoardGame = "Board Game 2",
                    Location = "Location 2",
                    ImageUrl = "https://picsum.photos/200",
                    CurrentNumberOfPlayers = 2,
                    MaxNumberOfPlayers = 4,
                    Price = 10,
                    DistanceFromVenue = 1.5
                },
                new GameEvent{
                    Name = "Game Event 3",
                    Description = "Description 3",
                    Date = DateTime.Now.AddDays(3),
                    BoardGame = "Board Game 3",
                    Location = "Location 3",
                    ImageUrl = "https://picsum.photos/200",
                    CurrentNumberOfPlayers = 3,
                    MaxNumberOfPlayers = 4,
                    Price = 10,
                    DistanceFromVenue = 1.5
                },
        };

            await context.GameEvents.AddRangeAsync(gameEvents);
            await context.SaveChangesAsync();
        }
    }
}