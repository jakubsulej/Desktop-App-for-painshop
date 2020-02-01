namespace Test_działania_aplikacji
{
    partial class UstawieniaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UstawieniaForm));
            this.tabUstawienia = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonWczytajBaze = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.listViewUzytkownicy = new System.Windows.Forms.ListView();
            this.Uzytkownik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Haslo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rola = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAktualizujUzytkownika = new System.Windows.Forms.Button();
            this.buttonDodajUzytkownika = new System.Windows.Forms.Button();
            this.comboBoxRolaUzytkownika = new System.Windows.Forms.ComboBox();
            this.textBoxHasloUzytkownika = new System.Windows.Forms.TextBox();
            this.textBoxNazwaUzytkownika = new System.Windows.Forms.TextBox();
            this.labelHasloUzytkownika = new System.Windows.Forms.Label();
            this.labelKontoUzytkownika = new System.Windows.Forms.Label();
            this.labelNazwaUzytkownika = new System.Windows.Forms.Label();
            this.toppanel2 = new System.Windows.Forms.Panel();
            this.minimalizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelGodzina = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.buttonWyjscie = new System.Windows.Forms.Button();
            this.buttonUstawienia = new System.Windows.Forms.Button();
            this.buttonHistoria = new System.Windows.Forms.Button();
            this.buttonRobienieLaku = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabUstawienia.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toppanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUstawienia
            // 
            this.tabUstawienia.Controls.Add(this.tabPage2);
            this.tabUstawienia.Location = new System.Drawing.Point(238, 50);
            this.tabUstawienia.Name = "tabUstawienia";
            this.tabUstawienia.SelectedIndex = 0;
            this.tabUstawienia.Size = new System.Drawing.Size(722, 469);
            this.tabUstawienia.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonWczytajBaze);
            this.tabPage2.Controls.Add(this.buttonUsun);
            this.tabPage2.Controls.Add(this.listViewUzytkownicy);
            this.tabPage2.Controls.Add(this.buttonAktualizujUzytkownika);
            this.tabPage2.Controls.Add(this.buttonDodajUzytkownika);
            this.tabPage2.Controls.Add(this.comboBoxRolaUzytkownika);
            this.tabPage2.Controls.Add(this.textBoxHasloUzytkownika);
            this.tabPage2.Controls.Add(this.textBoxNazwaUzytkownika);
            this.tabPage2.Controls.Add(this.labelHasloUzytkownika);
            this.tabPage2.Controls.Add(this.labelKontoUzytkownika);
            this.tabPage2.Controls.Add(this.labelNazwaUzytkownika);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(714, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonWczytajBaze
            // 
            this.buttonWczytajBaze.Location = new System.Drawing.Point(566, 326);
            this.buttonWczytajBaze.Name = "buttonWczytajBaze";
            this.buttonWczytajBaze.Size = new System.Drawing.Size(141, 39);
            this.buttonWczytajBaze.TabIndex = 17;
            this.buttonWczytajBaze.Text = "Zaktualizuj bazę danych";
            this.buttonWczytajBaze.UseVisualStyleBackColor = true;
            this.buttonWczytajBaze.Click += new System.EventHandler(this.buttonWczytajBaze_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(389, 325);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(141, 40);
            this.buttonUsun.TabIndex = 16;
            this.buttonUsun.Text = "Usun użytkownika";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // listViewUzytkownicy
            // 
            this.listViewUzytkownicy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Uzytkownik,
            this.Haslo,
            this.Rola});
            this.listViewUzytkownicy.HideSelection = false;
            this.listViewUzytkownicy.Location = new System.Drawing.Point(389, 17);
            this.listViewUzytkownicy.MultiSelect = false;
            this.listViewUzytkownicy.Name = "listViewUzytkownicy";
            this.listViewUzytkownicy.Size = new System.Drawing.Size(318, 287);
            this.listViewUzytkownicy.TabIndex = 15;
            this.listViewUzytkownicy.UseCompatibleStateImageBehavior = false;
            this.listViewUzytkownicy.View = System.Windows.Forms.View.Details;
            this.listViewUzytkownicy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewUzytkownicy_MouseClick);
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
            // buttonAktualizujUzytkownika
            // 
            this.buttonAktualizujUzytkownika.Location = new System.Drawing.Point(176, 199);
            this.buttonAktualizujUzytkownika.Name = "buttonAktualizujUzytkownika";
            this.buttonAktualizujUzytkownika.Size = new System.Drawing.Size(137, 37);
            this.buttonAktualizujUzytkownika.TabIndex = 14;
            this.buttonAktualizujUzytkownika.Text = "Zaktualizuj dane";
            this.buttonAktualizujUzytkownika.UseVisualStyleBackColor = true;
            this.buttonAktualizujUzytkownika.Click += new System.EventHandler(this.buttonAktualizuj_Click);
            // 
            // buttonDodajUzytkownika
            // 
            this.buttonDodajUzytkownika.Location = new System.Drawing.Point(39, 198);
            this.buttonDodajUzytkownika.Name = "buttonDodajUzytkownika";
            this.buttonDodajUzytkownika.Size = new System.Drawing.Size(130, 38);
            this.buttonDodajUzytkownika.TabIndex = 13;
            this.buttonDodajUzytkownika.Text = "Dodaj użytkownika";
            this.buttonDodajUzytkownika.UseVisualStyleBackColor = true;
            this.buttonDodajUzytkownika.Click += new System.EventHandler(this.buttonDodajUzytkownika_Click);
            // 
            // comboBoxRolaUzytkownika
            // 
            this.comboBoxRolaUzytkownika.FormattingEnabled = true;
            this.comboBoxRolaUzytkownika.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.comboBoxRolaUzytkownika.Location = new System.Drawing.Point(162, 143);
            this.comboBoxRolaUzytkownika.Name = "comboBoxRolaUzytkownika";
            this.comboBoxRolaUzytkownika.Size = new System.Drawing.Size(151, 21);
            this.comboBoxRolaUzytkownika.TabIndex = 12;
            // 
            // textBoxHasloUzytkownika
            // 
            this.textBoxHasloUzytkownika.Location = new System.Drawing.Point(162, 94);
            this.textBoxHasloUzytkownika.Name = "textBoxHasloUzytkownika";
            this.textBoxHasloUzytkownika.Size = new System.Drawing.Size(151, 20);
            this.textBoxHasloUzytkownika.TabIndex = 11;
            // 
            // textBoxNazwaUzytkownika
            // 
            this.textBoxNazwaUzytkownika.Location = new System.Drawing.Point(162, 42);
            this.textBoxNazwaUzytkownika.Name = "textBoxNazwaUzytkownika";
            this.textBoxNazwaUzytkownika.Size = new System.Drawing.Size(151, 20);
            this.textBoxNazwaUzytkownika.TabIndex = 10;
            // 
            // labelHasloUzytkownika
            // 
            this.labelHasloUzytkownika.AutoSize = true;
            this.labelHasloUzytkownika.Location = new System.Drawing.Point(36, 97);
            this.labelHasloUzytkownika.Name = "labelHasloUzytkownika";
            this.labelHasloUzytkownika.Size = new System.Drawing.Size(98, 13);
            this.labelHasloUzytkownika.TabIndex = 9;
            this.labelHasloUzytkownika.Text = "Hasło użytkownika";
            // 
            // labelKontoUzytkownika
            // 
            this.labelKontoUzytkownika.AutoSize = true;
            this.labelKontoUzytkownika.Location = new System.Drawing.Point(36, 146);
            this.labelKontoUzytkownika.Name = "labelKontoUzytkownika";
            this.labelKontoUzytkownika.Size = new System.Drawing.Size(97, 13);
            this.labelKontoUzytkownika.TabIndex = 8;
            this.labelKontoUzytkownika.Text = "Konto użytkownika";
            // 
            // labelNazwaUzytkownika
            // 
            this.labelNazwaUzytkownika.AutoSize = true;
            this.labelNazwaUzytkownika.Location = new System.Drawing.Point(36, 45);
            this.labelNazwaUzytkownika.Name = "labelNazwaUzytkownika";
            this.labelNazwaUzytkownika.Size = new System.Drawing.Size(104, 13);
            this.labelNazwaUzytkownika.TabIndex = 7;
            this.labelNazwaUzytkownika.Text = "Nazwa Użytkownika";
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
            this.panel1.Controls.Add(this.labelGodzina);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.buttonWyjscie);
            this.panel1.Controls.Add(this.buttonUstawienia);
            this.panel1.Controls.Add(this.buttonHistoria);
            this.panel1.Controls.Add(this.buttonRobienieLaku);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 539);
            this.panel1.TabIndex = 9;
            // 
            // labelGodzina
            // 
            this.labelGodzina.AutoSize = true;
            this.labelGodzina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGodzina.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGodzina.Location = new System.Drawing.Point(37, 497);
            this.labelGodzina.Name = "labelGodzina";
            this.labelGodzina.Size = new System.Drawing.Size(61, 17);
            this.labelGodzina.TabIndex = 6;
            this.labelGodzina.Text = "Godzina";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.SidePanel.Location = new System.Drawing.Point(3, 140);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 55);
            this.SidePanel.TabIndex = 4;
            // 
            // buttonWyjscie
            // 
            this.buttonWyjscie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWyjscie.FlatAppearance.BorderSize = 0;
            this.buttonWyjscie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWyjscie.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.buttonWyjscie.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonWyjscie.Location = new System.Drawing.Point(13, 201);
            this.buttonWyjscie.Name = "buttonWyjscie";
            this.buttonWyjscie.Size = new System.Drawing.Size(217, 55);
            this.buttonWyjscie.TabIndex = 3;
            this.buttonWyjscie.Text = "          Wyjście";
            this.buttonWyjscie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWyjscie.UseVisualStyleBackColor = true;
            this.buttonWyjscie.Click += new System.EventHandler(this.buttonWyjscie_Click);
            // 
            // buttonUstawienia
            // 
            this.buttonUstawienia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.buttonUstawienia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUstawienia.FlatAppearance.BorderSize = 0;
            this.buttonUstawienia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUstawienia.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.buttonUstawienia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonUstawienia.Location = new System.Drawing.Point(13, 140);
            this.buttonUstawienia.Name = "buttonUstawienia";
            this.buttonUstawienia.Size = new System.Drawing.Size(217, 55);
            this.buttonUstawienia.TabIndex = 2;
            this.buttonUstawienia.Text = "          Ustawienia";
            this.buttonUstawienia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUstawienia.UseVisualStyleBackColor = false;
            // 
            // buttonHistoria
            // 
            this.buttonHistoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHistoria.FlatAppearance.BorderSize = 0;
            this.buttonHistoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistoria.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.buttonHistoria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonHistoria.Location = new System.Drawing.Point(13, 79);
            this.buttonHistoria.Name = "buttonHistoria";
            this.buttonHistoria.Size = new System.Drawing.Size(217, 55);
            this.buttonHistoria.TabIndex = 1;
            this.buttonHistoria.Text = "          Historia";
            this.buttonHistoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHistoria.UseVisualStyleBackColor = true;
            this.buttonHistoria.Click += new System.EventHandler(this.buttonHistoria_Click);
            // 
            // buttonRobienieLaku
            // 
            this.buttonRobienieLaku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.buttonRobienieLaku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRobienieLaku.FlatAppearance.BorderSize = 0;
            this.buttonRobienieLaku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRobienieLaku.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRobienieLaku.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRobienieLaku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRobienieLaku.Location = new System.Drawing.Point(13, 18);
            this.buttonRobienieLaku.Name = "buttonRobienieLaku";
            this.buttonRobienieLaku.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonRobienieLaku.Size = new System.Drawing.Size(217, 55);
            this.buttonRobienieLaku.TabIndex = 0;
            this.buttonRobienieLaku.Text = "          Zrób lakier";
            this.buttonRobienieLaku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRobienieLaku.UseVisualStyleBackColor = false;
            this.buttonRobienieLaku.Click += new System.EventHandler(this.buttonRobienieLaku_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // UstawieniaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toppanel2);
            this.Controls.Add(this.tabUstawienia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UstawieniaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UstawieniaForm";
            this.Load += new System.EventHandler(this.UstawieniaForm_Load);
            this.tabUstawienia.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toppanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUstawienia;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonDodajUzytkownika;
        private System.Windows.Forms.ComboBox comboBoxRolaUzytkownika;
        private System.Windows.Forms.TextBox textBoxHasloUzytkownika;
        private System.Windows.Forms.TextBox textBoxNazwaUzytkownika;
        private System.Windows.Forms.Label labelHasloUzytkownika;
        private System.Windows.Forms.Label labelKontoUzytkownika;
        private System.Windows.Forms.Label labelNazwaUzytkownika;
        private System.Windows.Forms.Button buttonAktualizujUzytkownika;
        private System.Windows.Forms.ListView listViewUzytkownicy;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.ColumnHeader Uzytkownik;
        private System.Windows.Forms.ColumnHeader Haslo;
        private System.Windows.Forms.ColumnHeader Rola;
        private System.Windows.Forms.Button buttonWczytajBaze;
        private System.Windows.Forms.Panel toppanel2;
        private System.Windows.Forms.Button minimalizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelGodzina;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button buttonWyjscie;
        private System.Windows.Forms.Button buttonUstawienia;
        private System.Windows.Forms.Button buttonHistoria;
        private System.Windows.Forms.Button buttonRobienieLaku;
        private System.Windows.Forms.Timer timer;
    }
}