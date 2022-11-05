using DataLayer;
using LogicLayer;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class RegisterTest
    {
        private IAccountRepository accountRepository;
        private IUserManager userManager;

        [TestMethod]
        public void RegisterUser()
        {
            // Arrange
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);

            // Act
            Account RegisterCorrectUser = userManager.CreateUser("NameUnitTest", "TestAccount@Email", "PasswordUnitTest");

            // Assert
            Assert.AreEqual(RegisterCorrectUser.Name, "NameUnitTest");
        }

        // Assert
        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void RegisterAlreadyRegisteredUser()
        {
            // Arrange
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);

            // Act
            Account RegisterExistingUser = userManager.CreateUser("SqlException", "SqlException", "SqlException");
        }

        // Assert
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void RegisterUserWithWrongCredentialsPassword()
        {
            // Arrange
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);

            // Act
            Account RegisterIncorrectUser = userManager.CreateUser("", "", "");
        }
    }
}