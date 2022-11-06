using DataLayer;
using LogicLayer;

namespace NotesAplicationDesktop
{
    public partial class Form1 : Form
    {
        int userId;
        string userName;
        string userEmail;
        string userPassword;
        List<Account> users;

        public Form1()
        {
            users = new List<Account>();
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbUsersList.Items.Clear();
            IAccountRepository accountRepository = new AccountRepository();
            IUserManagerDesktop userManager = new UserManager(accountRepository);

            if(tbUserId.Text != "")
            {
                try
                {
                    userId = int.Parse(tbUserId.Text);
                    if (userId <= 0)
                    {
                        throw new Exception();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Id must be intiger bigger than 0");
                }
            }
            else
            {
                userId = 0;
            }
            userName = tbUserName.Text;
            userEmail = tbUserEmail.Text;
            userPassword = tbUserPassword.Text;

            if(userId > 0)
            {
                users = new List<Account>() { userManager.ReadUser(userId, userName, userEmail, userPassword) };
                if (users[0] == null)
                    users = null;
            }
            else if(userId == 0)
            {
                users = userManager.ReadUsers(userName, userEmail, userPassword);
            }

            if (users != null)
            {
                foreach (Account user in users)
                {
                    lbUsersList.Items.Add(user.Id.ToString() + "; " + user.Name + "; " + user.Email + "; " + user.Password);
                }
            }
            else
                lbUsersList.Items.Add("There is no such User.");
        }
    }
}