namespace Test_działania_aplikacji
{
    partial class SettingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.UsersTab = new System.Windows.Forms.TabPage();
            this.buttonLoadDataBase = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.Uzytkownik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Haslo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rola = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonUpdateUserData = new System.Windows.Forms.Button();
            this.buttonAddNewUser = new System.Windows.Forms.Button();
            this.comboBoxUserAdminStatus = new System.Windows.Forms.ComboBox();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.labelAdminStatus = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.JigsTab = new System.Windows.Forms.TabPage();
            this.buttonCount = new System.Windows.Forms.Button();
            this.labelJig9 = new System.Windows.Forms.Label();
            this.labelJig8 = new System.Windows.Forms.Label();
            this.labelJig7 = new System.Windows.Forms.Label();
            this.labelJig6 = new System.Windows.Forms.Label();
            this.labelJig5 = new System.Windows.Forms.Label();
            this.labelJig4 = new System.Windows.Forms.Label();
            this.labelJig3 = new System.Windows.Forms.Label();
            this.labelJig2 = new System.Windows.Forms.Label();
            this.labelJig1 = new System.Windows.Forms.Label();
            this.buttonJig9 = new System.Windows.Forms.Button();
            this.buttonJig8 = new System.Windows.Forms.Button();
            this.buttonJig7 = new System.Windows.Forms.Button();
            this.buttonJig6 = new System.Windows.Forms.Button();
            this.buttonJig5 = new System.Windows.Forms.Button();
            this.buttonJig4 = new System.Windows.Forms.Button();
            this.buttonJig3 = new System.Windows.Forms.Button();
            this.buttonJig2 = new System.Windows.Forms.Button();
            this.buttonJig1 = new System.Windows.Forms.Button();
            this.toppanel2 = new System.Windows.Forms.Panel();
            this.minimalizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonMakeCoat = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tabSettings.SuspendLayout();
            this.UsersTab.SuspendLayout();
            this.JigsTab.SuspendLayout();
            this.toppanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.UsersTab);
            this.tabSettings.Controls.Add(this.JigsTab);
            this.tabSettings.Location = new System.Drawing.Point(238, 50);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(722, 469);
            this.tabSettings.TabIndex = 0;
            // 
            // UsersTab
            // 
            this.UsersTab.Controls.Add(this.buttonLoadDataBase);
            this.UsersTab.Controls.Add(this.buttonDeleteUser);
            this.UsersTab.Controls.Add(this.listViewUsers);
            this.UsersTab.Controls.Add(this.buttonUpdateUserData);
            this.UsersTab.Controls.Add(this.buttonAddNewUser);
            this.UsersTab.Controls.Add(this.comboBoxUserAdminStatus);
            this.UsersTab.Controls.Add(this.textBoxUserPassword);
            this.UsersTab.Controls.Add(this.textBoxUserName);
            this.UsersTab.Controls.Add(this.labelUserPassword);
            this.UsersTab.Controls.Add(this.labelAdminStatus);
            this.UsersTab.Controls.Add(this.labelUserName);
            this.UsersTab.Location = new System.Drawing.Point(4, 22);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.Padding = new System.Windows.Forms.Padding(3);
            this.UsersTab.Size = new System.Drawing.Size(714, 443);
            this.UsersTab.TabIndex = 1;
            this.UsersTab.Text = "Użytkownicy";
            this.UsersTab.UseVisualStyleBackColor = true;
            // 
            // buttonLoadDataBase
            // 
            this.buttonLoadDataBase.Location = new System.Drawing.Point(566, 326);
            this.buttonLoadDataBase.Name = "buttonLoadDataBase";
            this.buttonLoadDataBase.Size = new System.Drawing.Size(141, 39);
            this.buttonLoadDataBase.TabIndex = 17;
            this.buttonLoadDataBase.Text = "Zaktualizuj bazę danych";
            this.buttonLoadDataBase.UseVisualStyleBackColor = true;
            this.buttonLoadDataBase.Click += new System.EventHandler(this.buttonForceUpdateListView_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(389, 325);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(141, 40);
            this.buttonDeleteUser.TabIndex = 16;
            this.buttonDeleteUser.Text = "Usun użytkownika";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Uzytkownik,
            this.Haslo,
            this.Rola});
            this.listViewUsers.HideSelection = false;
            this.listViewUsers.Location = new System.Drawing.Point(389, 17);
            this.listViewUsers.MultiSelect = false;
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(318, 287);
            this.listViewUsers.TabIndex = 15;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            this.listViewUsers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewUsers_MouseClick);
            // 
            // Uzytkownik
            // 
            this.Uzytkownik.Tag = "";
            this.Uzytkownik.Text = "Użytkownik";
            this.Uzytkownik.Width = 134;
            // 
            // Haslo
            // 
            this.Haslo.Tag = "";
            this.Haslo.Text = "Hasło";
            this.Haslo.Width = 132;
            // 
            // Rola
            // 
            this.Rola.Tag = "";
            this.Rola.Text = "Rola";
            this.Rola.Width = 192;
            // 
            // buttonUpdateUserData
            // 
            this.buttonUpdateUserData.Location = new System.Drawing.Point(176, 199);
            this.buttonUpdateUserData.Name = "buttonUpdateUserData";
            this.buttonUpdateUserData.Size = new System.Drawing.Size(137, 37);
            this.buttonUpdateUserData.TabIndex = 14;
            this.buttonUpdateUserData.Text = "Zaktualizuj dane";
            this.buttonUpdateUserData.UseVisualStyleBackColor = true;
            this.buttonUpdateUserData.Click += new System.EventHandler(this.buttonUpdateUsers_Click);
            // 
            // buttonAddNewUser
            // 
            this.buttonAddNewUser.Location = new System.Drawing.Point(39, 198);
            this.buttonAddNewUser.Name = "buttonAddNewUser";
            this.buttonAddNewUser.Size = new System.Drawing.Size(130, 38);
            this.buttonAddNewUser.TabIndex = 13;
            this.buttonAddNewUser.Text = "Dodaj użytkownika";
            this.buttonAddNewUser.UseVisualStyleBackColor = true;
            this.buttonAddNewUser.Click += new System.EventHandler(this.buttonDodajUzytkownika_Click);
            // 
            // comboBoxUserAdminStatus
            // 
            this.comboBoxUserAdminStatus.FormattingEnabled = true;
            this.comboBoxUserAdminStatus.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.comboBoxUserAdminStatus.Location = new System.Drawing.Point(162, 143);
            this.comboBoxUserAdminStatus.Name = "comboBoxUserAdminStatus";
            this.comboBoxUserAdminStatus.Size = new System.Drawing.Size(151, 21);
            this.comboBoxUserAdminStatus.TabIndex = 12;
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(162, 94);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(151, 20);
            this.textBoxUserPassword.TabIndex = 11;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(162, 42);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(151, 20);
            this.textBoxUserName.TabIndex = 10;
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Location = new System.Drawing.Point(36, 97);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(98, 13);
            this.labelUserPassword.TabIndex = 9;
            this.labelUserPassword.Text = "Hasło użytkownika";
            // 
            // labelAdminStatus
            // 
            this.labelAdminStatus.AutoSize = true;
            this.labelAdminStatus.Location = new System.Drawing.Point(36, 146);
            this.labelAdminStatus.Name = "labelAdminStatus";
            this.labelAdminStatus.Size = new System.Drawing.Size(97, 13);
            this.labelAdminStatus.TabIndex = 8;
            this.labelAdminStatus.Text = "Konto użytkownika";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(36, 45);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(104, 13);
            this.labelUserName.TabIndex = 7;
            this.labelUserName.Text = "Nazwa Użytkownika";
            // 
            // JigsTab
            // 
            this.JigsTab.Controls.Add(this.button1);
            this.JigsTab.Controls.Add(this.buttonCount);
            this.JigsTab.Controls.Add(this.labelJig9);
            this.JigsTab.Controls.Add(this.labelJig8);
            this.JigsTab.Controls.Add(this.labelJig7);
            this.JigsTab.Controls.Add(this.labelJig6);
            this.JigsTab.Controls.Add(this.labelJig5);
            this.JigsTab.Controls.Add(this.labelJig4);
            this.JigsTab.Controls.Add(this.labelJig3);
            this.JigsTab.Controls.Add(this.labelJig2);
            this.JigsTab.Controls.Add(this.labelJig1);
            this.JigsTab.Controls.Add(this.buttonJig9);
            this.JigsTab.Controls.Add(this.buttonJig8);
            this.JigsTab.Controls.Add(this.buttonJig7);
            this.JigsTab.Controls.Add(this.buttonJig6);
            this.JigsTab.Controls.Add(this.buttonJig5);
            this.JigsTab.Controls.Add(this.buttonJig4);
            this.JigsTab.Controls.Add(this.buttonJig3);
            this.JigsTab.Controls.Add(this.buttonJig2);
            this.JigsTab.Controls.Add(this.buttonJig1);
            this.JigsTab.Location = new System.Drawing.Point(4, 22);
            this.JigsTab.Name = "JigsTab";
            this.JigsTab.Padding = new System.Windows.Forms.Padding(3);
            this.JigsTab.Size = new System.Drawing.Size(714, 443);
            this.JigsTab.TabIndex = 2;
            this.JigsTab.Text = "Wózki";
            this.JigsTab.UseVisualStyleBackColor = true;
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(17, 147);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(106, 36);
            this.buttonCount.TabIndex = 2;
            this.buttonCount.Text = "Odśwież";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelJig9
            // 
            this.labelJig9.AutoSize = true;
            this.labelJig9.Location = new System.Drawing.Point(645, 99);
            this.labelJig9.Name = "labelJig9";
            this.labelJig9.Size = new System.Drawing.Size(35, 13);
            this.labelJig9.TabIndex = 1;
            this.labelJig9.Text = "label1";
            // 
            // labelJig8
            // 
            this.labelJig8.AutoSize = true;
            this.labelJig8.Location = new System.Drawing.Point(570, 99);
            this.labelJig8.Name = "labelJig8";
            this.labelJig8.Size = new System.Drawing.Size(35, 13);
            this.labelJig8.TabIndex = 1;
            this.labelJig8.Text = "label1";
            // 
            // labelJig7
            // 
            this.labelJig7.AutoSize = true;
            this.labelJig7.Location = new System.Drawing.Point(492, 99);
            this.labelJig7.Name = "labelJig7";
            this.labelJig7.Size = new System.Drawing.Size(35, 13);
            this.labelJig7.TabIndex = 1;
            this.labelJig7.Text = "label1";
            // 
            // labelJig6
            // 
            this.labelJig6.AutoSize = true;
            this.labelJig6.Location = new System.Drawing.Point(417, 99);
            this.labelJig6.Name = "labelJig6";
            this.labelJig6.Size = new System.Drawing.Size(35, 13);
            this.labelJig6.TabIndex = 1;
            this.labelJig6.Text = "label1";
            // 
            // labelJig5
            // 
            this.labelJig5.AutoSize = true;
            this.labelJig5.Location = new System.Drawing.Point(341, 99);
            this.labelJig5.Name = "labelJig5";
            this.labelJig5.Size = new System.Drawing.Size(35, 13);
            this.labelJig5.TabIndex = 1;
            this.labelJig5.Text = "label1";
            // 
            // labelJig4
            // 
            this.labelJig4.AutoSize = true;
            this.labelJig4.Location = new System.Drawing.Point(265, 99);
            this.labelJig4.Name = "labelJig4";
            this.labelJig4.Size = new System.Drawing.Size(35, 13);
            this.labelJig4.TabIndex = 1;
            this.labelJig4.Text = "label1";
            // 
            // labelJig3
            // 
            this.labelJig3.AutoSize = true;
            this.labelJig3.Location = new System.Drawing.Point(185, 99);
            this.labelJig3.Name = "labelJig3";
            this.labelJig3.Size = new System.Drawing.Size(35, 13);
            this.labelJig3.TabIndex = 1;
            this.labelJig3.Text = "label1";
            // 
            // labelJig2
            // 
            this.labelJig2.AutoSize = true;
            this.labelJig2.Location = new System.Drawing.Point(110, 99);
            this.labelJig2.Name = "labelJig2";
            this.labelJig2.Size = new System.Drawing.Size(35, 13);
            this.labelJig2.TabIndex = 1;
            this.labelJig2.Text = "label1";
            // 
            // labelJig1
            // 
            this.labelJig1.AutoSize = true;
            this.labelJig1.Location = new System.Drawing.Point(33, 99);
            this.labelJig1.Name = "labelJig1";
            this.labelJig1.Size = new System.Drawing.Size(35, 13);
            this.labelJig1.TabIndex = 1;
            this.labelJig1.Text = "label1";
            // 
            // buttonJig9
            // 
            this.buttonJig9.Location = new System.Drawing.Point(628, 43);
            this.buttonJig9.Name = "buttonJig9";
            this.buttonJig9.Size = new System.Drawing.Size(70, 50);
            this.buttonJig9.TabIndex = 0;
            this.buttonJig9.Text = "Wózek9";
            this.buttonJig9.UseVisualStyleBackColor = true;
            this.buttonJig9.Click += new System.EventHandler(this.buttonJig9_Click);
            // 
            // buttonJig8
            // 
            this.buttonJig8.Location = new System.Drawing.Point(552, 43);
            this.buttonJig8.Name = "buttonJig8";
            this.buttonJig8.Size = new System.Drawing.Size(70, 50);
            this.buttonJig8.TabIndex = 0;
            this.buttonJig8.Text = "Wózek8";
            this.buttonJig8.UseVisualStyleBackColor = true;
            this.buttonJig8.Click += new System.EventHandler(this.buttonJig8_Click);
            // 
            // buttonJig7
            // 
            this.buttonJig7.Location = new System.Drawing.Point(476, 43);
            this.buttonJig7.Name = "buttonJig7";
            this.buttonJig7.Size = new System.Drawing.Size(70, 50);
            this.buttonJig7.TabIndex = 0;
            this.buttonJig7.Text = "Wózek7";
            this.buttonJig7.UseVisualStyleBackColor = true;
            this.buttonJig7.Click += new System.EventHandler(this.buttonJig7_Click);
            // 
            // buttonJig6
            // 
            this.buttonJig6.Location = new System.Drawing.Point(400, 43);
            this.buttonJig6.Name = "buttonJig6";
            this.buttonJig6.Size = new System.Drawing.Size(70, 50);
            this.buttonJig6.TabIndex = 0;
            this.buttonJig6.Text = "Wózek6";
            this.buttonJig6.UseVisualStyleBackColor = true;
            this.buttonJig6.Click += new System.EventHandler(this.buttonJig6_Click);
            // 
            // buttonJig5
            // 
            this.buttonJig5.Location = new System.Drawing.Point(324, 43);
            this.buttonJig5.Name = "buttonJig5";
            this.buttonJig5.Size = new System.Drawing.Size(70, 50);
            this.buttonJig5.TabIndex = 0;
            this.buttonJig5.Text = "Wózek5";
            this.buttonJig5.UseVisualStyleBackColor = true;
            this.buttonJig5.Click += new System.EventHandler(this.buttonJig5_Click);
            // 
            // buttonJig4
            // 
            this.buttonJig4.Location = new System.Drawing.Point(248, 43);
            this.buttonJig4.Name = "buttonJig4";
            this.buttonJig4.Size = new System.Drawing.Size(70, 50);
            this.buttonJig4.TabIndex = 0;
            this.buttonJig4.Text = "Wózek4";
            this.buttonJig4.UseVisualStyleBackColor = true;
            this.buttonJig4.Click += new System.EventHandler(this.buttonJig4_Click);
            // 
            // buttonJig3
            // 
            this.buttonJig3.Location = new System.Drawing.Point(169, 43);
            this.buttonJig3.Name = "buttonJig3";
            this.buttonJig3.Size = new System.Drawing.Size(70, 50);
            this.buttonJig3.TabIndex = 0;
            this.buttonJig3.Text = "Wózek3";
            this.buttonJig3.UseVisualStyleBackColor = true;
            this.buttonJig3.Click += new System.EventHandler(this.buttonJig3_Click);
            // 
            // buttonJig2
            // 
            this.buttonJig2.Location = new System.Drawing.Point(93, 43);
            this.buttonJig2.Name = "buttonJig2";
            this.buttonJig2.Size = new System.Drawing.Size(70, 50);
            this.buttonJig2.TabIndex = 0;
            this.buttonJig2.Text = "Wózek 2";
            this.buttonJig2.UseVisualStyleBackColor = true;
            this.buttonJig2.Click += new System.EventHandler(this.buttonJig2_Click);
            // 
            // buttonJig1
            // 
            this.buttonJig1.Location = new System.Drawing.Point(17, 43);
            this.buttonJig1.Name = "buttonJig1";
            this.buttonJig1.Size = new System.Drawing.Size(70, 50);
            this.buttonJig1.TabIndex = 0;
            this.buttonJig1.Text = "Wózek 1";
            this.buttonJig1.UseVisualStyleBackColor = true;
            this.buttonJig1.Click += new System.EventHandler(this.buttonJig1_Click);
            // 
            // toppanel2
            // 
            this.toppanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.toppanel2.Controls.Add(this.minimalizeButton);
            this.toppanel2.Controls.Add(this.closeButton);
            this.toppanel2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.toppanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel2.Location = new System.Drawing.Point(0, 0);
            this.toppanel2.Name = "toppanel2";
            this.toppanel2.Size = new System.Drawing.Size(988, 31);
            this.toppanel2.TabIndex = 6;
            // 
            // minimalizeButton
            // 
            this.minimalizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimalizeButton.FlatAppearance.BorderSize = 0;
            this.minimalizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.minimalizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimalizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimalizeButton.Image")));
            this.minimalizeButton.Location = new System.Drawing.Point(935, 0);
            this.minimalizeButton.Name = "minimalizeButton";
            this.minimalizeButton.Size = new System.Drawing.Size(22, 31);
            this.minimalizeButton.TabIndex = 1;
            this.minimalizeButton.UseVisualStyleBackColor = true;
            this.minimalizeButton.Click += new System.EventHandler(this.minimalizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(963, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(22, 31);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.labelCurrentTime);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonSettings);
            this.panel1.Controls.Add(this.buttonHistory);
            this.panel1.Controls.Add(this.buttonMakeCoat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 539);
            this.panel1.TabIndex = 9;
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentTime.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCurrentTime.Location = new System.Drawing.Point(37, 497);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(61, 17);
            this.labelCurrentTime.TabIndex = 6;
            this.labelCurrentTime.Text = "Godzina";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.SidePanel.Location = new System.Drawing.Point(3, 140);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 55);
            this.SidePanel.TabIndex = 4;
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.buttonExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExit.Location = new System.Drawing.Point(13, 201);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(217, 55);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "          Wyjście";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.buttonSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSettings.Location = new System.Drawing.Point(13, 140);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(217, 55);
            this.buttonSettings.TabIndex = 2;
            this.buttonSettings.Text = "          Ustawienia";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.UseVisualStyleBackColor = false;
            // 
            // buttonHistory
            // 
            this.buttonHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHistory.FlatAppearance.BorderSize = 0;
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.buttonHistory.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonHistory.Location = new System.Drawing.Point(13, 79);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(217, 55);
            this.buttonHistory.TabIndex = 1;
            this.buttonHistory.Text = "          Historia";
            this.buttonHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.ButtonHistory_Click);
            // 
            // buttonMakeCoat
            // 
            this.buttonMakeCoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.buttonMakeCoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMakeCoat.FlatAppearance.BorderSize = 0;
            this.buttonMakeCoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMakeCoat.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMakeCoat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMakeCoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMakeCoat.Location = new System.Drawing.Point(13, 18);
            this.buttonMakeCoat.Name = "buttonMakeCoat";
            this.buttonMakeCoat.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonMakeCoat.Size = new System.Drawing.Size(217, 55);
            this.buttonMakeCoat.TabIndex = 0;
            this.buttonMakeCoat.Text = "          Zrób lakier";
            this.buttonMakeCoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMakeCoat.UseVisualStyleBackColor = false;
            this.buttonMakeCoat.Click += new System.EventHandler(this.ButtonMakeCoat_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zapisz jako CSV";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toppanel2);
            this.Controls.Add(this.tabSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UstawieniaForm";
            this.Load += new System.EventHandler(this.UstawieniaForm_Load);
            this.tabSettings.ResumeLayout(false);
            this.UsersTab.ResumeLayout(false);
            this.UsersTab.PerformLayout();
            this.JigsTab.ResumeLayout(false);
            this.JigsTab.PerformLayout();
            this.toppanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage UsersTab;
        private System.Windows.Forms.Button buttonAddNewUser;
        private System.Windows.Forms.ComboBox comboBoxUserAdminStatus;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Label labelAdminStatus;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonUpdateUserData;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.ColumnHeader Uzytkownik;
        private System.Windows.Forms.ColumnHeader Haslo;
        private System.Windows.Forms.ColumnHeader Rola;
        private System.Windows.Forms.Button buttonLoadDataBase;
        private System.Windows.Forms.Panel toppanel2;
        private System.Windows.Forms.Button minimalizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonMakeCoat;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TabPage JigsTab;
        private System.Windows.Forms.Button buttonJig8;
        private System.Windows.Forms.Button buttonJig7;
        private System.Windows.Forms.Button buttonJig6;
        private System.Windows.Forms.Button buttonJig5;
        private System.Windows.Forms.Button buttonJig4;
        private System.Windows.Forms.Button buttonJig3;
        private System.Windows.Forms.Button buttonJig2;
        private System.Windows.Forms.Button buttonJig1;
        private System.Windows.Forms.Button buttonJig9;
        private System.Windows.Forms.Label labelJig9;
        private System.Windows.Forms.Label labelJig8;
        private System.Windows.Forms.Label labelJig7;
        private System.Windows.Forms.Label labelJig6;
        private System.Windows.Forms.Label labelJig5;
        private System.Windows.Forms.Label labelJig4;
        private System.Windows.Forms.Label labelJig3;
        private System.Windows.Forms.Label labelJig2;
        private System.Windows.Forms.Label labelJig1;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Button button1;
    }
}