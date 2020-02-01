namespace Test_działania_aplikacji
{
    partial class ExitWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitWindow));
            this.buttonYesExitWindow = new System.Windows.Forms.Button();
            this.buttonCancelExitWIndow = new System.Windows.Forms.Button();
            this.panelExitWindow = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.panelExitWindow.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonYesExitWindow
            // 
            this.buttonYesExitWindow.Location = new System.Drawing.Point(180, 132);
            this.buttonYesExitWindow.Name = "buttonYesExitWindow";
            this.buttonYesExitWindow.Size = new System.Drawing.Size(129, 48);
            this.buttonYesExitWindow.TabIndex = 0;
            this.buttonYesExitWindow.Text = "Wyjście";
            this.buttonYesExitWindow.UseVisualStyleBackColor = true;
            this.buttonYesExitWindow.Click += new System.EventHandler(this.buttonYesExitWindow_Click);
            // 
            // buttonCancelExitWIndow
            // 
            this.buttonCancelExitWIndow.Location = new System.Drawing.Point(26, 132);
            this.buttonCancelExitWIndow.Name = "buttonCancelExitWIndow";
            this.buttonCancelExitWIndow.Size = new System.Drawing.Size(129, 48);
            this.buttonCancelExitWIndow.TabIndex = 1;
            this.buttonCancelExitWIndow.Text = "Anuluj";
            this.buttonCancelExitWIndow.UseVisualStyleBackColor = true;
            this.buttonCancelExitWIndow.Click += new System.EventHandler(this.buttonCancelExitWIndow_Click);
            // 
            // panelExitWindow
            // 
            this.panelExitWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panelExitWindow.Controls.Add(this.panel1);
            this.panelExitWindow.Controls.Add(this.buttonCancelExitWIndow);
            this.panelExitWindow.Controls.Add(this.buttonYesExitWindow);
            this.panelExitWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExitWindow.Location = new System.Drawing.Point(0, 0);
            this.panelExitWindow.Name = "panelExitWindow";
            this.panelExitWindow.Size = new System.Drawing.Size(337, 214);
            this.panelExitWindow.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 31);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(312, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(22, 31);
            this.closeButton.TabIndex = 4;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ExitWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 213);
            this.Controls.Add(this.panelExitWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExitWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExitWindow";
            this.panelExitWindow.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonYesExitWindow;
        private System.Windows.Forms.Button buttonCancelExitWIndow;
        private System.Windows.Forms.Panel panelExitWindow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
    }
}