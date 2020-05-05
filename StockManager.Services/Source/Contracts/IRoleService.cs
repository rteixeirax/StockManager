﻿using StockManager.Storage.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Contracts {
  public interface IRoleService {
    Task<IEnumerable<Role>> GetRolesAsync();
  }
}