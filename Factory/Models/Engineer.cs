using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    
    [Required(ErrorMessage = "Please enter an engineer name!")]
    public string EngineerName { get; set; }
    public List<MachineEngineer> JoinEntities { get; }
  }
}