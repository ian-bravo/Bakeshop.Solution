using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bakeshop.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "Must input a type of flavor!")]
    public string Type { get; set; }
    public List<FlavorTreat> JoinEntities { get; }
    public ApplicationUser User { get; set; } 
  }
}