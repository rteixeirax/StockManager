using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockManager.Services;
using StockManager.Storage.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Tests.Services {
  /// <summary>
  /// Role service tests
  /// </summary>
  [TestClass]
  public class RoleServiceTests {
    private TestsConfig _config;

    [TestInitialize]
    public void BeforeEach() {
      _config = new TestsConfig();
    }

    [TestCleanup]
    public void AfterEach() {
      _config.CloseConnection();
    }

    /// <summary>
    /// Should get all roles
    /// </summary>
    [TestMethod]
    public async Task ShouldGetAllRoles() {
      // Arrange 

      // Act 
      IEnumerable<Role> roles = await AppServices.RoleService.GetRolesAsync();

      // Assert 
      Assert.AreEqual(roles.Count(), 2);
      Assert.AreEqual(roles.ElementAt(0).Code, "Admin");
      Assert.AreEqual(roles.ElementAt(1).Code, "User");
    }
  }
}
