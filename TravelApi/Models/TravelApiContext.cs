using TravelApi.Models;
using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models;
public class TravelApiContext : DbContext
{
    // Creating a table in the database for all destinations
    public DbSet<Destination> Destinations { get; set; }

    public TravelApiContext(DbContextOptions<TravelApiContext> options): base(options)
    {

    }

    // Adding data into the database 
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Destination>()
                .HasData(
                    new Destination { DestinationId = 1, UserName = "Dynasty", Country = "Nigeria", City = "Lagos", DestinationName = "Silicon Valley", Review = "The place is a great place for startups to thrive in", OverallRating = "5 stars"},
                    new Destination { DestinationId = 2, UserName = "Daniel", Country = "Ghana", City = "Acrra", DestinationName = "Boston", Review = "Boston is a very very cold city in the United States of America", OverallRating = "3 stars"},
                    new Destination { DestinationId = 3, UserName = "Mike", Country = "USA", City = "Brocklyn", DestinationName = "Michighan", Review = "A Nice place to be in with a loved one... Its a peaceful place to be in", OverallRating = "4 stars"},
                    new Destination { DestinationId = 4, UserName = "Taylor", Country = "United Kingdom", City = "Southampton", DestinationName = "Manchester", Review = "Great Weather in Manchester, and its the home to my beloved club Manchester United", OverallRating = "5 stars"},
                    new Destination { DestinationId = 5, UserName = "Dynasty", Country = "Canada", City = "Alberta", DestinationName = "Toronto", Review = "Ontario has got to be one of the best States in the country Canada, not only is Toronto the capital of the Country but it is also a great place to travel to", OverallRating = "5 stars" }

                
                );
    }


}