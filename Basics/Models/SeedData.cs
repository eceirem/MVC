using Basics.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Basics.Data;
using System;
using System.Linq;

namespace Basics.Models;
/*How Seeding Works:
Initial Seeding: When you first run the application, if the database is empty (i.e., there are no movies in the database), 
the seeding process defined in SeedData.cs will insert the default set of data into the database.
Checking for Existing Data: The SeedData.cs file includes a check like if (context.Movie.Any()) { return; }. 
This line checks if there are any movies already in the database. If movies exist, it skips seeding to avoid duplicating data.
*/
public static class SeedData
{
	public static void Initialize(IServiceProvider serviceProvider)
	{
		using (var context = new BasicsContext(
			serviceProvider.GetRequiredService<
				DbContextOptions<BasicsContext>>()))
		{
            // Look for any movies. If there any return
            if (context.Movie.Any())
			{
				return;   // DB has been seeded
			}
			context.Movie.AddRange(
				new Movie
				{
					Title = "When Harry Met Sally",
					ReleaseDate = DateTime.Parse("1989-2-12"),
					Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "R"
                },
				new Movie
				{
					Title = "Ghostbusters ",
					ReleaseDate = DateTime.Parse("1984-3-13"),
					Genre = "Comedy",
					Price = 8.99M,
					Rating = "M"
				},
				new Movie
				{
					Title = "Ghostbusters 2",
					ReleaseDate = DateTime.Parse("1986-2-23"),
					Genre = "Comedy",
					Price = 9.99M,
                    Rating = "L"
                },
				new Movie
				{
					Title = "Rio Bravo",
					ReleaseDate = DateTime.Parse("1959-4-15"),
					Genre = "Western",
					Price = 3.99M,
                    Rating = "PG"
                }
			);
			context.SaveChanges();
		}
	}
}