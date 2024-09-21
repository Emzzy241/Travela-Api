using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace TravelApi.Models;
[Route("api/[controller]")]
[ApiController]
public class DestinationsController: ControllerBase
{
    private readonly TravelApiContext _db;

    public DestinationsController(TravelApiContext db)
    {
        _db = db;
    }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Destination>>> Get(string name, string country, string city, string destName, string review, int minimumRating)
        {
            IQueryable<Destination> querry = _db.Destinations.AsQueryable();

            if(name != null)
            {
                querry = querry.Where(entry => entry.UserName == name);
            }

            if(country != null)
            {
                querry = querry.Where(entry => entry.Country == country);
            }

            if(city != null)
            {
                querry = querry.Where(entry => entry.City == city);
            }

            if(destName != null)
            {
                querry = querry.Where(entry => entry.DestinationName == destName);
            }

            if (review != null)
            {
                querry = querry.Where(entry => entry.Review == review);
            }

            if (minimumRating > 0)
            {
                
                querry = querry.Where(entry => entry.OverallRating >= minimumRating);
            }
                return await querry.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Destination>> GetDestination(int id)
        {
                Destination dest = await _db.Destinations.FindAsync(id);

                if(dest != null)
                {
                    return dest;
                }
               
                    return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<Destination>> PostDestination(Destination dest)
        {
           
            _db.Destinations.Add(dest);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetDestination), new { id = dest.DestinationId}, dest);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Destination>> PutDestination(int id, Destination dest)
        {
           if(id != dest.DestinationId)
           {
                return BadRequest();
           }
           _db.Destinations.Update(dest);

           try
           {
               await _db.SaveChangesAsync();
           }
           catch (DbUpdateConcurrencyException)
           {
                if (!DestinationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
           }
           return NoContent();
        
        } 

        // [HttpDelete("{id}")]
        // public async Task<ActionResult<Destination>> DeleteDestination(int id)
        // {
        //     var dest = _db.Destinations.FindAsync(id);
        //    if(dest == null)
        //    {
        //         return NotFound();
        //    }
        //     _db.Destinations.Remove(dest);
        //     await _db.SaveChangesAsync();

        //     return NoContent();
        // }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Destination>> DeleteDestination(int id)
        {
            var dest = await _db.Destinations.FindAsync(id);
            if(dest == null)
            {
                return NotFound();
            }

            _db.Destinations.Remove(dest);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool DestinationExists(int id)
        {
            return _db.Destinations.Any(dest => dest.DestinationId == id);
        }
       
}