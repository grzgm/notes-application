using LogicLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class SearchingUsersDesktop
    {
        private IAccountRepository accountRepository;
        private IUserManagerDesktop userManager;

        [TestMethod]
        public void SearchExistingUserWithAllParameters()
        {
            // Arrange
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);

            // Act
            Account ExistingUser = userManager.ReadUser(7, "NameUnitTest", "TestAccount@Email");

            // Assert
            Assert.AreEqual(ExistingUser.Name, "NameUnitTest");
        }

        [TestMethod]
        public void SearchExistingUserWithoutName()
        {
            // Arrange
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);

            // Act
            Account ExistingUser = userManager.ReadUser(7, "", "TestAccount@Email");

            // Assert
            Assert.AreEqual(ExistingUser.Name, "NameUnitTest");
        }

        [TestMethod]
        public void SearchExistingUserWithoutEmail()
        {
            // Arrange
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);

            // Act
            Account ExistingUser = userManager.ReadUser(7, "NameUnitTest", "");

            // Assert
            Assert.AreEqual(ExistingUser.Name, "NameUnitTest");
        }

        [TestMethod]
        public void SearchUserWithWrongName()
        {
            // Arrange
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);

            // Act
            Account ExistingUser = userManager.ReadUser(7, "Wrong", "TestAccount@Email");

            // Assert
            Assert.AreEqual(ExistingUser, null);
        }

        [TestMethod]
        public void SearchUserWithWrongMail()
        {
            // Arrange
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);

            // Act
            Account ExistingUser = userManager.ReadUser(7, "NameUnitTest", "Wrong");

            // Assert
            Assert.AreEqual(ExistingUser, null);
        }

        [TestMethod]
        public void SearchUserWithWrongId()
        {
            // Arrange
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);

            // Act
            Account ExistingUser = userManager.ReadUser(0, "NameUnitTest", "TestAccount@Email");

            // Assert
            Assert.AreEqual(ExistingUser, null);
        }
        [TestMethod]
        public void SearchUsersWithAllParameters()
        {
            // Arrange
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);

            // Act
            List<Account> ExistingUsers = userManager.ReadUsers("NameUnitTest", "TestAccount@Email");

            // Assert
            Assert.AreEqual(ExistingUsers.Count, 1);
        }
        [TestMethod]
        public void SearchUsersWithoutParameters()
        {
            // Arrange
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);

            // Act
            List<Account> ExistingUsers = userManager.ReadUsers("", "");

            // Assert
            Assert.AreEqual(ExistingUsers.Count, 3);
        }

        [TestMethod]
        public void SearchUsersWithAllWrongParameters()
        {
            // Arrange
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);


            // Act
            List<Account> ExistingUsers = userManager.ReadUsers("Wrong", "Wrong");

            // Assert
            Assert.AreEqual(ExistingUsers, null);
        }

        [TestMethod]
        public void SearchExistingUsersWithOnlyName()
        {
            // Arrange
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);

            // Act
            List<Account> ExistingUsers = userManager.ReadUsers("NameUnitTest", "");

            // Assert
            Assert.AreEqual(ExistingUsers.Count, 2);
        }

        [TestMethod]
        public void SearchExistingUsersWithOnlyEmail()
        {
            // Arrange
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);

            // Act
            List<Account> ExistingUsers = userManager.ReadUsers("", "TestAccount@Email");

            // Assert
            Assert.AreEqual(ExistingUsers.Count, 2);
        }

        [TestMethod]
        public void SearchUsersWithWrongName()
        {
            // Arrange
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);


            // Act
            List<Account> ExistingUsers = userManager.ReadUsers("Wrong", "TestAccount@Email");

            // Assert
            Assert.AreEqual(ExistingUsers, null);
        }

        [TestMethod]
        public void SearchUsersWithWrongEmail()
        {
            // Arrange
            accountRepository = new FakeAccountDB();
            userManager = new UserManager(accountRepository);


            // Act
            List<Account> ExistingUsers = userManager.ReadUsers("NameUnitTest", "Wrong");

            // Assert
            Assert.AreEqual(ExistingUsers, null);
        }
    }
}
