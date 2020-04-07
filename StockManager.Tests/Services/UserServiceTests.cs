using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StockManager.Storage.Contracts;
using StockManager.Storage.Models;
using Tynamix.ObjectFiller;
using StockManager.Services.Services;
using System.Threading.Tasks;
using StockManager.Types.Types;

namespace StockManager.Tests.Services {
  /// <summary>
  /// User service tests
  /// </summary>
  [TestClass]
  public class UserServiceTests {
    private readonly Mock<IUserRepository> userRepo;

    public UserServiceTests() {
      this.userRepo = new Mock<IUserRepository>();
    }

    /// <summary>
    /// Test user create
    /// </summary>
    [TestMethod]
    public async Task ShouldCreateUserAsync() {
      // Arrange 
      User user = new Filler<User>().Create();
      this.userRepo.Setup(repo => repo.AddUserAsync(It.IsAny<User>()));

      // Act 
      var userService = new UserService(this.userRepo.Object);
      await userService.CreateUserAsync(user);

      // Assert 
      this.userRepo.Verify(repo => repo.AddUserAsync(It.IsAny<User>()), Times.Once);
    }

    /// <summary>
    /// Test user create fails
    /// </summary>
    [TestMethod]
    public async Task ShouldThrowOperationExceptionWhenCreateUserAsyncFails() {
      // Arrange 
      User user = new Filler<User>().Create();
      OperationErrorException operationErrorException = this.CreateOperationErrorException();

      userRepo.Setup(broker => broker.AddUserAsync(It.IsAny<User>()))
        .Throws(operationErrorException);

      try {
        // Act 
        var userService = new UserService(userRepo.Object);
        await userService.CreateUserAsync(user);
      } catch (OperationErrorException ex) {
        // Assert 
        this.userRepo.Verify(broker => broker.AddUserAsync(It.IsAny<User>()), Times.Once);
        Assert.AreEqual(ex.Errors.Count, 1);
      }
    }

    /// <summary>
    /// Test user update
    /// </summary>
    //[TestMethod]
    //public async Task ShouldEditUserAsync() {
    //  // Arrange 
    //  User user = new Filler<User>().Create();
    //  this.userRepo.Setup(repo => repo.AddUserAsync(It.IsAny<User>()));
    //  //this.userRepo.Setup(repo => repo.UpdateUser(It.IsAny<User>()));

    //  // Act 
    //  var userService = new UserService(this.userRepo.Object);
    //  await userService.EditUserAsync(user);

    //  // Assert 
    //  this.userRepo.Verify(repo => repo.SaveDbChangesAsync(), Times.Once);
    //}

    /// <summary>
    /// Create operation error exception
    /// </summary>
    private OperationErrorException CreateOperationErrorException() {
      OperationErrorsList errorsList = new OperationErrorsList();
      errorsList.AddError(new MnemonicString().GetValue(), new MnemonicString().GetValue());

      OperationErrorException operationErrorException = new OperationErrorException(errorsList);

      return operationErrorException;
    }
  }
}
