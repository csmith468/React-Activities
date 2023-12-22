using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence
{
    public class Seed {
        public static async Task SeedData(DataContext context, UserManager<AppUser> userManager) {
            if (!userManager.Users.Any()) {
                var users = new List<AppUser> {
                    new AppUser{DisplayName="Bob", UserName="Bob", Email="bob@test.com"},
                    new AppUser{DisplayName="Tom", UserName="Tom", Email="tom@test.com"},
                    new AppUser{DisplayName="Jane", UserName="Jane", Email="jane@test.com"}
                };
                foreach (var user in users) {
                    await userManager.CreateAsync(user, "Pa$$w0rd");
                }
            }

            if (context.Activities.Any()) return;
            
            var activities = new List<Activity> {
                new Activity {
                    Title = "Rodeo",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Description = "Houston Rodeo",
                    Category = "Performance",
                    City = "Houston",
                    Venue = "NRG Stadium",
                },
                new Activity {
                    Title = "Musical",
                    Date = DateTime.UtcNow.AddMonths(-1),
                    Description = "See a musical on Broadway",
                    Category = "Performance",
                    City = "New York City",
                    Venue = "Broadway",
                },
                new Activity {
                    Title = "AJC Peachtree Road Race 2024",
                    Date = DateTime.UtcNow.AddMonths(1),
                    Description = "Yearly fourth of July race in 2024",
                    Category = "Running",
                    City = "Atlanta",
                    Venue = "Peachtree Road",
                },
                new Activity {
                    Title = "AJC Peachtree Road Race 2023",
                    Date = DateTime.UtcNow.AddMonths(2),
                    Description = "Yearly fourth of July race in 2023",
                    Category = "Running",
                    City = "Atlanta",
                    Venue = "Peachtree Road",
                },
                new Activity {
                    Title = "The Infinite",
                    Date = DateTime.UtcNow.AddMonths(3),
                    Description = "Tour the Space Station in VR!",
                    Category = "Activity",
                    City = "Houston",
                    Venue = "NASA",
                },
                new Activity {
                    Title = "Artz Adult Aerial Show",
                    Date = DateTime.UtcNow.AddMonths(3),
                    Description = "Showcase of adults performing aerial at the Artz",
                    Category = "drinks",
                    City = "Houston",
                    Venue = "The Artz",
                },
                new Activity {
                    Title = "Times Square Ball Drop",
                    Date = DateTime.UtcNow.AddMonths(4),
                    Description = "See the ball drop for New Years in Times Square",
                    Category = "Activity",
                    City = "New York City",
                    Venue = "Times Square",
                },
                new Activity {
                    Title = "Fudgery",
                    Date = DateTime.UtcNow.AddMonths(5),
                    Description = "Haley and Chapin go to San Francisco and get fudge at the Fudgery",
                    Category = "Travel",
                    City = "San Francisco",
                    Venue = "Pier 39",
                },
                new Activity {
                    Title = "Game Night",
                    Date = DateTime.UtcNow.AddMonths(6),
                    Description = "Game night with your friends",
                    Category = "Activity",
                    City = "Atlanta",
                    Venue = "Apartment",
                },
                new Activity {
                    Title = "Concert",
                    Date = DateTime.UtcNow.AddMonths(7),
                    Description = "Go see a concert!",
                    Category = "Performance",
                    City = "Houston",
                    Venue = "NRG Stadium",
                },
                new Activity {
                    Title = "New Year's Rockin' Eve",
                    Date = DateTime.UtcNow.AddMonths(8),
                    Description = "Concerts for the New Year!",
                    Category = "Performance",
                    City = "New York City",
                    Venue = "Times Square",
                },
                new Activity {
                    Title = "Golden Gate Bridge Ferry Tour",
                    Date = DateTime.UtcNow.AddMonths(8),
                    Description = "Go on a ferry to go under the Golden Gate Bridge!",
                    Category = "Travel",
                    City = "San Francisco",
                    Venue = "Golden Gate Bridge",
                }
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}