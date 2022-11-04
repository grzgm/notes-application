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
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);
            //Account modelUser = new User(7, "NameUnitTest", "TestAccount@Email", "PasswordUnitTest", 5, 100);

            Account LoginCorrectUser = userManager.ReadAccount("NameUnitTest", "PasswordUnitTest");

            Assert.AreEqual(LoginCorrectUser.Name, "NameUnitTest");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "There is no such user.")]
        public void LoginUserWithWrongCredentialsName()
        {
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);

            Account LoginCorrectUser = userManager.ReadAccount("Name", "PasswordUnitTest");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "There is no such user.")]
        public void LoginUserWithWrongCredentialsPassword()
        {
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);

            Account LoginCorrectUser = userManager.ReadAccount("NameUnitTest", "Password");
        }
    }
}