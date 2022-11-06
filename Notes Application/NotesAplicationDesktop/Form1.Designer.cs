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
            this.gbAccount = new System.Windows.Forms.GroupBox();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.lbUsersList = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbUserId = new System.Windows.Forms.Label();
            this.tbUserPassword = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbUserPassword = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbUserEmail = new System.Windows.Forms.TextBox();
            this.lbUserEmail = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AdminPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.UserPage.SuspendLayout();
            this.gbAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.UserPage);
            this.tabControl1.Controls.Add(this.AdminPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1874, 1000);
            this.tabControl1.TabIndex = 0;
            // 
            // UserPage
            // 
            this.UserPage.Controls.Add(this.gbAccount);
            this.UserPage.Controls.Add(this.listBox1);
            this.UserPage.Location = new System.Drawing.Point(4, 29);
            this.UserPage.Name = "UserPage";
            this.UserPage.Padding = new System.Windows.Forms.Padding(3);
            this.UserPage.Size = new System.Drawing.Size(1866, 967);
            this.UserPage.TabIndex = 0;
            this.UserPage.Text = "Users";
            this.UserPage.UseVisualStyleBackColor = true;
            // 
            // gbAccount
            // 
            this.gbAccount.Controls.Add(this.tbUserId);
            this.gbAccount.Controls.Add(this.btnDeleteUser);
            this.gbAccount.Controls.Add(this.lbUsersList);
            this.gbAccount.Controls.Add(this.btnSearch);
            this.gbAccount.Controls.Add(this.lbUserId);
            this.gbAccount.Controls.Add(this.tbUserPassword);
            this.gbAccount.Controls.Add(this.lbUserName);
            this.gbAccount.Controls.Add(this.lbUserPassword);
            this.gbAccount.Controls.Add(this.tbUserName);
            this.gbAccount.Controls.Add(this.tbUserEmail);
            this.gbAccount.Controls.Add(this.lbUserEmail);
            this.gbAccount.Location = new System.Drawing.Point(6, 6);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Size = new System.Drawing.Size(511, 744);
            this.gbAccount.TabIndex = 12;
            this.gbAccount.TabStop = false;
            this.gbAccount.Text = "Account";
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(104, 32);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(196, 26);
            this.tbUserId.TabIndex = 3;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(20, 506);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(280, 30);
            this.btnDeleteUser.TabIndex = 11;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // lbUsersList
            // 
            this.lbUsersList.FormattingEnabled = true;
            this.lbUsersList.ItemHeight = 20;
            this.lbUsersList.Location = new System.Drawing.Point(20, 196);
            this.lbUsersList.Name = "lbUsersList";
            this.lbUsersList.Size = new System.Drawing.Size(280, 304);
            this.lbUsersList.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(20, 160);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(280, 30);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lbUserId
            // 
            this.lbUserId.AutoSize = true;
            this.lbUserId.Location = new System.Drawing.Point(16, 35);
            this.lbUserId.Name = "lbUserId";
            this.lbUserId.Size = new System.Drawing.Size(27, 20);
            this.lbUserId.TabIndex = 2;
            this.lbUserId.Text = "Id:";
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.Location = new System.Drawing.Point(104, 128);
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.Size = new System.Drawing.Size(196, 26);
            this.tbUserPassword.TabIndex = 9;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(16, 67);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(55, 20);
            this.lbUserName.TabIndex = 4;
            this.lbUserName.Text = "Name:";
            // 
            // lbUserPassword
            // 
            this.lbUserPassword.AutoSize = true;
            this.lbUserPassword.Location = new System.Drawing.Point(16, 131);
            this.lbUserPassword.Name = "lbUserPassword";
            this.lbUserPassword.Size = new System.Drawing.Size(82, 20);
            this.lbUserPassword.TabIndex = 8;
            this.lbUserPassword.Text = "Password:";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(104, 64);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(196, 26);
            this.tbUserName.TabIndex = 5;
            // 
            // tbUserEmail
            // 
            this.tbUserEmail.Location = new System.Drawing.Point(104, 96);
            this.tbUserEmail.Name = "tbUserEmail";
            this.tbUserEmail.Size = new System.Drawing.Size(196, 26);
            this.tbUserEmail.TabIndex = 7;
            // 
            // lbUserEmail
            // 
            this.lbUserEmail.AutoSize = true;
            this.lbUserEmail.Location = new System.Drawing.Point(16, 99);
            this.lbUserEmail.Name = "lbUserEmail";
            this.lbUserEmail.Size = new System.Drawing.Size(57, 20);
            this.lbUserEmail.TabIndex = 6;
            this.lbUserEmail.Text = "E-mail:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(1347, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(499, 904);
            this.listBox1.TabIndex = 0;
            // 
            // AdminPage
            // 
            this.AdminPage.Location = new System.Drawing.Point(4, 29);
            this.AdminPage.Name = "AdminPage";
            this.AdminPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdminPage.Size = new System.Drawing.Size(1866, 967);
            this.AdminPage.TabIndex = 1;
            this.AdminPage.Text = "Admins";
            this.AdminPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.UserPage.ResumeLayout(false);
            this.gbAccount.ResumeLayout(false);
            this.gbAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UserPage;
        private System.Windows.Forms.TabPage AdminPage;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Label lbUserId;
        private System.Windows.Forms.ListBox lbUsersList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbUserPassword;
        private System.Windows.Forms.Label lbUserPassword;
        private System.Windows.Forms.TextBox tbUserEmail;
        private System.Windows.Forms.Label lbUserEmail;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.GroupBox gbAccount;
    }
}

