﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.Database.Models
{
  public class Role
  {
    [Key]
    public Guid RoleId
    {
      get => RoleId; set => Guid.NewGuid();
    }

    [Required(ErrorMessage = "Code is required")]
    public string Code { get; set; }
  }
}