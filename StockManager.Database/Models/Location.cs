using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StockManager.Database.Models
{
  public class Location : BaseEntity
  {
    [Key]
    public int LocationId { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
  }
}
