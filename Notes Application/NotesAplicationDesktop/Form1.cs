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

        IAccountRepository accountRepository;
        IUserManagerDesktop userManager;
        INoteRepository noteRepository;
        INoteManagerWeb noteManager;

        public Form1()
        {
            accountRepository = new AccountRepository();
            userManager = new UserManager(accountRepository);
            noteRepository = new NoteRepository();
            noteManager = new NoteManager(noteRepository);
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DisableNotesManageGroup();
            DisableAccountManageGroup();
            users = null;
            notes = null;

            // input Id validation
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
                    return;
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
                ResetListBoxUsersList();
            }
            else
            {
                lbUsersList.DataSource = null;
                lbUsersList.Items.Clear();
                lbUsersList.Items.Add("There is no such User.");
            }
        }

        private void DisableAccountManageGroup()
        {
            gbAccountManage.Enabled = false;
            tbUserNameManage.Text = String.Empty;
            tbUserEmailManage.Text = String.Empty;
            tbMaxAmountOfNotes.Text = String.Empty;
            tbMaxLengthOfNotes.Text = String.Empty;
            tbPremiumDaysLeft.Text = String.Empty;
            selectedUser = null;
        }

        private void DisableNotesManageGroup()
        {
            gbNotesManage.Enabled = false;
            tbNoteTitle.Text = String.Empty;
            tbNoteText.Text = String.Empty;

            lbNotesList.SelectedIndexChanged -= lbNotesList_SelectedIndexChanged;
            lbNotesList.DataSource = null;
            lbNotesList.Items.Clear();
            lbNotesList.SelectedIndexChanged += lbNotesList_SelectedIndexChanged;
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
                tbPremiumDaysLeft.Enabled = true;
                tbPremiumDaysLeft.Text = ((PremiumUser)selectedUser).DaysOfPremiumLeft.ToString();
            }
            else
            {
                tbPremiumDaysLeft.Enabled = false;
                tbPremiumDaysLeft.Text = String.Empty;
            }
        }

        private void EnableNotesManageGroup()
        {
            gbNotesManage.Enabled = true;
            notes = noteManager.ReadNotes(selectedUser.Id);
            lbNotesList.DataSource = notes;
        }

        private void lbNotesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (notes.Any() && lbNotesList.SelectedItem != null)
            {
                selectedNote = (Note)lbNotesList.SelectedItem;
                tbNoteTitle.Text = selectedNote.Title;
                tbNoteText.Text = selectedNote.Text;
            }
        }

        private void btUpdateUser_Click(object sender, EventArgs e)
        {
            selectedUser.Name = tbUserNameManage.Text;
            selectedUser.Email = tbUserEmailManage.Text;
            ((User)selectedUser).MaxAmountOfNotes = int.Parse(tbMaxAmountOfNotes.Text);
            ((User)selectedUser).MaxLengthOfNotes = int.Parse(tbMaxLengthOfNotes.Text);

            if (selectedUser is PremiumUser)
            {
                ((PremiumUser)selectedUser).DaysOfPremiumLeft = int.Parse(tbPremiumDaysLeft.Text);
                userManager.UpdateUser(selectedUser.Id, selectedUser.Name, selectedUser.Email, ((User)selectedUser).MaxAmountOfNotes, ((User)selectedUser).MaxLengthOfNotes, ((PremiumUser)selectedUser).DaysOfPremiumLeft);
            }
            else
            {
                userManager.UpdateUser(selectedUser.Id, selectedUser.Name, selectedUser.Email, ((User)selectedUser).MaxAmountOfNotes, ((User)selectedUser).MaxLengthOfNotes);
            }
            ResetListBoxUsersList(lbUsersList.SelectedIndex);
        }

        private void ResetListBoxUsersList(int selectedIndex = -1)
        {
            lbUsersList.SelectedIndexChanged -= lbUsersList_SelectedIndexChanged;
            lbUsersList.DataSource = null;
            lbUsersList.DataSource = users;
            lbUsersList.SelectedIndex = selectedIndex;
            lbUsersList.SelectedIndexChanged += lbUsersList_SelectedIndexChanged;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            userManager.DeleteUser(selectedUser.Id);
            users.Remove(selectedUser);
            DisableAccountManageGroup();
            DisableNotesManageGroup();
            ResetListBoxUsersList();
        }

        private void btUpdateNote_Click(object sender, EventArgs e)
        {
            selectedNote.Title = tbNoteTitle.Text;
            selectedNote.Text = tbNoteText.Text;
            noteManager.UpdateNote(selectedNote.Id, selectedNote.UserId, selectedNote.Title, selectedNote.Text);
            ResetListBoxNotesList(lbNotesList.SelectedIndex);
        }
        private void ResetListBoxNotesList(int selectedIndex = -1)
        {
            lbNotesList.SelectedIndexChanged -= lbNotesList_SelectedIndexChanged;
            lbNotesList.DataSource = null;
            lbNotesList.DataSource = notes;
            lbNotesList.SelectedIndex = selectedIndex;
            lbNotesList.SelectedIndexChanged += lbNotesList_SelectedIndexChanged;
        }
    }
}