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

        // [HttpPost]
        // public async Task<ActionResult> Create(Animal animal)
        // {
        //     // A Post for creating 

        // }
       
}