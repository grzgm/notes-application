using DataLayer;
using LogicLayer;
using System.Xml.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class LoginTestWeb
    {
        private IAccountRepository accountRepository;
        private IUserManagerWeb userManager;

        [TestMethod]
        public void LoginUser()
        {
            // Arrange
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);

            // Act
            Account LoginCorrectUser = userManager.ReadAccount("NameUnitTest", "PasswordUnitTest");

            // Assert
            Assert.AreEqual(LoginCorrectUser.Name, "NameUnitTest");
        }

        // Assert
        [TestMethod]
        [ExpectedException(typeof(Exception), "There is no such user.")]
        public void LoginUserWithWrongCredentialsName()
        {
            // Arrange
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);

            // Act
            Account LoginIncorrectUser = userManager.ReadAccount("Name", "PasswordUnitTest");
        }

        // Assert
        [TestMethod]
        [ExpectedException(typeof(Exception), "There is no such user.")]
        public void LoginUserWithWrongCredentialsPassword()
        {
            // Arrange
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);

            // Act
            Account LoginIncorrectUser = userManager.ReadAccount("NameUnitTest", "Password");
        }
    }
}