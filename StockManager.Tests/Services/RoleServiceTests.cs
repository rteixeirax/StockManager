using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockManager.Services.Contracts;
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
    private Configuration config;
    private IRoleService roleService;

    [TestInitialize]
    public void BeforeEach() {
      this.config = new Configuration();
      this.roleService = this.config.SetRoleService();
    }

    [TestCleanup]
    public void AfterEach() {
      this.config.CloseConnection();
    }

    /// <summary>
    /// Should get all roles
    /// </summary>
    [TestMethod]
    public async Task ShouldGetAllRoles() {
      // Arrange 

      // Act 
      IEnumerable<Role> roles = await this.roleService.GetRolesAsync();

      // Assert 
      Assert.AreEqual(roles.Count(), 2);
      Assert.AreEqual(roles.ElementAt(0).Code, "Admin");
      Assert.AreEqual(roles.ElementAt(1).Code, "User");
    }
  }
}
