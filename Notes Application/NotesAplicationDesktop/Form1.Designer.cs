namespace NotesAplicationDesktop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UserPage = new System.Windows.Forms.TabPage();
            this.gbNotesManage = new System.Windows.Forms.GroupBox();
            this.tbNoteTitle = new System.Windows.Forms.TextBox();
            this.btUpdateNote = new System.Windows.Forms.Button();
            this.btDeleteNote = new System.Windows.Forms.Button();
            this.tbNotesText = new System.Windows.Forms.TextBox();
            this.lbNotesList = new System.Windows.Forms.ListBox();
            this.gbAccountManage = new System.Windows.Forms.GroupBox();
            this.btUpdateUser = new System.Windows.Forms.Button();
            this.lbPremiumDaysLeft = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.tbPremiumDaysLeft = new System.Windows.Forms.TextBox();
            this.lbMaxLengthOfNotes = new System.Windows.Forms.Label();
            this.tbMaxLengthOfNotes = new System.Windows.Forms.TextBox();
            this.lbMaxAmountOfNotesManage = new System.Windows.Forms.Label();
            this.tbMaxAmountOfNotes = new System.Windows.Forms.TextBox();
            this.lbUserEmailManage = new System.Windows.Forms.Label();
            this.lbUserNameManage = new System.Windows.Forms.Label();
            this.tbUserEmailManage = new System.Windows.Forms.TextBox();
            this.tbUserNameManage = new System.Windows.Forms.TextBox();
            this.gbAccountSearch = new System.Windows.Forms.GroupBox();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.lbUsersList = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbUserId = new System.Windows.Forms.Label();
            this.lbUserNameSearch = new System.Windows.Forms.Label();
            this.tbUserNameSearch = new System.Windows.Forms.TextBox();
            this.tbUserEmailSearch = new System.Windows.Forms.TextBox();
            this.lbUserEmailSearch = new System.Windows.Forms.Label();
            this.AdminPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.UserPage.SuspendLayout();
            this.gbNotesManage.SuspendLayout();
            this.gbAccountManage.SuspendLayout();
            this.gbAccountSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UserPage);
            this.tabControl1.Controls.Add(this.AdminPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1348, 988);
            this.tabControl1.TabIndex = 0;
            // 
            // UserPage
            // 
            this.UserPage.Controls.Add(this.gbNotesManage);
            this.UserPage.Controls.Add(this.gbAccountManage);
            this.UserPage.Controls.Add(this.gbAccountSearch);
            this.UserPage.Location = new System.Drawing.Point(4, 34);
            this.UserPage.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.UserPage.Name = "UserPage";
            this.UserPage.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.UserPage.Size = new System.Drawing.Size(1340, 950);
            this.UserPage.TabIndex = 0;
            this.UserPage.Text = "Users";
            this.UserPage.UseVisualStyleBackColor = true;
            // 
            // gbNotesManage
            // 
            this.gbNotesManage.Controls.Add(this.tbNoteTitle);
            this.gbNotesManage.Controls.Add(this.btUpdateNote);
            this.gbNotesManage.Controls.Add(this.btDeleteNote);
            this.gbNotesManage.Controls.Add(this.tbNotesText);
            this.gbNotesManage.Controls.Add(this.lbNotesList);
            this.gbNotesManage.Enabled = false;
            this.gbNotesManage.Location = new System.Drawing.Point(812, 8);
            this.gbNotesManage.Margin = new System.Windows.Forms.Padding(2);
            this.gbNotesManage.Name = "gbNotesManage";
            this.gbNotesManage.Padding = new System.Windows.Forms.Padding(2);
            this.gbNotesManage.Size = new System.Drawing.Size(512, 930);
            this.gbNotesManage.TabIndex = 14;
            this.gbNotesManage.TabStop = false;
            this.gbNotesManage.Text = "Manage Notes";
            // 
            // tbNoteTitle
            // 
            this.tbNoteTitle.Location = new System.Drawing.Point(6, 340);
            this.tbNoteTitle.Margin = new System.Windows.Forms.Padding(2);
            this.tbNoteTitle.Name = "tbNoteTitle";
            this.tbNoteTitle.Size = new System.Drawing.Size(502, 31);
            this.tbNoteTitle.TabIndex = 17;
            // 
            // btUpdateNote
            // 
            this.btUpdateNote.Location = new System.Drawing.Point(6, 810);
            this.btUpdateNote.Margin = new System.Windows.Forms.Padding(2);
            this.btUpdateNote.Name = "btUpdateNote";
            this.btUpdateNote.Size = new System.Drawing.Size(501, 34);
            this.btUpdateNote.TabIndex = 16;
            this.btUpdateNote.Text = "Update Note";
            this.btUpdateNote.UseVisualStyleBackColor = true;
            // 
            // btDeleteNote
            // 
            this.btDeleteNote.Location = new System.Drawing.Point(6, 850);
            this.btDeleteNote.Margin = new System.Windows.Forms.Padding(2);
            this.btDeleteNote.Name = "btDeleteNote";
            this.btDeleteNote.Size = new System.Drawing.Size(501, 34);
            this.btDeleteNote.TabIndex = 15;
            this.btDeleteNote.Text = "Delete Note";
            this.btDeleteNote.UseVisualStyleBackColor = true;
            // 
            // tbNotesText
            // 
            this.tbNotesText.Location = new System.Drawing.Point(6, 378);
            this.tbNotesText.Margin = new System.Windows.Forms.Padding(2);
            this.tbNotesText.Multiline = true;
            this.tbNotesText.Name = "tbNotesText";
            this.tbNotesText.Size = new System.Drawing.Size(502, 426);
            this.tbNotesText.TabIndex = 1;
            // 
            // lbNotesList
            // 
            this.lbNotesList.FormattingEnabled = true;
            this.lbNotesList.ItemHeight = 25;
            this.lbNotesList.Location = new System.Drawing.Point(6, 29);
            this.lbNotesList.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.lbNotesList.Name = "lbNotesList";
            this.lbNotesList.Size = new System.Drawing.Size(502, 304);
            this.lbNotesList.TabIndex = 0;
            this.lbNotesList.SelectedIndexChanged += new System.EventHandler(this.lbNotesList_SelectedIndexChanged);
            // 
            // gbAccountManage
            // 
            this.gbAccountManage.Controls.Add(this.btUpdateUser);
            this.gbAccountManage.Controls.Add(this.lbPremiumDaysLeft);
            this.gbAccountManage.Controls.Add(this.btnDeleteUser);
            this.gbAccountManage.Controls.Add(this.tbPremiumDaysLeft);
            this.gbAccountManage.Controls.Add(this.lbMaxLengthOfNotes);
            this.gbAccountManage.Controls.Add(this.tbMaxLengthOfNotes);
            this.gbAccountManage.Controls.Add(this.lbMaxAmountOfNotesManage);
            this.gbAccountManage.Controls.Add(this.tbMaxAmountOfNotes);
            this.gbAccountManage.Controls.Add(this.lbUserEmailManage);
            this.gbAccountManage.Controls.Add(this.lbUserNameManage);
            this.gbAccountManage.Controls.Add(this.tbUserEmailManage);
            this.gbAccountManage.Controls.Add(this.tbUserNameManage);
            this.gbAccountManage.Enabled = false;
            this.gbAccountManage.Location = new System.Drawing.Point(368, 8);
            this.gbAccountManage.Margin = new System.Windows.Forms.Padding(2);
            this.gbAccountManage.Name = "gbAccountManage";
            this.gbAccountManage.Padding = new System.Windows.Forms.Padding(2);
            this.gbAccountManage.Size = new System.Drawing.Size(439, 930);
            this.gbAccountManage.TabIndex = 13;
            this.gbAccountManage.TabStop = false;
            this.gbAccountManage.Text = "Manage Account";
            // 
            // btUpdateUser
            // 
            this.btUpdateUser.Location = new System.Drawing.Point(6, 238);
            this.btUpdateUser.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btUpdateUser.Name = "btUpdateUser";
            this.btUpdateUser.Size = new System.Drawing.Size(424, 38);
            this.btUpdateUser.TabIndex = 26;
            this.btUpdateUser.Text = "Update User";
            this.btUpdateUser.UseVisualStyleBackColor = true;
            this.btUpdateUser.Click += new System.EventHandler(this.btUpdateUser_Click);
            // 
            // lbPremiumDaysLeft
            // 
            this.lbPremiumDaysLeft.AutoSize = true;
            this.lbPremiumDaysLeft.Location = new System.Drawing.Point(6, 200);
            this.lbPremiumDaysLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPremiumDaysLeft.Name = "lbPremiumDaysLeft";
            this.lbPremiumDaysLeft.Size = new System.Drawing.Size(165, 25);
            this.lbPremiumDaysLeft.TabIndex = 24;
            this.lbPremiumDaysLeft.Text = "Premium Days Left:";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(6, 282);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(424, 38);
            this.btnDeleteUser.TabIndex = 11;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // tbPremiumDaysLeft
            // 
            this.tbPremiumDaysLeft.Enabled = false;
            this.tbPremiumDaysLeft.Location = new System.Drawing.Point(212, 198);
            this.tbPremiumDaysLeft.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbPremiumDaysLeft.Name = "tbPremiumDaysLeft";
            this.tbPremiumDaysLeft.Size = new System.Drawing.Size(216, 31);
            this.tbPremiumDaysLeft.TabIndex = 25;
            // 
            // lbMaxLengthOfNotes
            // 
            this.lbMaxLengthOfNotes.AutoSize = true;
            this.lbMaxLengthOfNotes.Location = new System.Drawing.Point(6, 161);
            this.lbMaxLengthOfNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaxLengthOfNotes.Name = "lbMaxLengthOfNotes";
            this.lbMaxLengthOfNotes.Size = new System.Drawing.Size(185, 25);
            this.lbMaxLengthOfNotes.TabIndex = 22;
            this.lbMaxLengthOfNotes.Text = "Max Length Of Notes:";
            // 
            // tbMaxLengthOfNotes
            // 
            this.tbMaxLengthOfNotes.Location = new System.Drawing.Point(212, 159);
            this.tbMaxLengthOfNotes.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbMaxLengthOfNotes.Name = "tbMaxLengthOfNotes";
            this.tbMaxLengthOfNotes.Size = new System.Drawing.Size(216, 31);
            this.tbMaxLengthOfNotes.TabIndex = 23;
            // 
            // lbMaxAmountOfNotesManage
            // 
            this.lbMaxAmountOfNotesManage.AutoSize = true;
            this.lbMaxAmountOfNotesManage.Location = new System.Drawing.Point(6, 122);
            this.lbMaxAmountOfNotesManage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaxAmountOfNotesManage.Name = "lbMaxAmountOfNotesManage";
            this.lbMaxAmountOfNotesManage.Size = new System.Drawing.Size(196, 25);
            this.lbMaxAmountOfNotesManage.TabIndex = 20;
            this.lbMaxAmountOfNotesManage.Text = "Max Amount Of Notes:";
            // 
            // tbMaxAmountOfNotes
            // 
            this.tbMaxAmountOfNotes.Location = new System.Drawing.Point(212, 120);
            this.tbMaxAmountOfNotes.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbMaxAmountOfNotes.Name = "tbMaxAmountOfNotes";
            this.tbMaxAmountOfNotes.Size = new System.Drawing.Size(216, 31);
            this.tbMaxAmountOfNotes.TabIndex = 21;
            // 
            // lbUserEmailManage
            // 
            this.lbUserEmailManage.AutoSize = true;
            this.lbUserEmailManage.Location = new System.Drawing.Point(6, 84);
            this.lbUserEmailManage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserEmailManage.Name = "lbUserEmailManage";
            this.lbUserEmailManage.Size = new System.Drawing.Size(65, 25);
            this.lbUserEmailManage.TabIndex = 18;
            this.lbUserEmailManage.Text = "E-mail:";
            // 
            // lbUserNameManage
            // 
            this.lbUserNameManage.AutoSize = true;
            this.lbUserNameManage.Location = new System.Drawing.Point(6, 44);
            this.lbUserNameManage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserNameManage.Name = "lbUserNameManage";
            this.lbUserNameManage.Size = new System.Drawing.Size(63, 25);
            this.lbUserNameManage.TabIndex = 16;
            this.lbUserNameManage.Text = "Name:";
            // 
            // tbUserEmailManage
            // 
            this.tbUserEmailManage.Location = new System.Drawing.Point(212, 82);
            this.tbUserEmailManage.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbUserEmailManage.Name = "tbUserEmailManage";
            this.tbUserEmailManage.Size = new System.Drawing.Size(216, 31);
            this.tbUserEmailManage.TabIndex = 19;
            // 
            // tbUserNameManage
            // 
            this.tbUserNameManage.Location = new System.Drawing.Point(212, 42);
            this.tbUserNameManage.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbUserNameManage.Name = "tbUserNameManage";
            this.tbUserNameManage.Size = new System.Drawing.Size(216, 31);
            this.tbUserNameManage.TabIndex = 17;
            // 
            // gbAccountSearch
            // 
            this.gbAccountSearch.Controls.Add(this.tbUserId);
            this.gbAccountSearch.Controls.Add(this.lbUsersList);
            this.gbAccountSearch.Controls.Add(this.btnSearch);
            this.gbAccountSearch.Controls.Add(this.lbUserId);
            this.gbAccountSearch.Controls.Add(this.lbUserNameSearch);
            this.gbAccountSearch.Controls.Add(this.tbUserNameSearch);
            this.gbAccountSearch.Controls.Add(this.tbUserEmailSearch);
            this.gbAccountSearch.Controls.Add(this.lbUserEmailSearch);
            this.gbAccountSearch.Location = new System.Drawing.Point(8, 8);
            this.gbAccountSearch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbAccountSearch.Name = "gbAccountSearch";
            this.gbAccountSearch.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbAccountSearch.Size = new System.Drawing.Size(354, 930);
            this.gbAccountSearch.TabIndex = 12;
            this.gbAccountSearch.TabStop = false;
            this.gbAccountSearch.Text = "Search Account";
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(116, 41);
            this.tbUserId.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(216, 31);
            this.tbUserId.TabIndex = 14;
            // 
            // lbUsersList
            // 
            this.lbUsersList.FormattingEnabled = true;
            this.lbUsersList.ItemHeight = 25;
            this.lbUsersList.Location = new System.Drawing.Point(22, 204);
            this.lbUsersList.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.lbUsersList.Name = "lbUsersList";
            this.lbUsersList.Size = new System.Drawing.Size(312, 379);
            this.lbUsersList.TabIndex = 1;
            this.lbUsersList.SelectedIndexChanged += new System.EventHandler(this.lbUsersList_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(22, 159);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(311, 38);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbUserId
            // 
            this.lbUserId.AutoSize = true;
            this.lbUserId.Location = new System.Drawing.Point(18, 44);
            this.lbUserId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserId.Name = "lbUserId";
            this.lbUserId.Size = new System.Drawing.Size(32, 25);
            this.lbUserId.TabIndex = 2;
            this.lbUserId.Text = "Id:";
            // 
            // lbUserNameSearch
            // 
            this.lbUserNameSearch.AutoSize = true;
            this.lbUserNameSearch.Location = new System.Drawing.Point(18, 84);
            this.lbUserNameSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserNameSearch.Name = "lbUserNameSearch";
            this.lbUserNameSearch.Size = new System.Drawing.Size(63, 25);
            this.lbUserNameSearch.TabIndex = 4;
            this.lbUserNameSearch.Text = "Name:";
            // 
            // tbUserNameSearch
            // 
            this.tbUserNameSearch.Location = new System.Drawing.Point(116, 80);
            this.tbUserNameSearch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbUserNameSearch.Name = "tbUserNameSearch";
            this.tbUserNameSearch.Size = new System.Drawing.Size(216, 31);
            this.tbUserNameSearch.TabIndex = 5;
            // 
            // tbUserEmailSearch
            // 
            this.tbUserEmailSearch.Location = new System.Drawing.Point(116, 120);
            this.tbUserEmailSearch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbUserEmailSearch.Name = "tbUserEmailSearch";
            this.tbUserEmailSearch.Size = new System.Drawing.Size(216, 31);
            this.tbUserEmailSearch.TabIndex = 7;
            // 
            // lbUserEmailSearch
            // 
            this.lbUserEmailSearch.AutoSize = true;
            this.lbUserEmailSearch.Location = new System.Drawing.Point(18, 124);
            this.lbUserEmailSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserEmailSearch.Name = "lbUserEmailSearch";
            this.lbUserEmailSearch.Size = new System.Drawing.Size(65, 25);
            this.lbUserEmailSearch.TabIndex = 6;
            this.lbUserEmailSearch.Text = "E-mail:";
            // 
            // AdminPage
            // 
            this.AdminPage.Location = new System.Drawing.Point(4, 34);
            this.AdminPage.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.AdminPage.Name = "AdminPage";
            this.AdminPage.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.AdminPage.Size = new System.Drawing.Size(1340, 950);
            this.AdminPage.TabIndex = 1;
            this.AdminPage.Text = "Admins";
            this.AdminPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 1009);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.UserPage.ResumeLayout(false);
            this.gbNotesManage.ResumeLayout(false);
            this.gbNotesManage.PerformLayout();
            this.gbAccountManage.ResumeLayout(false);
            this.gbAccountManage.PerformLayout();
            this.gbAccountSearch.ResumeLayout(false);
            this.gbAccountSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UserPage;
        private System.Windows.Forms.TabPage AdminPage;
        private System.Windows.Forms.TextBox tbUserNameSearch;
        private System.Windows.Forms.Label lbUserNameSearch;
        private System.Windows.Forms.Label lbUserId;
        private System.Windows.Forms.ListBox lbUsersList;
        private System.Windows.Forms.ListBox lbNotesList;
        private System.Windows.Forms.TextBox tbUserEmailSearch;
        private System.Windows.Forms.Label lbUserEmailSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.GroupBox gbAccountSearch;
        private TextBox tbUserId;
        private GroupBox gbAccountManage;
        private Label lbUserEmailManage;
        private Label lbUserNameManage;
        private TextBox tbUserEmailManage;
        private TextBox tbUserNameManage;
        private Label lbMaxLengthOfNotes;
        private TextBox tbMaxLengthOfNotes;
        private Label lbMaxAmountOfNotesManage;
        private TextBox tbMaxAmountOfNotes;
        private Label lbPremiumDaysLeft;
        private TextBox tbPremiumDaysLeft;
        private Button btUpdateUser;
        private GroupBox gbNotesManage;
        private Button btUpdateNote;
        private Button btDeleteNote;
        private TextBox tbNotesText;
        private TextBox tbNoteTitle;
    }
}

