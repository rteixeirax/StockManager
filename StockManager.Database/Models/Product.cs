using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Database.Models
{
  public class Product : BaseEntity
  {
    [Key]
    public int ProductId { get; set; }

    [Required(ErrorMessage = "Reference is required")]
    public string Reference { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
  }
}
