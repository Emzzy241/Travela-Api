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
    
    // Users can rate a destination with the maximum being 5
    [Required]
    [Range(1, 5, ErrorMessage = "You can only rate a destination from a low score of 1 and a high score of 5")]
    public int OverallRating { get; set; }
    
    
    

}