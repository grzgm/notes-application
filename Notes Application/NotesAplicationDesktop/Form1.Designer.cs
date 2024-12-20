﻿namespace NotesAplicationDesktop
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
            this.tbNoteText = new System.Windows.Forms.TextBox();
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
            this.gbAdminCreator = new System.Windows.Forms.GroupBox();
            this.lbAdminRoleCreator = new System.Windows.Forms.Label();
            this.tbAdminRoleCreator = new System.Windows.Forms.TextBox();
            this.btAddAdmin = new System.Windows.Forms.Button();
            this.lbAdminPasswordCreator = new System.Windows.Forms.Label();
            this.tbAdminPasswordCreator = new System.Windows.Forms.TextBox();
            this.lbAdminEmailCreator = new System.Windows.Forms.Label();
            this.lbAdminNameCreator = new System.Windows.Forms.Label();
            this.tbAdminEmailCreator = new System.Windows.Forms.TextBox();
            this.tbAdminNameCreator = new System.Windows.Forms.TextBox();
            this.gbAdminDetails = new System.Windows.Forms.GroupBox();
            this.btUpdateAdmin = new System.Windows.Forms.Button();
            this.btDelteteAdmin = new System.Windows.Forms.Button();
            this.lbAdminRoleDetails = new System.Windows.Forms.Label();
            this.tbAdminRoleDetails = new System.Windows.Forms.TextBox();
            this.lbAdminEmailDetails = new System.Windows.Forms.Label();
            this.lbAdminNameDetails = new System.Windows.Forms.Label();
            this.tbAdminEmailDetails = new System.Windows.Forms.TextBox();
            this.tbAdminNameDetails = new System.Windows.Forms.TextBox();
            this.gbSearchAdmin = new System.Windows.Forms.GroupBox();
            this.lbAdminRoleSearch = new System.Windows.Forms.Label();
            this.tbAdminId = new System.Windows.Forms.TextBox();
            this.tbAdminRoleSearch = new System.Windows.Forms.TextBox();
            this.lbAdminList = new System.Windows.Forms.ListBox();
            this.btAdminSearch = new System.Windows.Forms.Button();
            this.lbAdminId = new System.Windows.Forms.Label();
            this.lbAdminNameSearch = new System.Windows.Forms.Label();
            this.tbAdminNameSearch = new System.Windows.Forms.TextBox();
            this.tbAdminEmailSearch = new System.Windows.Forms.TextBox();
            this.lbAdminEmailSearch = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.UserPage.SuspendLayout();
            this.gbNotesManage.SuspendLayout();
            this.gbAccountManage.SuspendLayout();
            this.gbAccountSearch.SuspendLayout();
            this.AdminPage.SuspendLayout();
            this.gbAdminCreator.SuspendLayout();
            this.gbAdminDetails.SuspendLayout();
            this.gbSearchAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UserPage);
            this.tabControl1.Controls.Add(this.AdminPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1370, 1009);
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
            this.UserPage.Size = new System.Drawing.Size(1362, 971);
            this.UserPage.TabIndex = 0;
            this.UserPage.Text = "Users";
            this.UserPage.UseVisualStyleBackColor = true;
            // 
            // gbNotesManage
            // 
            this.gbNotesManage.Controls.Add(this.tbNoteTitle);
            this.gbNotesManage.Controls.Add(this.btUpdateNote);
            this.gbNotesManage.Controls.Add(this.btDeleteNote);
            this.gbNotesManage.Controls.Add(this.tbNoteText);
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
            this.btUpdateNote.Click += new System.EventHandler(this.btUpdateNote_Click);
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
            this.btDeleteNote.Click += new System.EventHandler(this.btDeleteNote_Click);
            // 
            // tbNoteText
            // 
            this.tbNoteText.Location = new System.Drawing.Point(6, 378);
            this.tbNoteText.Margin = new System.Windows.Forms.Padding(2);
            this.tbNoteText.Multiline = true;
            this.tbNoteText.Name = "tbNoteText";
            this.tbNoteText.Size = new System.Drawing.Size(502, 426);
            this.tbNoteText.TabIndex = 1;
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
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
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
            this.AdminPage.Controls.Add(this.gbAdminCreator);
            this.AdminPage.Controls.Add(this.gbAdminDetails);
            this.AdminPage.Controls.Add(this.gbSearchAdmin);
            this.AdminPage.Location = new System.Drawing.Point(4, 34);
            this.AdminPage.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.AdminPage.Name = "AdminPage";
            this.AdminPage.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.AdminPage.Size = new System.Drawing.Size(1362, 971);
            this.AdminPage.TabIndex = 1;
            this.AdminPage.Text = "Admins";
            this.AdminPage.UseVisualStyleBackColor = true;
            // 
            // gbAdminCreator
            // 
            this.gbAdminCreator.Controls.Add(this.lbAdminRoleCreator);
            this.gbAdminCreator.Controls.Add(this.tbAdminRoleCreator);
            this.gbAdminCreator.Controls.Add(this.btAddAdmin);
            this.gbAdminCreator.Controls.Add(this.lbAdminPasswordCreator);
            this.gbAdminCreator.Controls.Add(this.tbAdminPasswordCreator);
            this.gbAdminCreator.Controls.Add(this.lbAdminEmailCreator);
            this.gbAdminCreator.Controls.Add(this.lbAdminNameCreator);
            this.gbAdminCreator.Controls.Add(this.tbAdminEmailCreator);
            this.gbAdminCreator.Controls.Add(this.tbAdminNameCreator);
            this.gbAdminCreator.Location = new System.Drawing.Point(807, 8);
            this.gbAdminCreator.Margin = new System.Windows.Forms.Padding(2);
            this.gbAdminCreator.Name = "gbAdminCreator";
            this.gbAdminCreator.Padding = new System.Windows.Forms.Padding(2);
            this.gbAdminCreator.Size = new System.Drawing.Size(439, 930);
            this.gbAdminCreator.TabIndex = 28;
            this.gbAdminCreator.TabStop = false;
            this.gbAdminCreator.Text = "Admin Creator";
            // 
            // lbAdminRoleCreator
            // 
            this.lbAdminRoleCreator.AutoSize = true;
            this.lbAdminRoleCreator.Location = new System.Drawing.Point(4, 159);
            this.lbAdminRoleCreator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAdminRoleCreator.Name = "lbAdminRoleCreator";
            this.lbAdminRoleCreator.Size = new System.Drawing.Size(50, 25);
            this.lbAdminRoleCreator.TabIndex = 28;
            this.lbAdminRoleCreator.Text = "Role:";
            // 
            // tbAdminRoleCreator
            // 
            this.tbAdminRoleCreator.Location = new System.Drawing.Point(212, 159);
            this.tbAdminRoleCreator.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbAdminRoleCreator.Name = "tbAdminRoleCreator";
            this.tbAdminRoleCreator.Size = new System.Drawing.Size(216, 31);
            this.tbAdminRoleCreator.TabIndex = 29;
            // 
            // btAddAdmin
            // 
            this.btAddAdmin.Location = new System.Drawing.Point(4, 198);
            this.btAddAdmin.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btAddAdmin.Name = "btAddAdmin";
            this.btAddAdmin.Size = new System.Drawing.Size(424, 38);
            this.btAddAdmin.TabIndex = 27;
            this.btAddAdmin.Text = "Add Admin";
            this.btAddAdmin.UseVisualStyleBackColor = true;
            this.btAddAdmin.Click += new System.EventHandler(this.btAddAdmin_Click);
            // 
            // lbAdminPasswordCreator
            // 
            this.lbAdminPasswordCreator.AutoSize = true;
            this.lbAdminPasswordCreator.Location = new System.Drawing.Point(4, 120);
            this.lbAdminPasswordCreator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAdminPasswordCreator.Name = "lbAdminPasswordCreator";
            this.lbAdminPasswordCreator.Size = new System.Drawing.Size(91, 25);
            this.lbAdminPasswordCreator.TabIndex = 20;
            this.lbAdminPasswordCreator.Text = "Password:";
            // 
            // tbAdminPasswordCreator
            // 
            this.tbAdminPasswordCreator.Location = new System.Drawing.Point(212, 120);
            this.tbAdminPasswordCreator.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbAdminPasswordCreator.Name = "tbAdminPasswordCreator";
            this.tbAdminPasswordCreator.Size = new System.Drawing.Size(216, 31);
            this.tbAdminPasswordCreator.TabIndex = 21;
            // 
            // lbAdminEmailCreator
            // 
            this.lbAdminEmailCreator.AutoSize = true;
            this.lbAdminEmailCreator.Location = new System.Drawing.Point(4, 82);
            this.lbAdminEmailCreator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAdminEmailCreator.Name = "lbAdminEmailCreator";
            this.lbAdminEmailCreator.Size = new System.Drawing.Size(65, 25);
            this.lbAdminEmailCreator.TabIndex = 18;
            this.lbAdminEmailCreator.Text = "E-mail:";
            // 
            // lbAdminNameCreator
            // 
            this.lbAdminNameCreator.AutoSize = true;
            this.lbAdminNameCreator.Location = new System.Drawing.Point(4, 42);
            this.lbAdminNameCreator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAdminNameCreator.Name = "lbAdminNameCreator";
            this.lbAdminNameCreator.Size = new System.Drawing.Size(63, 25);
            this.lbAdminNameCreator.TabIndex = 16;
            this.lbAdminNameCreator.Text = "Name:";
            // 
            // tbAdminEmailCreator
            // 
            this.tbAdminEmailCreator.Location = new System.Drawing.Point(212, 82);
            this.tbAdminEmailCreator.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbAdminEmailCreator.Name = "tbAdminEmailCreator";
            this.tbAdminEmailCreator.Size = new System.Drawing.Size(216, 31);
            this.tbAdminEmailCreator.TabIndex = 19;
            // 
            // tbAdminNameCreator
            // 
            this.tbAdminNameCreator.Location = new System.Drawing.Point(212, 42);
            this.tbAdminNameCreator.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbAdminNameCreator.Name = "tbAdminNameCreator";
            this.tbAdminNameCreator.Size = new System.Drawing.Size(216, 31);
            this.tbAdminNameCreator.TabIndex = 17;
            // 
            // gbAdminDetails
            // 
            this.gbAdminDetails.Controls.Add(this.btUpdateAdmin);
            this.gbAdminDetails.Controls.Add(this.btDelteteAdmin);
            this.gbAdminDetails.Controls.Add(this.lbAdminRoleDetails);
            this.gbAdminDetails.Controls.Add(this.tbAdminRoleDetails);
            this.gbAdminDetails.Controls.Add(this.lbAdminEmailDetails);
            this.gbAdminDetails.Controls.Add(this.lbAdminNameDetails);
            this.gbAdminDetails.Controls.Add(this.tbAdminEmailDetails);
            this.gbAdminDetails.Controls.Add(this.tbAdminNameDetails);
            this.gbAdminDetails.Enabled = false;
            this.gbAdminDetails.Location = new System.Drawing.Point(364, 8);
            this.gbAdminDetails.Margin = new System.Windows.Forms.Padding(2);
            this.gbAdminDetails.Name = "gbAdminDetails";
            this.gbAdminDetails.Padding = new System.Windows.Forms.Padding(2);
            this.gbAdminDetails.Size = new System.Drawing.Size(439, 930);
            this.gbAdminDetails.TabIndex = 15;
            this.gbAdminDetails.TabStop = false;
            this.gbAdminDetails.Text = "Admin Details";
            // 
            // btUpdateAdmin
            // 
            this.btUpdateAdmin.Location = new System.Drawing.Point(4, 159);
            this.btUpdateAdmin.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btUpdateAdmin.Name = "btUpdateAdmin";
            this.btUpdateAdmin.Size = new System.Drawing.Size(424, 38);
            this.btUpdateAdmin.TabIndex = 26;
            this.btUpdateAdmin.Text = "Update Admin";
            this.btUpdateAdmin.UseVisualStyleBackColor = true;
            this.btUpdateAdmin.Click += new System.EventHandler(this.btUpdateAdmin_Click);
            // 
            // btDelteteAdmin
            // 
            this.btDelteteAdmin.Location = new System.Drawing.Point(4, 203);
            this.btDelteteAdmin.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btDelteteAdmin.Name = "btDelteteAdmin";
            this.btDelteteAdmin.Size = new System.Drawing.Size(424, 38);
            this.btDelteteAdmin.TabIndex = 11;
            this.btDelteteAdmin.Text = "Delete Admin";
            this.btDelteteAdmin.UseVisualStyleBackColor = true;
            this.btDelteteAdmin.Click += new System.EventHandler(this.btDelteteAdmin_Click);
            // 
            // lbAdminRoleDetails
            // 
            this.lbAdminRoleDetails.AutoSize = true;
            this.lbAdminRoleDetails.Location = new System.Drawing.Point(5, 121);
            this.lbAdminRoleDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAdminRoleDetails.Name = "lbAdminRoleDetails";
            this.lbAdminRoleDetails.Size = new System.Drawing.Size(50, 25);
            this.lbAdminRoleDetails.TabIndex = 20;
            this.lbAdminRoleDetails.Text = "Role:";
            // 
            // tbAdminRoleDetails
            // 
            this.tbAdminRoleDetails.Location = new System.Drawing.Point(212, 120);
            this.tbAdminRoleDetails.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbAdminRoleDetails.Name = "tbAdminRoleDetails";
            this.tbAdminRoleDetails.Size = new System.Drawing.Size(216, 31);
            this.tbAdminRoleDetails.TabIndex = 21;
            // 
            // lbAdminEmailDetails
            // 
            this.lbAdminEmailDetails.AutoSize = true;
            this.lbAdminEmailDetails.Location = new System.Drawing.Point(5, 83);
            this.lbAdminEmailDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAdminEmailDetails.Name = "lbAdminEmailDetails";
            this.lbAdminEmailDetails.Size = new System.Drawing.Size(65, 25);
            this.lbAdminEmailDetails.TabIndex = 18;
            this.lbAdminEmailDetails.Text = "E-mail:";
            // 
            // lbAdminNameDetails
            // 
            this.lbAdminNameDetails.AutoSize = true;
            this.lbAdminNameDetails.Location = new System.Drawing.Point(5, 43);
            this.lbAdminNameDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAdminNameDetails.Name = "lbAdminNameDetails";
            this.lbAdminNameDetails.Size = new System.Drawing.Size(63, 25);
            this.lbAdminNameDetails.TabIndex = 16;
            this.lbAdminNameDetails.Text = "Name:";
            // 
            // tbAdminEmailDetails
            // 
            this.tbAdminEmailDetails.Location = new System.Drawing.Point(212, 82);
            this.tbAdminEmailDetails.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbAdminEmailDetails.Name = "tbAdminEmailDetails";
            this.tbAdminEmailDetails.Size = new System.Drawing.Size(216, 31);
            this.tbAdminEmailDetails.TabIndex = 19;
            // 
            // tbAdminNameDetails
            // 
            this.tbAdminNameDetails.Location = new System.Drawing.Point(212, 42);
            this.tbAdminNameDetails.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbAdminNameDetails.Name = "tbAdminNameDetails";
            this.tbAdminNameDetails.Size = new System.Drawing.Size(216, 31);
            this.tbAdminNameDetails.TabIndex = 17;
            // 
            // gbSearchAdmin
            // 
            this.gbSearchAdmin.Controls.Add(this.lbAdminRoleSearch);
            this.gbSearchAdmin.Controls.Add(this.tbAdminId);
            this.gbSearchAdmin.Controls.Add(this.tbAdminRoleSearch);
            this.gbSearchAdmin.Controls.Add(this.lbAdminList);
            this.gbSearchAdmin.Controls.Add(this.btAdminSearch);
            this.gbSearchAdmin.Controls.Add(this.lbAdminId);
            this.gbSearchAdmin.Controls.Add(this.lbAdminNameSearch);
            this.gbSearchAdmin.Controls.Add(this.tbAdminNameSearch);
            this.gbSearchAdmin.Controls.Add(this.tbAdminEmailSearch);
            this.gbSearchAdmin.Controls.Add(this.lbAdminEmailSearch);
            this.gbSearchAdmin.Location = new System.Drawing.Point(4, 8);
            this.gbSearchAdmin.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbSearchAdmin.Name = "gbSearchAdmin";
            this.gbSearchAdmin.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbSearchAdmin.Size = new System.Drawing.Size(354, 930);
            this.gbSearchAdmin.TabIndex = 14;
            this.gbSearchAdmin.TabStop = false;
            this.gbSearchAdmin.Text = "Search Admin";
            // 
            // lbAdminRoleSearch
            // 
            this.lbAdminRoleSearch.AutoSize = true;
            this.lbAdminRoleSearch.Location = new System.Drawing.Point(17, 162);
            this.lbAdminRoleSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAdminRoleSearch.Name = "lbAdminRoleSearch";
            this.lbAdminRoleSearch.Size = new System.Drawing.Size(50, 25);
            this.lbAdminRoleSearch.TabIndex = 27;
            this.lbAdminRoleSearch.Text = "Role:";
            // 
            // tbAdminId
            // 
            this.tbAdminId.Location = new System.Drawing.Point(116, 41);
            this.tbAdminId.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbAdminId.Name = "tbAdminId";
            this.tbAdminId.Size = new System.Drawing.Size(216, 31);
            this.tbAdminId.TabIndex = 14;
            // 
            // tbAdminRoleSearch
            // 
            this.tbAdminRoleSearch.Location = new System.Drawing.Point(116, 159);
            this.tbAdminRoleSearch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbAdminRoleSearch.Name = "tbAdminRoleSearch";
            this.tbAdminRoleSearch.Size = new System.Drawing.Size(216, 31);
            this.tbAdminRoleSearch.TabIndex = 28;
            // 
            // lbAdminList
            // 
            this.lbAdminList.FormattingEnabled = true;
            this.lbAdminList.ItemHeight = 25;
            this.lbAdminList.Location = new System.Drawing.Point(21, 248);
            this.lbAdminList.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.lbAdminList.Name = "lbAdminList";
            this.lbAdminList.Size = new System.Drawing.Size(312, 379);
            this.lbAdminList.TabIndex = 1;
            this.lbAdminList.SelectedIndexChanged += new System.EventHandler(this.lbAdminList_SelectedIndexChanged);
            // 
            // btAdminSearch
            // 
            this.btAdminSearch.Location = new System.Drawing.Point(21, 203);
            this.btAdminSearch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btAdminSearch.Name = "btAdminSearch";
            this.btAdminSearch.Size = new System.Drawing.Size(311, 38);
            this.btAdminSearch.TabIndex = 10;
            this.btAdminSearch.Text = "Search";
            this.btAdminSearch.UseVisualStyleBackColor = true;
            this.btAdminSearch.Click += new System.EventHandler(this.btAdminSearch_Click);
            // 
            // lbAdminId
            // 
            this.lbAdminId.AutoSize = true;
            this.lbAdminId.Location = new System.Drawing.Point(17, 45);
            this.lbAdminId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAdminId.Name = "lbAdminId";
            this.lbAdminId.Size = new System.Drawing.Size(32, 25);
            this.lbAdminId.TabIndex = 2;
            this.lbAdminId.Text = "Id:";
            // 
            // lbAdminNameSearch
            // 
            this.lbAdminNameSearch.AutoSize = true;
            this.lbAdminNameSearch.Location = new System.Drawing.Point(17, 85);
            this.lbAdminNameSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAdminNameSearch.Name = "lbAdminNameSearch";
            this.lbAdminNameSearch.Size = new System.Drawing.Size(63, 25);
            this.lbAdminNameSearch.TabIndex = 4;
            this.lbAdminNameSearch.Text = "Name:";
            // 
            // tbAdminNameSearch
            // 
            this.tbAdminNameSearch.Location = new System.Drawing.Point(116, 80);
            this.tbAdminNameSearch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbAdminNameSearch.Name = "tbAdminNameSearch";
            this.tbAdminNameSearch.Size = new System.Drawing.Size(216, 31);
            this.tbAdminNameSearch.TabIndex = 5;
            // 
            // tbAdminEmailSearch
            // 
            this.tbAdminEmailSearch.Location = new System.Drawing.Point(116, 120);
            this.tbAdminEmailSearch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbAdminEmailSearch.Name = "tbAdminEmailSearch";
            this.tbAdminEmailSearch.Size = new System.Drawing.Size(216, 31);
            this.tbAdminEmailSearch.TabIndex = 7;
            // 
            // lbAdminEmailSearch
            // 
            this.lbAdminEmailSearch.AutoSize = true;
            this.lbAdminEmailSearch.Location = new System.Drawing.Point(17, 125);
            this.lbAdminEmailSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAdminEmailSearch.Name = "lbAdminEmailSearch";
            this.lbAdminEmailSearch.Size = new System.Drawing.Size(65, 25);
            this.lbAdminEmailSearch.TabIndex = 6;
            this.lbAdminEmailSearch.Text = "E-mail:";
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
            this.AdminPage.ResumeLayout(false);
            this.gbAdminCreator.ResumeLayout(false);
            this.gbAdminCreator.PerformLayout();
            this.gbAdminDetails.ResumeLayout(false);
            this.gbAdminDetails.PerformLayout();
            this.gbSearchAdmin.ResumeLayout(false);
            this.gbSearchAdmin.PerformLayout();
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
        private TextBox tbNoteText;
        private TextBox tbNoteTitle;
        private GroupBox gbAdminDetails;
        private Button btUpdateAdmin;
        private Button btDelteteAdmin;
        private Label lbAdminRoleDetails;
        private TextBox tbAdminRoleDetails;
        private Label lbAdminEmailDetails;
        private Label lbAdminNameDetails;
        private TextBox tbAdminEmailDetails;
        private TextBox tbAdminNameDetails;
        private GroupBox gbSearchAdmin;
        private TextBox tbAdminId;
        private ListBox lbAdminList;
        private Button btAdminSearch;
        private Label lbAdminId;
        private Label lbAdminNameSearch;
        private TextBox tbAdminNameSearch;
        private TextBox tbAdminEmailSearch;
        private Label lbAdminEmailSearch;
        private Label lbAdminRoleSearch;
        private TextBox tbAdminRoleSearch;
        private Button btAddAdmin;
        private GroupBox gbAdminCreator;
        private Label lbAdminRoleCreator;
        private TextBox tbAdminRoleCreator;
        private Label lbAdminPasswordCreator;
        private TextBox tbAdminPasswordCreator;
        private Label lbAdminEmailCreator;
        private Label lbAdminNameCreator;
        private TextBox tbAdminEmailCreator;
        private TextBox tbAdminNameCreator;
    }
}

