using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using StockManager.Core.Source.Models;
using StockManager.Core.Source.Types;
using StockManager.Services.Source;
using StockManager.Tests.Source;
using StockManager.Translations.Source;

namespace StockManager.Tests.Services
{
    /// <summary>
    /// User service tests
    /// </summary>
    [TestClass]
    public class UserServiceTests
    {
        private User _mockUser;
        private TestsConfig config;

        [TestCleanup]
        public void AfterEach()
        {
            config.CloseConnection();
        }

        [TestInitialize]
        public void BeforeEach()
        {
            config = new TestsConfig();

            _mockUser = new User()
            {
                Username = "manel",
                Password = "123",
                RoleId = 1, // admin
            };
        }

        /// <summary>
        /// Should authenticate user
        /// </summary>
        [TestMethod]
        public async Task ShouldAuthenticateUser()
        {
            // Arrange
            User adminUser = await AppServices.UserService.GetByIdAsync(1);

            // Act
            await AppServices.UserService.AuthenticateAsync(adminUser.Username, "admin");

            // Assert
            Assert.IsNotNull(adminUser.LastLogin);
        }

        /// <summary>
        /// Should change password
        /// </summary>
        [TestMethod]
        public async Task ShouldChangePassword()
        {
            // Arrange
            User adminUser = await AppServices.UserService.GetByIdAsync(1);

            // Act
            await AppServices.UserService.ChangePasswordAsync(adminUser.UserId, "admin", "newPassword");

            // Assert
            Assert.IsTrue(BCrypt.Net.BCrypt.Verify("newPassword", adminUser.Password));
        }

        /// <summary>
        /// Should create user
        /// </summary>
        [TestMethod]
        public async Task ShouldCreateUser()
        {
            // Arrange
            User newUser = _mockUser;

            // Act
            await AppServices.UserService.CreateAsync(newUser);

            // Assert
            Assert.AreEqual(newUser.Username, "manel");
            Assert.AreEqual(newUser.RoleId, 1);
            Assert.IsTrue(BCrypt.Net.BCrypt.Verify("123", newUser.Password));
            Assert.IsNotNull(newUser.CreatedAt);
            Assert.IsNotNull(newUser.UpdatedAt);
        }

        /// <summary>
        /// Should delete user
        /// </summary>
        [TestMethod]
        public async Task ShouldDeleteUser()
        {
            // Arrange
            User mockUser = _mockUser;
            User loggedInUser = await AppServices.UserService.GetByIdAsync(1);
            await AppServices.UserService.CreateAsync(mockUser);

            // Act
            await AppServices.UserService.DeleteAsync(new int[] { mockUser.UserId }, loggedInUser.UserId);
            User dbUser = await AppServices.UserService.GetByIdAsync(mockUser.UserId);

            // Assert
            Assert.IsNull(dbUser);
        }

        /// <summary>
        /// Should edit user
        /// </summary>
        [TestMethod]
        public async Task ShouldEditUser()
        {
            // Arrange
            User mockUser = _mockUser;
            mockUser.RoleId = 2; // user
            await AppServices.UserService.CreateAsync(mockUser);

            // Act
            User updatedUser = new User()
            {
                UserId = mockUser.UserId,
                RoleId = 1,
                Username = "manelito updated",
                Password = "321",
            };

            await AppServices.UserService.EditAsync(updatedUser);
            User dbUser = await AppServices.UserService.GetByIdAsync(updatedUser.UserId);

            // Assert
            Assert.AreEqual(dbUser.UserId, updatedUser.UserId);
            Assert.AreEqual(dbUser.Username, "manelito updated");
            Assert.IsTrue(BCrypt.Net.BCrypt.Verify(updatedUser.Password, dbUser.Password));
            Assert.AreEqual(dbUser.RoleId, 1);
        }

        /// <summary>
        /// Should fail authenticate user - bad username and password combination
        /// </summary>
        [TestMethod]
        public async Task ShouldFailAuthenticateUser_BadUsernameAndPasswordCombination()
        {
            // Arrange
            User adminUser = await AppServices.UserService.GetByIdAsync(1);

            try
            {
                // Act
                await AppServices.UserService.AuthenticateAsync(adminUser.Username, "notMyPassword");

                Assert.Fail("It should have thrown an OperationErrorExeption");
            }
            catch (OperationErrorException ex)
            {
                // Assert
                Assert.AreEqual(ex.Errors.Count, 1);
                Assert.AreEqual(ex.Errors[0].Field, "Generic");
                Assert.AreEqual(ex.Errors[0].Error, Phrases.UserErrorLogin);
            }
        }

        /// <summary>
        /// Should fail authenticate user - no username and password sent
        /// </summary>
        [TestMethod]
        public async Task ShouldFailAuthenticateUser_NoUsernameAndPasswordSent()
        {
            // Arrange nothing to arrange...

            try
            {
                // Act
                await AppServices.UserService.AuthenticateAsync("", "");

                Assert.Fail("It should have thrown an OperationErrorExeption");
            }
            catch (OperationErrorException ex)
            {
                // Assert
                Assert.AreEqual(ex.Errors.Count, 2);
                Assert.AreEqual(ex.Errors[0].Field, "Username");
                Assert.AreEqual(ex.Errors[0].Error, Phrases.GlobalRequiredField);
                Assert.AreEqual(ex.Errors[1].Field, "Password");
                Assert.AreEqual(ex.Errors[1].Error, Phrases.GlobalRequiredField);
            }
        }

        /// <summary>
        /// Should fail change password - no current and new password sent
        /// </summary>
        [TestMethod]
        public async Task ShouldFailChangePassword_NoCurrentAndNewPasswordSent()
        {
            // Arrange
            User adminUser = await AppServices.UserService.GetByIdAsync(1);

            try
            {
                // Act
                await AppServices.UserService.ChangePasswordAsync(adminUser.UserId, "", "");

                Assert.Fail("It should have thrown an OperationErrorExeption");
            }
            catch (OperationErrorException ex)
            {
                // Assert
                Assert.AreEqual(ex.Errors.Count, 2);
                Assert.AreEqual(ex.Errors[0].Field, "CurrentPassword");
                Assert.AreEqual(ex.Errors[0].Error, Phrases.GlobalRequiredField);
                Assert.AreEqual(ex.Errors[1].Field, "NewPassword");
                Assert.AreEqual(ex.Errors[1].Error, Phrases.GlobalRequiredField);
            }
        }

        /// <summary>
        /// Should fail change password - no valid current password sent
        /// </summary>
        [TestMethod]
        public async Task ShouldFailChangePassword_NoValidCurrentPasswordSent()
        {
            // Arrange
            User adminUser = await AppServices.UserService.GetByIdAsync(1);

            try
            {
                // Act
                await AppServices.UserService.ChangePasswordAsync(adminUser.UserId, "invalidCurrentPass", "newPassword");

                Assert.Fail("It should have thrown an OperationErrorExeption");
            }
            catch (OperationErrorException ex)
            {
                // Assert
                Assert.AreEqual(ex.Errors.Count, 1);
                Assert.AreEqual(ex.Errors[0].Field, "CurrentPassword");
                Assert.AreEqual(ex.Errors[0].Error, Phrases.UserErrorInvalidPassword);
            }
        }

        /// <summary>
        /// Should fail create user with a existing username
        /// </summary>
        [TestMethod]
        public async Task ShouldFailCreateUser_ExistingUsername()
        {
            // Arrange
            User newUser = _mockUser;

            try
            {
                // Act
                newUser.Username = "admin";
                await AppServices.UserService.CreateAsync(newUser);

                Assert.Fail("It should have thrown an OperationErrorExeption");
            }
            catch (OperationErrorException ex)
            {
                // Assert
                Assert.AreEqual(ex.Errors.Count, 1);
                Assert.AreEqual(ex.Errors[0].Field, "Username");
                Assert.AreEqual(ex.Errors[0].Error, Phrases.UserErrorUsername);
            }
        }

        /// <summary>
        /// Should fali delete user - loggedInUser
        /// </summary>
        [TestMethod]
        public async Task ShouldFailDeleteUser_LoggedInUser()
        {
            // Arrange
            User loggedInUser = await AppServices.UserService.GetByIdAsync(1);

            try
            {
                // Act
                await AppServices.UserService.DeleteAsync(new int[] { loggedInUser.UserId }, loggedInUser.UserId);

                Assert.Fail("It should have thrown an OperationErrorExeption");
            }
            catch (OperationErrorException ex)
            {
                // Assert
                Assert.AreEqual(ex.Errors.Count, 1);
                Assert.AreEqual(ex.Errors[0].Field, "LoggedInUserId");
                Assert.AreEqual(ex.Errors[0].Error, Phrases.UserErrorDeleteYourself);
            }
        }

        /// <summary>
        /// Should fail edit user - existing username
        /// </summary>
        [TestMethod]
        public async Task ShouldFailEditUser_ExistingUsername()
        {
            // Arrange
            User mockUser = _mockUser;
            await AppServices.UserService.CreateAsync(mockUser);

            try
            {
                // Act
                User updatedUser = new User()
                {
                    UserId = mockUser.UserId,
                    RoleId = mockUser.RoleId,
                    Username = "admin",
                };

                await AppServices.UserService.EditAsync(updatedUser);

                Assert.Fail("It should have thrown an OperationErrorExeption");
            }
            catch (OperationErrorException ex)
            {
                // Assert
                Assert.AreEqual(ex.Errors.Count, 1);
                Assert.AreEqual(ex.Errors[0].Field, "Username");
                Assert.AreEqual(ex.Errors[0].Error, Phrases.UserErrorUsername);
            }
        }

        /// <summary>
        /// Should get all users
        /// </summary>
        [TestMethod]
        public async Task ShouldGetAllUsers()
        {
            // Arrange
            User newUser = _mockUser;
            await AppServices.UserService.CreateAsync(newUser);

            // Act
            IEnumerable<User> users = await AppServices.UserService.GetAllAsync();

            // Assert
            Assert.AreEqual(users.Count(), 2);
            Assert.AreEqual(users.ElementAt(0).Username, "Admin");
            Assert.AreEqual(users.ElementAt(1).Username, newUser.Username);
        }

        /// <summary>
        /// Should search user by username
        /// </summary>
        [TestMethod]
        public async Task ShouldSearchUserByUsername()
        {
            // Arrange
            User adminUser = await AppServices.UserService.GetByIdAsync(1);
            User newUser = _mockUser;
            await AppServices.UserService.CreateAsync(newUser);

            // Act
            IEnumerable<User> users = await AppServices.UserService.GetAllAsync(adminUser.Username);

            // Assert
            Assert.AreEqual(users.Count(), 1);
            Assert.AreEqual(users.ElementAt(0).Username, adminUser.Username);
        }

        /// <summary>
        /// Should fail create user - no usernmae and password sent
        /// </summary>
        [TestMethod]
        public async Task ShoulFailCreateUser_NoUsernameAndPasswordSent()
        {
            // Arrange
            User newUser = new User() { RoleId = 1 };

            try
            {
                // Act
                await AppServices.UserService.CreateAsync(newUser);

                Assert.Fail("It should have thrown an OperationErrorExeption");
            }
            catch (OperationErrorException ex)
            {
                // Assert
                Assert.AreEqual(ex.Errors.Count, 2);
                Assert.AreEqual(ex.Errors[0].Field, "Username");
                Assert.AreEqual(ex.Errors[0].Error, Phrases.GlobalRequiredField);
                Assert.AreEqual(ex.Errors[1].Field, "Password");
                Assert.AreEqual(ex.Errors[1].Error, Phrases.GlobalRequiredField);
            }
        }
    }
}
