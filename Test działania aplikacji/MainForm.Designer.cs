namespace PaintshopAppUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toppanel3 = new System.Windows.Forms.Panel();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.buttonMenuExit = new System.Windows.Forms.Button();
            this.buttonMenuSettings = new System.Windows.Forms.Button();
            this.buttonMenuHistory = new System.Windows.Forms.Button();
            this.buttonMenuMakeCoat = new System.Windows.Forms.Button();
            this.toppanel2 = new System.Windows.Forms.Panel();
            this.minimalizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.greyLine = new System.Windows.Forms.Panel();
            this.buttonResilonPlus = new System.Windows.Forms.Button();
            this.buttonSipiolQuantity = new System.Windows.Forms.Button();
            this.buttonPermutexQuantity = new System.Windows.Forms.Button();
            this.buttonResilonQuantity = new System.Windows.Forms.Button();
            this.CoatACount = new PaintshopAppUI.CoatACount();
            this.CoatBCount1 = new PaintshopAppUI.CoatBCount();
            this.resilonPlus1 = new PaintshopAppUI.ResilonPlusCount();
            this.resilonCount1 = new PaintshopAppUI.ResilonCount();
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
            this.panel1.Controls.Add(this.labelCurrentTime);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.buttonMenuExit);
            this.panel1.Controls.Add(this.buttonMenuSettings);
            this.panel1.Controls.Add(this.buttonMenuHistory);
            this.panel1.Controls.Add(this.buttonMenuMakeCoat);
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
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentTime.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCurrentTime.Location = new System.Drawing.Point(37, 528);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(39, 17);
            this.labelCurrentTime.TabIndex = 7;
            this.labelCurrentTime.Text = "Time";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.SidePanel.Location = new System.Drawing.Point(3, 51);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 55);
            this.SidePanel.TabIndex = 4;
            // 
            // buttonMenuExit
            // 
            this.buttonMenuExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenuExit.FlatAppearance.BorderSize = 0;
            this.buttonMenuExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuExit.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.buttonMenuExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMenuExit.Location = new System.Drawing.Point(13, 234);
            this.buttonMenuExit.Name = "buttonMenuExit";
            this.buttonMenuExit.Size = new System.Drawing.Size(217, 55);
            this.buttonMenuExit.TabIndex = 3;
            this.buttonMenuExit.Text = "          Exit";
            this.buttonMenuExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenuExit.UseVisualStyleBackColor = true;
            this.buttonMenuExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonMenuSettings
            // 
            this.buttonMenuSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.buttonMenuSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenuSettings.FlatAppearance.BorderSize = 0;
            this.buttonMenuSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuSettings.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.buttonMenuSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMenuSettings.Location = new System.Drawing.Point(13, 173);
            this.buttonMenuSettings.Name = "buttonMenuSettings";
            this.buttonMenuSettings.Size = new System.Drawing.Size(217, 55);
            this.buttonMenuSettings.TabIndex = 2;
            this.buttonMenuSettings.Text = "          Settings";
            this.buttonMenuSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenuSettings.UseVisualStyleBackColor = false;
            this.buttonMenuSettings.Click += new System.EventHandler(this.ButtonUstawienia_Click);
            // 
            // buttonMenuHistory
            // 
            this.buttonMenuHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenuHistory.FlatAppearance.BorderSize = 0;
            this.buttonMenuHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuHistory.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.buttonMenuHistory.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMenuHistory.Location = new System.Drawing.Point(13, 112);
            this.buttonMenuHistory.Name = "buttonMenuHistory";
            this.buttonMenuHistory.Size = new System.Drawing.Size(217, 55);
            this.buttonMenuHistory.TabIndex = 1;
            this.buttonMenuHistory.Text = "          History";
            this.buttonMenuHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenuHistory.UseVisualStyleBackColor = true;
            this.buttonMenuHistory.Click += new System.EventHandler(this.ButtonHistoria_Click);
            // 
            // buttonMenuMakeCoat
            // 
            this.buttonMenuMakeCoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.buttonMenuMakeCoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenuMakeCoat.FlatAppearance.BorderSize = 0;
            this.buttonMenuMakeCoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuMakeCoat.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuMakeCoat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMenuMakeCoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenuMakeCoat.Location = new System.Drawing.Point(13, 51);
            this.buttonMenuMakeCoat.Name = "buttonMenuMakeCoat";
            this.buttonMenuMakeCoat.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonMenuMakeCoat.Size = new System.Drawing.Size(217, 55);
            this.buttonMenuMakeCoat.TabIndex = 0;
            this.buttonMenuMakeCoat.Text = "      Make coat";
            this.buttonMenuMakeCoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenuMakeCoat.UseVisualStyleBackColor = false;
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
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.greyLine);
            this.panel4.Controls.Add(this.buttonResilonPlus);
            this.panel4.Controls.Add(this.buttonSipiolQuantity);
            this.panel4.Controls.Add(this.buttonPermutexQuantity);
            this.panel4.Controls.Add(this.buttonResilonQuantity);
            this.panel4.Controls.Add(this.CoatACount);
            this.panel4.Controls.Add(this.CoatBCount1);
            this.panel4.Controls.Add(this.resilonPlus1);
            this.panel4.Controls.Add(this.resilonCount1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(230, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(758, 539);
            this.panel4.TabIndex = 5;
            this.panel4.MouseHover += new System.EventHandler(this.panel4_MouseHover);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Location = new System.Drawing.Point(518, 65);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(159, 2);
            this.panel6.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Location = new System.Drawing.Point(348, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(133, 2);
            this.panel5.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(179, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 2);
            this.panel3.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(9, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 2);
            this.panel2.TabIndex = 22;
            // 
            // greyLine
            // 
            this.greyLine.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.greyLine.Location = new System.Drawing.Point(0, 80);
            this.greyLine.Name = "greyLine";
            this.greyLine.Size = new System.Drawing.Size(758, 1);
            this.greyLine.TabIndex = 21;
            // 
            // buttonResilonPlus
            // 
            this.buttonResilonPlus.FlatAppearance.BorderSize = 0;
            this.buttonResilonPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonResilonPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonResilonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResilonPlus.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonResilonPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.buttonResilonPlus.Location = new System.Drawing.Point(518, 26);
            this.buttonResilonPlus.Name = "buttonResilonPlus";
            this.buttonResilonPlus.Size = new System.Drawing.Size(159, 39);
            this.buttonResilonPlus.TabIndex = 14;
            this.buttonResilonPlus.Text = "Coat 4";
            this.buttonResilonPlus.UseVisualStyleBackColor = true;
            this.buttonResilonPlus.Click += new System.EventHandler(this.buttonResilonPlus_Click);
            this.buttonResilonPlus.MouseHover += new System.EventHandler(this.buttonResilonPlus_MouseHover);
            // 
            // buttonSipiolQuantity
            // 
            this.buttonSipiolQuantity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSipiolQuantity.FlatAppearance.BorderSize = 0;
            this.buttonSipiolQuantity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSipiolQuantity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSipiolQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSipiolQuantity.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSipiolQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.buttonSipiolQuantity.Location = new System.Drawing.Point(23, 26);
            this.buttonSipiolQuantity.Name = "buttonSipiolQuantity";
            this.buttonSipiolQuantity.Size = new System.Drawing.Size(106, 39);
            this.buttonSipiolQuantity.TabIndex = 11;
            this.buttonSipiolQuantity.Text = "Coat 1";
            this.buttonSipiolQuantity.UseVisualStyleBackColor = true;
            this.buttonSipiolQuantity.Click += new System.EventHandler(this.buttonCoatAQuantity_Click);
            this.buttonSipiolQuantity.MouseHover += new System.EventHandler(this.buttonCoatAQuantity_MouseHover);
            // 
            // buttonPermutexQuantity
            // 
            this.buttonPermutexQuantity.FlatAppearance.BorderSize = 0;
            this.buttonPermutexQuantity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPermutexQuantity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPermutexQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPermutexQuantity.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPermutexQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.buttonPermutexQuantity.Location = new System.Drawing.Point(191, 26);
            this.buttonPermutexQuantity.Name = "buttonPermutexQuantity";
            this.buttonPermutexQuantity.Size = new System.Drawing.Size(106, 39);
            this.buttonPermutexQuantity.TabIndex = 12;
            this.buttonPermutexQuantity.Text = "Coat 2";
            this.buttonPermutexQuantity.UseVisualStyleBackColor = true;
            this.buttonPermutexQuantity.Click += new System.EventHandler(this.buttonCoatBQuantity_Click);
            this.buttonPermutexQuantity.MouseHover += new System.EventHandler(this.buttonCoatBQuantity_MouseHover);
            // 
            // buttonResilonQuantity
            // 
            this.buttonResilonQuantity.FlatAppearance.BorderSize = 0;
            this.buttonResilonQuantity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonResilonQuantity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonResilonQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResilonQuantity.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonResilonQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.buttonResilonQuantity.Location = new System.Drawing.Point(360, 26);
            this.buttonResilonQuantity.Name = "buttonResilonQuantity";
            this.buttonResilonQuantity.Size = new System.Drawing.Size(106, 39);
            this.buttonResilonQuantity.TabIndex = 13;
            this.buttonResilonQuantity.Text = "Coat 3";
            this.buttonResilonQuantity.UseVisualStyleBackColor = true;
            this.buttonResilonQuantity.Click += new System.EventHandler(this.buttonResilon_Click);
            this.buttonResilonQuantity.MouseHover += new System.EventHandler(this.buttonResilonQuantity_MouseHover);
            // 
            // CoatACount
            // 
            this.CoatACount.Location = new System.Drawing.Point(0, 71);
            this.CoatACount.Name = "CoatACount";
            this.CoatACount.Size = new System.Drawing.Size(758, 468);
            this.CoatACount.TabIndex = 17;
            // 
            // CoatBCount1
            // 
            this.CoatBCount1.Location = new System.Drawing.Point(0, 81);
            this.CoatBCount1.Name = "CoatBCount1";
            this.CoatBCount1.Size = new System.Drawing.Size(758, 458);
            this.CoatBCount1.TabIndex = 18;
            // 
            // resilonPlus1
            // 
            this.resilonPlus1.Location = new System.Drawing.Point(0, 71);
            this.resilonPlus1.Name = "resilonPlus1";
            this.resilonPlus1.Size = new System.Drawing.Size(758, 468);
            this.resilonPlus1.TabIndex = 20;
            // 
            // resilonCount1
            // 
            this.resilonCount1.Location = new System.Drawing.Point(0, 71);
            this.resilonCount1.Name = "resilonCount1";
            this.resilonCount1.Size = new System.Drawing.Size(758, 468);
            this.resilonCount1.TabIndex = 19;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 570);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.toppanel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
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
        private System.Windows.Forms.Button buttonMenuExit;
        private System.Windows.Forms.Button buttonMenuSettings;
        private System.Windows.Forms.Button buttonMenuHistory;
        private System.Windows.Forms.Button buttonMenuMakeCoat;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel toppanel2;
        private System.Windows.Forms.Panel toppanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimalizeButton;
        private System.Windows.Forms.Button buttonResilonPlus;
        private System.Windows.Forms.Button buttonResilonQuantity;
        private System.Windows.Forms.Button buttonPermutexQuantity;
        private System.Windows.Forms.Button buttonSipiolQuantity;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Timer timer;
        private CoatACount CoatACount;
        private CoatBCount CoatBCount1;
        private ResilonCount resilonCount1;
        private ResilonPlusCount resilonPlus1;
        private System.Windows.Forms.Panel greyLine;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
    }
}

