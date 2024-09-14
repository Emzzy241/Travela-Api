using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;

namespace TravelApi.Models;
[Route("api/[controller]")]
[ApiController]
public class DestinationController: ControllerBase
{
    private readonly TravelApiContext _db;

    public DestinationController(TravelApiContext db)
    {
        _db = db;
    }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Destination>>> Get()
        {
            // Converting all destinations that we get from our database into a C# list
            return await _db.Destinations.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Destination>> GetDestination(int id)
        {
                Destination dest = await _db.Destinations.FindAsync(id);

                // TO avoid errors, lets slap in an if statement to actually confirm whether the destination exists
                if(dest != null)
                {
                    return dest;
                }
               
                    return NotFound();
            // ANother Get() to geta certain Destination based on its id

        }

        // Creating a destination
        [HttpPost]
        public async Task<ActionResult<Destination>> Post(Destination dest)
        {
            // NOTE: When creating a new Destination, we should never add in a parameter for id; our databse handles that one for us.. If we give a new destination an id that currently exists sin the databse, we get a 500 error
            // Remember, we do have an Auto-incrementing integer for our database that helps in giving new destinations an Id
            // So I gave an Id to a new destination(44), when I now made another Create() but I did not specify an id this time around, my database started counting from 45
            _db.Destinations.Add(dest);
            await _db.SaveChangesAsync();
            // For our MVC apps, after a CREATE()action is done, we RedirectToAction("Index"),
            // But for our API projects w will be using a CreatedAtAction() method that takes in 3 parameters; Name of the Action to return to, the id, and the object we are actually creating
            return CreatedAtAction(nameof(GetDestination), new { id = dest.DestinationId}, dest);
        }
       
}