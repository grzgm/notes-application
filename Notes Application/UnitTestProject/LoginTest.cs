using DataLayer;
using LogicLayer;
using System.Xml.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class LoginTest
    {
/*        private readonly IAccountRepository accountRepository;
        private readonly IUserManager userManager;

        public LoginTest()
        {
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);
        }*/
        private IAccountRepository accountRepository;
        private IUserManager userManager;

        [TestMethod]
        public void LoginUser()
        {
            // Arrange
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);
            //Account modelUser = new User(7, "NameUnitTest", "TestAccount@Email", "PasswordUnitTest", 5, 100);

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