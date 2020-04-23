﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockManager.Services.Contracts;
using StockManager.Storage.Models;
using StockManager.Translations.Source;
using StockManager.Types.Types;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Tests.Services {
  /// <summary>
  /// User service tests
  /// </summary>
  [TestClass]
  public class UserServiceTests {
    private Configuration config;
    private IUserService userService;
    private User mockUser;

    [TestInitialize]
    public void BeforeEach() {
      this.config = new Configuration();
      this.userService = this.config.SetUserService();
      this.mockUser = new User() {
        Username = "manel",
        Password = "123",
        RoleId = 1, // admin
      };
    }

    [TestCleanup]
    public void AfterEach() {
      this.config.CloseConnection();
    }

    /// <summary>
    /// Should get all users
    /// </summary>
    [TestMethod]
    public async Task ShouldGetAllUsers() {
      // Arrange 
      User newUser = this.mockUser;
      await this.userService.CreateUserAsync(newUser);

      // Act 
      IEnumerable<User> users = await this.userService.GetUsersAsync();

      // Assert 
      Assert.AreEqual(users.Count(), 2);
      Assert.AreEqual(users.ElementAt(0).Username, "Admin");
      Assert.AreEqual(users.ElementAt(1).Username, newUser.Username);
    }

    /// <summary>
    /// Should search user by username
    /// </summary>
    [TestMethod]
    public async Task ShouldSearchUserByUsername() {
      // Arrange 
      User adminUser = await this.userService.GetUserByIdAsync(1);
      User newUser = this.mockUser;
      await this.userService.CreateUserAsync(newUser);

      // Act 
      IEnumerable<User> users = await this.userService.GetUsersAsync(adminUser.Username);

      // Assert 
      Assert.AreEqual(users.Count(), 1);
      Assert.AreEqual(users.ElementAt(0).Username, adminUser.Username);
    }

    /// <summary>
    /// Should create user
    /// </summary>
    [TestMethod]
    public async Task ShouldCreateUser() {
      // Arrange 
      User newUser = this.mockUser;

      // Act 
      await this.userService.CreateUserAsync(newUser);

      // Assert 
      Assert.AreEqual(newUser.Username, "manel");
      Assert.AreEqual(newUser.RoleId, 1);
      Assert.IsTrue(BCrypt.Net.BCrypt.Verify("123", newUser.Password));
      Assert.IsNotNull(newUser.CreatedAt);
      Assert.IsNotNull(newUser.UpdatedAt);
    }

    /// <summary>
    /// Should fail create user with a existing username
    /// </summary>
    [TestMethod]
    public async Task ShouldFailCreateUser_ExistingUsername() {
      // Arrange 
      User newUser = this.mockUser;

      try {
        // Act 
        newUser.Username = "admin";
        await this.userService.CreateUserAsync(newUser);

        Assert.Fail("It should have thrown an OperationErrorExeption");
      } catch (OperationErrorException ex) {
        // Assert 
        Assert.AreEqual(ex.Errors.Count, 1);
        Assert.AreEqual(ex.Errors[0].Field, "Username");
        Assert.AreEqual(ex.Errors[0].Error, Phrases.UserErrorUsername);
      }
    }

    /// <summary>
    /// Should fail create user - no usernmae and password sent
    /// </summary>
    [TestMethod]
    public async Task ShoulFailCreateUser_NoUsernameAndPasswordSent() {
      // Arrange 
      User newUser = new User() { RoleId = 1 };

      try {
        // Act 
        await this.userService.CreateUserAsync(newUser);

        Assert.Fail("It should have thrown an OperationErrorExeption");
      } catch (OperationErrorException ex) {
        // Assert 
        Assert.AreEqual(ex.Errors.Count, 2);
        Assert.AreEqual(ex.Errors[0].Field, "Username");
        Assert.AreEqual(ex.Errors[0].Error, Phrases.GlobalRequiredField);
        Assert.AreEqual(ex.Errors[1].Field, "Password");
        Assert.AreEqual(ex.Errors[1].Error, Phrases.GlobalRequiredField);
      }
    }

    /// <summary>
    /// Should edit user
    /// </summary>
    [TestMethod]
    public async Task ShouldEditUser() {
      // Arrange 
      User mockUser = this.mockUser;
      mockUser.RoleId = 2; // user
      await this.userService.CreateUserAsync(mockUser);

      // Act
      User updatedUser = new User() {
        UserId = mockUser.UserId,
        RoleId = 1,
        Username = "manelito updated",
        Password = "321",
      };

      await this.userService.EditUserAsync(updatedUser);
      User dbUser = await this.userService.GetUserByIdAsync(updatedUser.UserId);

      // Assert
      Assert.AreEqual(dbUser.UserId, updatedUser.UserId);
      Assert.AreEqual(dbUser.Username, "manelito updated");
      Assert.IsTrue(BCrypt.Net.BCrypt.Verify(updatedUser.Password, dbUser.Password));
      Assert.AreEqual(dbUser.RoleId, 1);
    }

    /// <summary>
    /// Should fail edit user - existing username
    /// </summary>
    [TestMethod]
    public async Task ShouldFailEditUser_ExistingUsername() {
      // Arrange 
      User mockUser = this.mockUser;
      await this.userService.CreateUserAsync(mockUser);

      try {
        // Act
        User updatedUser = new User() {
          UserId = mockUser.UserId,
          RoleId = mockUser.RoleId,
          Username = "admin",
        };

        await this.userService.EditUserAsync(updatedUser);

        Assert.Fail("It should have thrown an OperationErrorExeption");
      } catch (OperationErrorException ex) {
        // Assert 
        Assert.AreEqual(ex.Errors.Count, 1);
        Assert.AreEqual(ex.Errors[0].Field, "Username");
        Assert.AreEqual(ex.Errors[0].Error, Phrases.UserErrorUsername);
      }
    }

    /// <summary>
    /// Should delete user
    /// </summary>
    [TestMethod]
    public async Task ShouldDeleteUser() {
      // Arrange 
      User mockUser = this.mockUser;
      User loggedInUser = await this.userService.GetUserByIdAsync(1);
      await this.userService.CreateUserAsync(mockUser);

      // Act
      await this.userService.DeleteUserAsync(new int[] { mockUser.UserId }, loggedInUser.UserId);
      User dbUser = await this.userService.GetUserByIdAsync(mockUser.UserId);

      // Assert
      Assert.IsNull(dbUser);
    }

    /// <summary>
    /// Should fali delete user - loggedInUser
    /// </summary>
    [TestMethod]
    public async Task ShouldFailDeleteUser_LoggedInUser() {
      // Arrange 
      User loggedInUser = await this.userService.GetUserByIdAsync(1);

      try {
        // Act
        await this.userService.DeleteUserAsync(new int[] { loggedInUser.UserId }, loggedInUser.UserId);

        Assert.Fail("It should have thrown an OperationErrorExeption");
      } catch (OperationErrorException ex) {
        // Assert 
        Assert.AreEqual(ex.Errors.Count, 1);
        Assert.AreEqual(ex.Errors[0].Field, "LoggedInUserId");
        Assert.AreEqual(ex.Errors[0].Error, Phrases.UserErrorDeleteYourself);
      }
    }

    /// <summary>
    /// Should change password
    /// </summary>
    [TestMethod]
    public async Task ShouldChangePassword() {
      // Arrange 
      User adminUser = await this.userService.GetUserByIdAsync(1);

      // Act 
      await this.userService.ChangePasswordAsync(adminUser.UserId, "admin", "newPassword");

      // Assert 
      Assert.IsTrue(BCrypt.Net.BCrypt.Verify("newPassword", adminUser.Password));
    }

    /// <summary>
    ///  Should fail change password - no valid current password sent
    /// </summary>
    [TestMethod]
    public async Task ShouldFailChangePassword_NoValidCurrentPasswordSent() {
      // Arrange 
      User adminUser = await this.userService.GetUserByIdAsync(1);

      try {
        // Act
        await this.userService.ChangePasswordAsync(adminUser.UserId, "invalidCurrentPass", "newPassword");

        Assert.Fail("It should have thrown an OperationErrorExeption");
      } catch (OperationErrorException ex) {
        // Assert 
        Assert.AreEqual(ex.Errors.Count, 1);
        Assert.AreEqual(ex.Errors[0].Field, "CurrentPassword");
        Assert.AreEqual(ex.Errors[0].Error, Phrases.UserErrorInvalidPassword);
      }
    }

    /// <summary>
    /// Should fail change password - no current and new password sent
    /// </summary>
    [TestMethod]
    public async Task ShouldFailChangePassword_NoCurrentAndNewPasswordSent() {
      // Arrange 
      User adminUser = await this.userService.GetUserByIdAsync(1);

      try {
        // Act
        await this.userService.ChangePasswordAsync(adminUser.UserId, "", "");

        Assert.Fail("It should have thrown an OperationErrorExeption");
      } catch (OperationErrorException ex) {
        // Assert 
        Assert.AreEqual(ex.Errors.Count, 2);
        Assert.AreEqual(ex.Errors[0].Field, "CurrentPassword");
        Assert.AreEqual(ex.Errors[0].Error, Phrases.GlobalRequiredField);
        Assert.AreEqual(ex.Errors[1].Field, "NewPassword");
        Assert.AreEqual(ex.Errors[1].Error, Phrases.GlobalRequiredField);
      }
    }

    /// <summary>
    /// Should authenticate user
    /// </summary>
    [TestMethod]
    public async Task ShouldAuthenticateUser() {
      // Arrange 
      User adminUser = await this.userService.GetUserByIdAsync(1);

      // Act 
      await this.userService.AuthenticateAsync(adminUser.Username, "admin");

      // Assert 
      Assert.IsNotNull(adminUser.LastLogin);
    }

    /// <summary>
    /// Should fail authenticate user - no username and password sent
    /// </summary>
    [TestMethod]
    public async Task ShouldFailAuthenticateUser_NoUsernameAndPasswordSent() {
      // Arrange 
      // nothing to arrange...

      try {
        // Act
        await this.userService.AuthenticateAsync("", "");

        Assert.Fail("It should have thrown an OperationErrorExeption");
      } catch (OperationErrorException ex) {
        // Assert 
        Assert.AreEqual(ex.Errors.Count, 2);
        Assert.AreEqual(ex.Errors[0].Field, "Username");
        Assert.AreEqual(ex.Errors[0].Error, Phrases.GlobalRequiredField);
        Assert.AreEqual(ex.Errors[1].Field, "Password");
        Assert.AreEqual(ex.Errors[1].Error, Phrases.GlobalRequiredField);
      }
    }

    /// <summary>
    /// Should fail authenticate user - bad username and password combination
    /// </summary>
    [TestMethod]
    public async Task ShouldFailAuthenticateUser_BadUsernameAndPasswordCombination() {
      // Arrange 
      User adminUser = await this.userService.GetUserByIdAsync(1);

      try {
        // Act
        await this.userService.AuthenticateAsync(adminUser.Username, "notMyPassword");

        Assert.Fail("It should have thrown an OperationErrorExeption");
      } catch (OperationErrorException ex) {
        // Assert 
        Assert.AreEqual(ex.Errors.Count, 1);
        Assert.AreEqual(ex.Errors[0].Field, "Generic");
        Assert.AreEqual(ex.Errors[0].Error, Phrases.UserErrorLogin);
      }
    }
  }
}
