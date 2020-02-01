namespace Test_działania_aplikacji
{
    partial class MenuGlowne
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGlowne));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toppanel3 = new System.Windows.Forms.Panel();
            this.labelGodzina = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.buttonWyjscie = new System.Windows.Forms.Button();
            this.buttonUstawienia = new System.Windows.Forms.Button();
            this.buttonHistoria = new System.Windows.Forms.Button();
            this.buttonRobienieLaku = new System.Windows.Forms.Button();
            this.toppanel2 = new System.Windows.Forms.Panel();
            this.minimalizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonPermutexQuantity = new System.Windows.Forms.Button();
            this.buttonSipiolQuantity = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.toppanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.toppanel3);
            this.panel1.Controls.Add(this.labelGodzina);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.buttonWyjscie);
            this.panel1.Controls.Add(this.buttonUstawienia);
            this.panel1.Controls.Add(this.buttonHistoria);
            this.panel1.Controls.Add(this.buttonRobienieLaku);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 570);
            this.panel1.TabIndex = 0;
            // 
            // toppanel3
            // 
            this.toppanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.toppanel3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.toppanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel3.Location = new System.Drawing.Point(0, 0);
            this.toppanel3.Name = "toppanel3";
            this.toppanel3.Size = new System.Drawing.Size(230, 31);
            this.toppanel3.TabIndex = 5;
            this.toppanel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toppanel3_MouseDown);
            this.toppanel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toppanel3_MouseMove);
            this.toppanel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toppanel3_MouseUp);
            // 
            // labelGodzina
            // 
            this.labelGodzina.AutoSize = true;
            this.labelGodzina.BackColor = System.Drawing.Color.Transparent;
            this.labelGodzina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGodzina.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGodzina.Location = new System.Drawing.Point(37, 528);
            this.labelGodzina.Name = "labelGodzina";
            this.labelGodzina.Size = new System.Drawing.Size(61, 17);
            this.labelGodzina.TabIndex = 7;
            this.labelGodzina.Text = "Godzina";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.SidePanel.Location = new System.Drawing.Point(3, 51);
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
            this.buttonWyjscie.Location = new System.Drawing.Point(13, 234);
            this.buttonWyjscie.Name = "buttonWyjscie";
            this.buttonWyjscie.Size = new System.Drawing.Size(217, 55);
            this.buttonWyjscie.TabIndex = 3;
            this.buttonWyjscie.Text = "          Wyjście";
            this.buttonWyjscie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWyjscie.UseVisualStyleBackColor = true;
            this.buttonWyjscie.Click += new System.EventHandler(this.ButtonWyjscie_Click);
            // 
            // buttonUstawienia
            // 
            this.buttonUstawienia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.buttonUstawienia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUstawienia.FlatAppearance.BorderSize = 0;
            this.buttonUstawienia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUstawienia.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.buttonUstawienia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonUstawienia.Location = new System.Drawing.Point(13, 173);
            this.buttonUstawienia.Name = "buttonUstawienia";
            this.buttonUstawienia.Size = new System.Drawing.Size(217, 55);
            this.buttonUstawienia.TabIndex = 2;
            this.buttonUstawienia.Text = "          Ustawienia";
            this.buttonUstawienia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUstawienia.UseVisualStyleBackColor = false;
            this.buttonUstawienia.Click += new System.EventHandler(this.ButtonUstawienia_Click);
            // 
            // buttonHistoria
            // 
            this.buttonHistoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHistoria.FlatAppearance.BorderSize = 0;
            this.buttonHistoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistoria.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.buttonHistoria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonHistoria.Location = new System.Drawing.Point(13, 112);
            this.buttonHistoria.Name = "buttonHistoria";
            this.buttonHistoria.Size = new System.Drawing.Size(217, 55);
            this.buttonHistoria.TabIndex = 1;
            this.buttonHistoria.Text = "          Historia";
            this.buttonHistoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHistoria.UseVisualStyleBackColor = true;
            this.buttonHistoria.Click += new System.EventHandler(this.ButtonHistoria_Click);
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
            this.buttonRobienieLaku.Location = new System.Drawing.Point(13, 51);
            this.buttonRobienieLaku.Name = "buttonRobienieLaku";
            this.buttonRobienieLaku.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonRobienieLaku.Size = new System.Drawing.Size(217, 55);
            this.buttonRobienieLaku.TabIndex = 0;
            this.buttonRobienieLaku.Text = "          Zrób lakier";
            this.buttonRobienieLaku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRobienieLaku.UseVisualStyleBackColor = false;
            this.buttonRobienieLaku.Click += new System.EventHandler(this.ButtonRobienieLaku_Click);
            // 
            // toppanel2
            // 
            this.toppanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.toppanel2.Controls.Add(this.minimalizeButton);
            this.toppanel2.Controls.Add(this.closeButton);
            this.toppanel2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.toppanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel2.Location = new System.Drawing.Point(230, 0);
            this.toppanel2.Name = "toppanel2";
            this.toppanel2.Size = new System.Drawing.Size(758, 31);
            this.toppanel2.TabIndex = 4;
            this.toppanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toppanel2_MouseDown);
            this.toppanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toppanel2_MouseMove);
            this.toppanel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toppanel2_MouseUp);
            // 
            // minimalizeButton
            // 
            this.minimalizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimalizeButton.FlatAppearance.BorderSize = 0;
            this.minimalizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.minimalizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimalizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimalizeButton.Image")));
            this.minimalizeButton.Location = new System.Drawing.Point(705, 0);
            this.minimalizeButton.Name = "minimalizeButton";
            this.minimalizeButton.Size = new System.Drawing.Size(22, 31);
            this.minimalizeButton.TabIndex = 1;
            this.minimalizeButton.UseVisualStyleBackColor = true;
            this.minimalizeButton.Click += new System.EventHandler(this.MinimalizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(733, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(22, 31);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.buttonPermutexQuantity);
            this.panel4.Controls.Add(this.buttonSipiolQuantity);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(230, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(758, 539);
            this.panel4.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(599, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 95);
            this.button6.TabIndex = 16;
            this.button6.Text = "Metakustik";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(487, 41);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 95);
            this.button5.TabIndex = 15;
            this.button5.Text = "Canada";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(375, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 95);
            this.button4.TabIndex = 14;
            this.button4.Text = "Resilon Plus Matt";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(263, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 95);
            this.button3.TabIndex = 13;
            this.button3.Text = "Resilon";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonPermutexQuantity
            // 
            this.buttonPermutexQuantity.Location = new System.Drawing.Point(151, 41);
            this.buttonPermutexQuantity.Name = "buttonPermutexQuantity";
            this.buttonPermutexQuantity.Size = new System.Drawing.Size(106, 95);
            this.buttonPermutexQuantity.TabIndex = 12;
            this.buttonPermutexQuantity.Text = "Permutex";
            this.buttonPermutexQuantity.UseVisualStyleBackColor = true;
            this.buttonPermutexQuantity.Click += new System.EventHandler(this.buttonPermutexQuantity_Click);
            // 
            // buttonSipiolQuantity
            // 
            this.buttonSipiolQuantity.Location = new System.Drawing.Point(39, 41);
            this.buttonSipiolQuantity.Name = "buttonSipiolQuantity";
            this.buttonSipiolQuantity.Size = new System.Drawing.Size(106, 95);
            this.buttonSipiolQuantity.TabIndex = 11;
            this.buttonSipiolQuantity.Text = "Sipiol";
            this.buttonSipiolQuantity.UseVisualStyleBackColor = true;
            this.buttonSipiolQuantity.Click += new System.EventHandler(this.buttonSipiolQuantity_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MenuGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 570);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.toppanel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuGlowne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toppanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonWyjscie;
        private System.Windows.Forms.Button buttonUstawienia;
        private System.Windows.Forms.Button buttonHistoria;
        private System.Windows.Forms.Button buttonRobienieLaku;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel toppanel2;
        private System.Windows.Forms.Panel toppanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimalizeButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonPermutexQuantity;
        private System.Windows.Forms.Button buttonSipiolQuantity;
        private System.Windows.Forms.Label labelGodzina;
        private System.Windows.Forms.Timer timer;
    }
}

