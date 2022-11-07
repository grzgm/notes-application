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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AdminPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.UserPage.SuspendLayout();
            this.gbAccountManage.SuspendLayout();
            this.gbAccountSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.UserPage);
            this.tabControl1.Controls.Add(this.AdminPage);
            this.tabControl1.Location = new System.Drawing.Point(13, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2082, 1250);
            this.tabControl1.TabIndex = 0;
            // 
            // UserPage
            // 
            this.UserPage.Controls.Add(this.gbAccountManage);
            this.UserPage.Controls.Add(this.gbAccountSearch);
            this.UserPage.Controls.Add(this.listBox1);
            this.UserPage.Location = new System.Drawing.Point(4, 34);
            this.UserPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserPage.Name = "UserPage";
            this.UserPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserPage.Size = new System.Drawing.Size(2074, 1212);
            this.UserPage.TabIndex = 0;
            this.UserPage.Text = "Users";
            this.UserPage.UseVisualStyleBackColor = true;
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
            this.gbAccountManage.Location = new System.Drawing.Point(581, 8);
            this.gbAccountManage.Name = "gbAccountManage";
            this.gbAccountManage.Size = new System.Drawing.Size(592, 930);
            this.gbAccountManage.TabIndex = 13;
            this.gbAccountManage.TabStop = false;
            this.gbAccountManage.Text = "Manage Account";
            // 
            // btUpdateUser
            // 
            this.btUpdateUser.Location = new System.Drawing.Point(6, 237);
            this.btUpdateUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btUpdateUser.Name = "btUpdateUser";
            this.btUpdateUser.Size = new System.Drawing.Size(424, 38);
            this.btUpdateUser.TabIndex = 26;
            this.btUpdateUser.Text = "Update User";
            this.btUpdateUser.UseVisualStyleBackColor = true;
            // 
            // lbPremiumEndDate
            // 
            this.lbPremiumEndDate.AutoSize = true;
            this.lbPremiumEndDate.Location = new System.Drawing.Point(6, 200);
            this.lbPremiumEndDate.Name = "lbPremiumEndDate";
            this.lbPremiumEndDate.Size = new System.Drawing.Size(164, 25);
            this.lbPremiumEndDate.TabIndex = 24;
            this.lbPremiumEndDate.Text = "Premium End Date:";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(6, 283);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(424, 38);
            this.btnDeleteUser.TabIndex = 11;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // tbPremiumEndDate
            // 
            this.tbPremiumEndDate.Location = new System.Drawing.Point(213, 198);
            this.tbPremiumEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPremiumEndDate.Name = "tbPremiumEndDate";
            this.tbPremiumEndDate.Size = new System.Drawing.Size(217, 31);
            this.tbPremiumEndDate.TabIndex = 25;
            // 
            // lbMaxLengthOfNotes
            // 
            this.lbMaxLengthOfNotes.AutoSize = true;
            this.lbMaxLengthOfNotes.Location = new System.Drawing.Point(6, 161);
            this.lbMaxLengthOfNotes.Name = "lbMaxLengthOfNotes";
            this.lbMaxLengthOfNotes.Size = new System.Drawing.Size(185, 25);
            this.lbMaxLengthOfNotes.TabIndex = 22;
            this.lbMaxLengthOfNotes.Text = "Max Length Of Notes:";
            // 
            // tbMaxLengthOfNotes
            // 
            this.tbMaxLengthOfNotes.Location = new System.Drawing.Point(213, 159);
            this.tbMaxLengthOfNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaxLengthOfNotes.Name = "tbMaxLengthOfNotes";
            this.tbMaxLengthOfNotes.Size = new System.Drawing.Size(217, 31);
            this.tbMaxLengthOfNotes.TabIndex = 23;
            // 
            // lbMaxAmountOfNotesManage
            // 
            this.lbMaxAmountOfNotesManage.AutoSize = true;
            this.lbMaxAmountOfNotesManage.Location = new System.Drawing.Point(6, 122);
            this.lbMaxAmountOfNotesManage.Name = "lbMaxAmountOfNotesManage";
            this.lbMaxAmountOfNotesManage.Size = new System.Drawing.Size(196, 25);
            this.lbMaxAmountOfNotesManage.TabIndex = 20;
            this.lbMaxAmountOfNotesManage.Text = "Max Amount Of Notes:";
            // 
            // tbMaxAmountOfNotes
            // 
            this.tbMaxAmountOfNotes.Location = new System.Drawing.Point(213, 120);
            this.tbMaxAmountOfNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaxAmountOfNotes.Name = "tbMaxAmountOfNotes";
            this.tbMaxAmountOfNotes.Size = new System.Drawing.Size(217, 31);
            this.tbMaxAmountOfNotes.TabIndex = 21;
            // 
            // lbUserEmailManage
            // 
            this.lbUserEmailManage.AutoSize = true;
            this.lbUserEmailManage.Location = new System.Drawing.Point(6, 84);
            this.lbUserEmailManage.Name = "lbUserEmailManage";
            this.lbUserEmailManage.Size = new System.Drawing.Size(65, 25);
            this.lbUserEmailManage.TabIndex = 18;
            this.lbUserEmailManage.Text = "E-mail:";
            // 
            // lbUserNameManage
            // 
            this.lbUserNameManage.AutoSize = true;
            this.lbUserNameManage.Location = new System.Drawing.Point(6, 44);
            this.lbUserNameManage.Name = "lbUserNameManage";
            this.lbUserNameManage.Size = new System.Drawing.Size(63, 25);
            this.lbUserNameManage.TabIndex = 16;
            this.lbUserNameManage.Text = "Name:";
            // 
            // tbUserEmailManage
            // 
            this.tbUserEmailManage.Location = new System.Drawing.Point(213, 82);
            this.tbUserEmailManage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUserEmailManage.Name = "tbUserEmailManage";
            this.tbUserEmailManage.Size = new System.Drawing.Size(217, 31);
            this.tbUserEmailManage.TabIndex = 19;
            // 
            // tbUserNameManage
            // 
            this.tbUserNameManage.Location = new System.Drawing.Point(213, 42);
            this.tbUserNameManage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUserNameManage.Name = "tbUserNameManage";
            this.tbUserNameManage.Size = new System.Drawing.Size(217, 31);
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
            this.gbAccountSearch.Location = new System.Drawing.Point(7, 8);
            this.gbAccountSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAccountSearch.Name = "gbAccountSearch";
            this.gbAccountSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAccountSearch.Size = new System.Drawing.Size(568, 930);
            this.gbAccountSearch.TabIndex = 12;
            this.gbAccountSearch.TabStop = false;
            this.gbAccountSearch.Text = "Search Account";
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(116, 41);
            this.tbUserId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(217, 31);
            this.tbUserId.TabIndex = 14;
            // 
            // lbUsersList
            // 
            this.lbUsersList.FormattingEnabled = true;
            this.lbUsersList.ItemHeight = 25;
            this.lbUsersList.Location = new System.Drawing.Point(22, 204);
            this.lbUsersList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbUsersList.Name = "lbUsersList";
            this.lbUsersList.Size = new System.Drawing.Size(311, 379);
            this.lbUsersList.TabIndex = 1;
            this.lbUsersList.SelectedIndexChanged += new System.EventHandler(this.lbUsersList_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(22, 159);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.lbUserId.Name = "lbUserId";
            this.lbUserId.Size = new System.Drawing.Size(32, 25);
            this.lbUserId.TabIndex = 2;
            this.lbUserId.Text = "Id:";
            // 
            // lbUserNameSearch
            // 
            this.lbUserNameSearch.AutoSize = true;
            this.lbUserNameSearch.Location = new System.Drawing.Point(18, 84);
            this.lbUserNameSearch.Name = "lbUserNameSearch";
            this.lbUserNameSearch.Size = new System.Drawing.Size(63, 25);
            this.lbUserNameSearch.TabIndex = 4;
            this.lbUserNameSearch.Text = "Name:";
            // 
            // tbUserNameSearch
            // 
            this.tbUserNameSearch.Location = new System.Drawing.Point(116, 80);
            this.tbUserNameSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUserNameSearch.Name = "tbUserNameSearch";
            this.tbUserNameSearch.Size = new System.Drawing.Size(217, 31);
            this.tbUserNameSearch.TabIndex = 5;
            // 
            // tbUserEmailSearch
            // 
            this.tbUserEmailSearch.Location = new System.Drawing.Point(116, 120);
            this.tbUserEmailSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUserEmailSearch.Name = "tbUserEmailSearch";
            this.tbUserEmailSearch.Size = new System.Drawing.Size(217, 31);
            this.tbUserEmailSearch.TabIndex = 7;
            // 
            // lbUserEmailSearch
            // 
            this.lbUserEmailSearch.AutoSize = true;
            this.lbUserEmailSearch.Location = new System.Drawing.Point(18, 124);
            this.lbUserEmailSearch.Name = "lbUserEmailSearch";
            this.lbUserEmailSearch.Size = new System.Drawing.Size(65, 25);
            this.lbUserEmailSearch.TabIndex = 6;
            this.lbUserEmailSearch.Text = "E-mail:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(1179, 18);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(482, 929);
            this.listBox1.TabIndex = 0;
            // 
            // AdminPage
            // 
            this.AdminPage.Location = new System.Drawing.Point(4, 34);
            this.AdminPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdminPage.Name = "AdminPage";
            this.AdminPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdminPage.Size = new System.Drawing.Size(2074, 1212);
            this.AdminPage.TabIndex = 1;
            this.AdminPage.Text = "Admins";
            this.AdminPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2109, 1280);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.UserPage.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox listBox1;
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
    }
}

