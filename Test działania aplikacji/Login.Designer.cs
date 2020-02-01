namespace Test_działania_aplikacji
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelNazwaUzytkownika = new System.Windows.Forms.Label();
            this.labelHaslo = new System.Windows.Forms.Label();
            this.buttonLoginCancel = new System.Windows.Forms.Button();
            this.panelLoginTop = new System.Windows.Forms.Panel();
            this.minimalizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panelLoginTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 169);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // buttonLogin
            // 
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Location = new System.Drawing.Point(267, 257);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(122, 45);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Zaloguj";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelNazwaUzytkownika
            // 
            this.labelNazwaUzytkownika.AutoSize = true;
            this.labelNazwaUzytkownika.Location = new System.Drawing.Point(90, 121);
            this.labelNazwaUzytkownika.Name = "labelNazwaUzytkownika";
            this.labelNazwaUzytkownika.Size = new System.Drawing.Size(102, 13);
            this.labelNazwaUzytkownika.TabIndex = 3;
            this.labelNazwaUzytkownika.Text = "Nazwa użytkownika";
            // 
            // labelHaslo
            // 
            this.labelHaslo.AutoSize = true;
            this.labelHaslo.Location = new System.Drawing.Point(90, 169);
            this.labelHaslo.Name = "labelHaslo";
            this.labelHaslo.Size = new System.Drawing.Size(36, 13);
            this.labelHaslo.TabIndex = 4;
            this.labelHaslo.Text = "Hasło";
            // 
            // buttonLoginCancel
            // 
            this.buttonLoginCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginCancel.Location = new System.Drawing.Point(117, 257);
            this.buttonLoginCancel.Name = "buttonLoginCancel";
            this.buttonLoginCancel.Size = new System.Drawing.Size(122, 45);
            this.buttonLoginCancel.TabIndex = 5;
            this.buttonLoginCancel.Text = "Anuluj";
            this.buttonLoginCancel.UseVisualStyleBackColor = true;
            this.buttonLoginCancel.Click += new System.EventHandler(this.buttonLoginCancel_Click);
            // 
            // panelLoginTop
            // 
            this.panelLoginTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelLoginTop.Controls.Add(this.minimalizeButton);
            this.panelLoginTop.Controls.Add(this.closeButton);
            this.panelLoginTop.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelLoginTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoginTop.Location = new System.Drawing.Point(0, 0);
            this.panelLoginTop.Name = "panelLoginTop";
            this.panelLoginTop.Size = new System.Drawing.Size(523, 31);
            this.panelLoginTop.TabIndex = 6;
            // 
            // minimalizeButton
            // 
            this.minimalizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimalizeButton.FlatAppearance.BorderSize = 0;
            this.minimalizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.minimalizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimalizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimalizeButton.Image")));
            this.minimalizeButton.Location = new System.Drawing.Point(470, 0);
            this.minimalizeButton.Name = "minimalizeButton";
            this.minimalizeButton.Size = new System.Drawing.Size(22, 31);
            this.minimalizeButton.TabIndex = 8;
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
            this.closeButton.Location = new System.Drawing.Point(498, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(22, 31);
            this.closeButton.TabIndex = 7;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 389);
            this.ControlBox = false;
            this.Controls.Add(this.panelLoginTop);
            this.Controls.Add(this.buttonLoginCancel);
            this.Controls.Add(this.labelHaslo);
            this.Controls.Add(this.labelNazwaUzytkownika);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelLoginTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelNazwaUzytkownika;
        private System.Windows.Forms.Label labelHaslo;
        private System.Windows.Forms.Button buttonLoginCancel;
        private System.Windows.Forms.Panel panelLoginTop;
        private System.Windows.Forms.Button minimalizeButton;
        private System.Windows.Forms.Button closeButton;
    }
}