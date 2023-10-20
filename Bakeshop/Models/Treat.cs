using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bakeshop.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "Must input a type of treat!")]
    public string Type { get; set; }
    [Required(ErrorMessage = "Must input a description!")]
    public string Description { get; set; }
    public List<FlavorTreat> JoinEntities { get; }
    public ApplicationUser User { get; set; } 
  }
}