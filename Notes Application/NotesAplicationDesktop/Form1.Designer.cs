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
            this.lbPremiumEndDate = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.tbPremiumEndDate = new System.Windows.Forms.TextBox();
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
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1078, 790);
            this.tabControl1.TabIndex = 0;
            // 
            // UserPage
            // 
            this.UserPage.Controls.Add(this.gbNotesManage);
            this.UserPage.Controls.Add(this.gbAccountManage);
            this.UserPage.Controls.Add(this.gbAccountSearch);
            this.UserPage.Location = new System.Drawing.Point(4, 29);
            this.UserPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UserPage.Name = "UserPage";
            this.UserPage.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UserPage.Size = new System.Drawing.Size(1070, 757);
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
            this.gbNotesManage.Location = new System.Drawing.Point(650, 6);
            this.gbNotesManage.Margin = new System.Windows.Forms.Padding(2);
            this.gbNotesManage.Name = "gbNotesManage";
            this.gbNotesManage.Padding = new System.Windows.Forms.Padding(2);
            this.gbNotesManage.Size = new System.Drawing.Size(410, 744);
            this.gbNotesManage.TabIndex = 14;
            this.gbNotesManage.TabStop = false;
            this.gbNotesManage.Text = "Manage Notes";
            // 
            // tbNoteTitle
            // 
            this.tbNoteTitle.Location = new System.Drawing.Point(5, 272);
            this.tbNoteTitle.Margin = new System.Windows.Forms.Padding(2);
            this.tbNoteTitle.Name = "tbNoteTitle";
            this.tbNoteTitle.Size = new System.Drawing.Size(402, 27);
            this.tbNoteTitle.TabIndex = 17;
            // 
            // btUpdateNote
            // 
            this.btUpdateNote.Location = new System.Drawing.Point(5, 648);
            this.btUpdateNote.Margin = new System.Windows.Forms.Padding(2);
            this.btUpdateNote.Name = "btUpdateNote";
            this.btUpdateNote.Size = new System.Drawing.Size(401, 27);
            this.btUpdateNote.TabIndex = 16;
            this.btUpdateNote.Text = "Update Note";
            this.btUpdateNote.UseVisualStyleBackColor = true;
            // 
            // btDeleteNote
            // 
            this.btDeleteNote.Location = new System.Drawing.Point(5, 680);
            this.btDeleteNote.Margin = new System.Windows.Forms.Padding(2);
            this.btDeleteNote.Name = "btDeleteNote";
            this.btDeleteNote.Size = new System.Drawing.Size(401, 27);
            this.btDeleteNote.TabIndex = 15;
            this.btDeleteNote.Text = "Delete Note";
            this.btDeleteNote.UseVisualStyleBackColor = true;
            // 
            // tbNotesText
            // 
            this.tbNotesText.Location = new System.Drawing.Point(5, 302);
            this.tbNotesText.Margin = new System.Windows.Forms.Padding(2);
            this.tbNotesText.Multiline = true;
            this.tbNotesText.Name = "tbNotesText";
            this.tbNotesText.Size = new System.Drawing.Size(402, 342);
            this.tbNotesText.TabIndex = 1;
            // 
            // lbNotesList
            // 
            this.lbNotesList.FormattingEnabled = true;
            this.lbNotesList.ItemHeight = 20;
            this.lbNotesList.Location = new System.Drawing.Point(5, 23);
            this.lbNotesList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbNotesList.Name = "lbNotesList";
            this.lbNotesList.Size = new System.Drawing.Size(402, 244);
            this.lbNotesList.TabIndex = 0;
            this.lbNotesList.SelectedIndexChanged += new System.EventHandler(this.lbNotesList_SelectedIndexChanged);
            // 
            // gbAccountManage
            // 
            this.gbAccountManage.Controls.Add(this.btUpdateUser);
            this.gbAccountManage.Controls.Add(this.lbPremiumEndDate);
            this.gbAccountManage.Controls.Add(this.btnDeleteUser);
            this.gbAccountManage.Controls.Add(this.tbPremiumEndDate);
            this.gbAccountManage.Controls.Add(this.lbMaxLengthOfNotes);
            this.gbAccountManage.Controls.Add(this.tbMaxLengthOfNotes);
            this.gbAccountManage.Controls.Add(this.lbMaxAmountOfNotesManage);
            this.gbAccountManage.Controls.Add(this.tbMaxAmountOfNotes);
            this.gbAccountManage.Controls.Add(this.lbUserEmailManage);
            this.gbAccountManage.Controls.Add(this.lbUserNameManage);
            this.gbAccountManage.Controls.Add(this.tbUserEmailManage);
            this.gbAccountManage.Controls.Add(this.tbUserNameManage);
            this.gbAccountManage.Enabled = false;
            this.gbAccountManage.Location = new System.Drawing.Point(294, 6);
            this.gbAccountManage.Margin = new System.Windows.Forms.Padding(2);
            this.gbAccountManage.Name = "gbAccountManage";
            this.gbAccountManage.Padding = new System.Windows.Forms.Padding(2);
            this.gbAccountManage.Size = new System.Drawing.Size(351, 744);
            this.gbAccountManage.TabIndex = 13;
            this.gbAccountManage.TabStop = false;
            this.gbAccountManage.Text = "Manage Account";
            // 
            // btUpdateUser
            // 
            this.btUpdateUser.Location = new System.Drawing.Point(5, 190);
            this.btUpdateUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btUpdateUser.Name = "btUpdateUser";
            this.btUpdateUser.Size = new System.Drawing.Size(339, 30);
            this.btUpdateUser.TabIndex = 26;
            this.btUpdateUser.Text = "Update User";
            this.btUpdateUser.UseVisualStyleBackColor = true;
            // 
            // lbPremiumEndDate
            // 
            this.lbPremiumEndDate.AutoSize = true;
            this.lbPremiumEndDate.Location = new System.Drawing.Point(5, 160);
            this.lbPremiumEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPremiumEndDate.Name = "lbPremiumEndDate";
            this.lbPremiumEndDate.Size = new System.Drawing.Size(136, 20);
            this.lbPremiumEndDate.TabIndex = 24;
            this.lbPremiumEndDate.Text = "Premium End Date:";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(5, 226);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(339, 30);
            this.btnDeleteUser.TabIndex = 11;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // tbPremiumEndDate
            // 
            this.tbPremiumEndDate.Enabled = false;
            this.tbPremiumEndDate.Location = new System.Drawing.Point(170, 158);
            this.tbPremiumEndDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPremiumEndDate.Name = "tbPremiumEndDate";
            this.tbPremiumEndDate.Size = new System.Drawing.Size(174, 27);
            this.tbPremiumEndDate.TabIndex = 25;
            // 
            // lbMaxLengthOfNotes
            // 
            this.lbMaxLengthOfNotes.AutoSize = true;
            this.lbMaxLengthOfNotes.Location = new System.Drawing.Point(5, 129);
            this.lbMaxLengthOfNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaxLengthOfNotes.Name = "lbMaxLengthOfNotes";
            this.lbMaxLengthOfNotes.Size = new System.Drawing.Size(152, 20);
            this.lbMaxLengthOfNotes.TabIndex = 22;
            this.lbMaxLengthOfNotes.Text = "Max Length Of Notes:";
            // 
            // tbMaxLengthOfNotes
            // 
            this.tbMaxLengthOfNotes.Location = new System.Drawing.Point(170, 127);
            this.tbMaxLengthOfNotes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbMaxLengthOfNotes.Name = "tbMaxLengthOfNotes";
            this.tbMaxLengthOfNotes.Size = new System.Drawing.Size(174, 27);
            this.tbMaxLengthOfNotes.TabIndex = 23;
            // 
            // lbMaxAmountOfNotesManage
            // 
            this.lbMaxAmountOfNotesManage.AutoSize = true;
            this.lbMaxAmountOfNotesManage.Location = new System.Drawing.Point(5, 98);
            this.lbMaxAmountOfNotesManage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaxAmountOfNotesManage.Name = "lbMaxAmountOfNotesManage";
            this.lbMaxAmountOfNotesManage.Size = new System.Drawing.Size(160, 20);
            this.lbMaxAmountOfNotesManage.TabIndex = 20;
            this.lbMaxAmountOfNotesManage.Text = "Max Amount Of Notes:";
            // 
            // tbMaxAmountOfNotes
            // 
            this.tbMaxAmountOfNotes.Location = new System.Drawing.Point(170, 96);
            this.tbMaxAmountOfNotes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbMaxAmountOfNotes.Name = "tbMaxAmountOfNotes";
            this.tbMaxAmountOfNotes.Size = new System.Drawing.Size(174, 27);
            this.tbMaxAmountOfNotes.TabIndex = 21;
            // 
            // lbUserEmailManage
            // 
            this.lbUserEmailManage.AutoSize = true;
            this.lbUserEmailManage.Location = new System.Drawing.Point(5, 67);
            this.lbUserEmailManage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserEmailManage.Name = "lbUserEmailManage";
            this.lbUserEmailManage.Size = new System.Drawing.Size(55, 20);
            this.lbUserEmailManage.TabIndex = 18;
            this.lbUserEmailManage.Text = "E-mail:";
            // 
            // lbUserNameManage
            // 
            this.lbUserNameManage.AutoSize = true;
            this.lbUserNameManage.Location = new System.Drawing.Point(5, 35);
            this.lbUserNameManage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserNameManage.Name = "lbUserNameManage";
            this.lbUserNameManage.Size = new System.Drawing.Size(52, 20);
            this.lbUserNameManage.TabIndex = 16;
            this.lbUserNameManage.Text = "Name:";
            // 
            // tbUserEmailManage
            // 
            this.tbUserEmailManage.Location = new System.Drawing.Point(170, 66);
            this.tbUserEmailManage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbUserEmailManage.Name = "tbUserEmailManage";
            this.tbUserEmailManage.Size = new System.Drawing.Size(174, 27);
            this.tbUserEmailManage.TabIndex = 19;
            // 
            // tbUserNameManage
            // 
            this.tbUserNameManage.Location = new System.Drawing.Point(170, 34);
            this.tbUserNameManage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbUserNameManage.Name = "tbUserNameManage";
            this.tbUserNameManage.Size = new System.Drawing.Size(174, 27);
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
            this.gbAccountSearch.Location = new System.Drawing.Point(6, 6);
            this.gbAccountSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbAccountSearch.Name = "gbAccountSearch";
            this.gbAccountSearch.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbAccountSearch.Size = new System.Drawing.Size(283, 744);
            this.gbAccountSearch.TabIndex = 12;
            this.gbAccountSearch.TabStop = false;
            this.gbAccountSearch.Text = "Search Account";
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(93, 33);
            this.tbUserId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(174, 27);
            this.tbUserId.TabIndex = 14;
            // 
            // lbUsersList
            // 
            this.lbUsersList.FormattingEnabled = true;
            this.lbUsersList.ItemHeight = 20;
            this.lbUsersList.Location = new System.Drawing.Point(18, 163);
            this.lbUsersList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbUsersList.Name = "lbUsersList";
            this.lbUsersList.Size = new System.Drawing.Size(250, 304);
            this.lbUsersList.TabIndex = 1;
            this.lbUsersList.SelectedIndexChanged += new System.EventHandler(this.lbUsersList_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(18, 127);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(249, 30);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbUserId
            // 
            this.lbUserId.AutoSize = true;
            this.lbUserId.Location = new System.Drawing.Point(14, 35);
            this.lbUserId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserId.Name = "lbUserId";
            this.lbUserId.Size = new System.Drawing.Size(25, 20);
            this.lbUserId.TabIndex = 2;
            this.lbUserId.Text = "Id:";
            // 
            // lbUserNameSearch
            // 
            this.lbUserNameSearch.AutoSize = true;
            this.lbUserNameSearch.Location = new System.Drawing.Point(14, 67);
            this.lbUserNameSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserNameSearch.Name = "lbUserNameSearch";
            this.lbUserNameSearch.Size = new System.Drawing.Size(52, 20);
            this.lbUserNameSearch.TabIndex = 4;
            this.lbUserNameSearch.Text = "Name:";
            // 
            // tbUserNameSearch
            // 
            this.tbUserNameSearch.Location = new System.Drawing.Point(93, 64);
            this.tbUserNameSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbUserNameSearch.Name = "tbUserNameSearch";
            this.tbUserNameSearch.Size = new System.Drawing.Size(174, 27);
            this.tbUserNameSearch.TabIndex = 5;
            // 
            // tbUserEmailSearch
            // 
            this.tbUserEmailSearch.Location = new System.Drawing.Point(93, 96);
            this.tbUserEmailSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbUserEmailSearch.Name = "tbUserEmailSearch";
            this.tbUserEmailSearch.Size = new System.Drawing.Size(174, 27);
            this.tbUserEmailSearch.TabIndex = 7;
            // 
            // lbUserEmailSearch
            // 
            this.lbUserEmailSearch.AutoSize = true;
            this.lbUserEmailSearch.Location = new System.Drawing.Point(14, 99);
            this.lbUserEmailSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserEmailSearch.Name = "lbUserEmailSearch";
            this.lbUserEmailSearch.Size = new System.Drawing.Size(55, 20);
            this.lbUserEmailSearch.TabIndex = 6;
            this.lbUserEmailSearch.Text = "E-mail:";
            // 
            // AdminPage
            // 
            this.AdminPage.Location = new System.Drawing.Point(4, 29);
            this.AdminPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AdminPage.Name = "AdminPage";
            this.AdminPage.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AdminPage.Size = new System.Drawing.Size(1070, 757);
            this.AdminPage.TabIndex = 1;
            this.AdminPage.Text = "Admins";
            this.AdminPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 807);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
        private Label lbPremiumEndDate;
        private TextBox tbPremiumEndDate;
        private Button btUpdateUser;
        private GroupBox gbNotesManage;
        private Button btUpdateNote;
        private Button btDeleteNote;
        private TextBox tbNotesText;
        private TextBox tbNoteTitle;
    }
}

