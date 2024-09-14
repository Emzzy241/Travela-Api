using TravelApi.Models;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TravelApi.Models;
public class Destination
{
    // The primary key for tracking our entity
    [Required]
    public int DestinationId { get; set; }

    [Required]
    [StringLength(20)]
    public string UserName { get; set; }

    [Required]
    public string Country { get; set; }
    
    [Required]
    public string City { get; set; }
    
    [Required]
    public string DestinationName { get; set; }

    [Required]
    public string Review { get; set; }
    
    [Required]
    public string OverallRating { get; set; }
    
    
    

}