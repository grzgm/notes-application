using DataLayer;
using LogicLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NotesAplicationDesktop
{
    public partial class Form1 : Form
    {
        int userId;
        string userName;
        string userEmail;
        List<Account> users;
        Account selectedUser;
        List<Note> notes;
        Note selectedNote;

        public Form1()
        {
            users = new List<Account>();
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ResetNotesManageGroup();
            ResetAccountManageGroup();
            users = null;
            notes = null;

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
            userName = tbUserNameSearch.Text;
            userEmail = tbUserEmailSearch.Text;

            if(userId > 0)
            {
                users = new List<Account>() { userManager.ReadUser(userId, userName, userEmail) };
                if (users[0] == null)
                    users = null;
            }
            else if(userId == 0)
            {
                users = userManager.ReadUsers(userName, userEmail);
            }

            if (users != null)
            {
                //foreach (Account user in users)
                //{
                //    lbUsersList.Items.Add(user.Id.ToString() + "; " + user.Name + "; " + user.Email);
                //}

                lbUsersList.SelectedIndexChanged -= lbUsersList_SelectedIndexChanged;
                lbUsersList.DataSource = users;
                lbUsersList.SelectedIndex = -1;
                lbUsersList.SelectedIndexChanged += lbUsersList_SelectedIndexChanged;
            }
            else
            {
                lbUsersList.DataSource = null;
                lbUsersList.Items.Clear();
                lbUsersList.Items.Add("There is no such User.");
            }
        }

        private void lbUsersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = lbUsersList.SelectedItem;

            if (selectedItem is Account)
            {
                selectedUser = (Account)selectedItem;
                EnableAccountManageGroup();
                EnableNotesManageGroup();

            }
        }

        private void EnableAccountManageGroup()
        {
            gbAccountManage.Enabled = true;
            tbUserNameManage.Text = selectedUser.Name;
            tbUserEmailManage.Text = selectedUser.Email;
            tbMaxAmountOfNotes.Text = ((User)selectedUser).MaxAmountOfNotes.ToString();
            tbMaxLengthOfNotes.Text = ((User)selectedUser).MaxLengthOfNotes.ToString();

            if (selectedUser is PremiumUser)
            {
                tbPremiumEndDate.Enabled = true;
                tbPremiumEndDate.Text = selectedUser.Email;
            }
        }

        private void ResetAccountManageGroup()
        {
            gbAccountManage.Enabled = false;
            tbUserNameManage.Text = String.Empty;
            tbUserEmailManage.Text = String.Empty;
            tbMaxAmountOfNotes.Text = String.Empty;
            tbMaxLengthOfNotes.Text = String.Empty;
            tbPremiumEndDate.Text = String.Empty;
            selectedUser = null;
        }

        private void EnableNotesManageGroup()
        {
            gbNotesManage.Enabled = true;
            INoteRepository noteRepository = new NoteRepository();
            INoteManagerWeb noteManager = new NoteManager(noteRepository);
            notes = noteManager.ReadNotes(selectedUser.Id);
            lbNotesList.DataSource = notes;
        }

        private void ResetNotesManageGroup()
        {
            gbNotesManage.Enabled = false;
            tbNoteTitle.Text = String.Empty;
            tbNotesText.Text = String.Empty;
            lbNotesList.DataSource = null;
            lbNotesList.Items.Clear();
        }

        private void lbNotesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (notes.Any() && selectedUser != null)
            {
                selectedNote = (Note)lbNotesList.SelectedItem;
                tbNoteTitle.Text = selectedNote.Title;
                tbNotesText.Text = selectedNote.Text;
            }
        }
    }
}