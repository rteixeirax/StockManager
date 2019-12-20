using StockManager.Database.Models;

namespace StockManager.Database.Repositories
{
  public interface IUserRepository
  {
    bool CreateUser(User user);
  }
}
