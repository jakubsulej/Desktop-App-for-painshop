﻿namespace Test_działania_aplikacji
{
    partial class CancelRobienieLaku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelRobienieLaku));
            this.buttonCancelCancelRobienieLaku = new System.Windows.Forms.Button();
            this.buttonExitCancelRobienieLaku = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.labelCancelRobienieLaku = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancelCancelRobienieLaku
            // 
            this.buttonCancelCancelRobienieLaku.Location = new System.Drawing.Point(27, 128);
            this.buttonCancelCancelRobienieLaku.Name = "buttonCancelCancelRobienieLaku";
            this.buttonCancelCancelRobienieLaku.Size = new System.Drawing.Size(124, 51);
            this.buttonCancelCancelRobienieLaku.TabIndex = 0;
            this.buttonCancelCancelRobienieLaku.Text = "Anuluj";
            this.buttonCancelCancelRobienieLaku.UseVisualStyleBackColor = true;
            this.buttonCancelCancelRobienieLaku.Click += new System.EventHandler(this.buttonCancelCancelRobienieLaku_Click);
            // 
            // buttonExitCancelRobienieLaku
            // 
            this.buttonExitCancelRobienieLaku.Location = new System.Drawing.Point(202, 128);
            this.buttonExitCancelRobienieLaku.Name = "buttonExitCancelRobienieLaku";
            this.buttonExitCancelRobienieLaku.Size = new System.Drawing.Size(124, 51);
            this.buttonExitCancelRobienieLaku.TabIndex = 1;
            this.buttonExitCancelRobienieLaku.Text = "Zakończ";
            this.buttonExitCancelRobienieLaku.UseVisualStyleBackColor = true;
            this.buttonExitCancelRobienieLaku.Click += new System.EventHandler(this.buttonExitCancelRobienieLaku_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.labelCancelRobienieLaku);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonCancelCancelRobienieLaku);
            this.panel1.Controls.Add(this.buttonExitCancelRobienieLaku);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 213);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 31);
            this.panel2.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(324, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(22, 31);
            this.closeButton.TabIndex = 3;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // labelCancelRobienieLaku
            // 
            this.labelCancelRobienieLaku.AutoSize = true;
            this.labelCancelRobienieLaku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCancelRobienieLaku.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCancelRobienieLaku.Location = new System.Drawing.Point(37, 69);
            this.labelCancelRobienieLaku.Name = "labelCancelRobienieLaku";
            this.labelCancelRobienieLaku.Size = new System.Drawing.Size(278, 30);
            this.labelCancelRobienieLaku.TabIndex = 3;
            this.labelCancelRobienieLaku.Text = "Czy na pewno chcesz zakończyć robienie lakieru?\r\nNiezapisane postęy zostaną utrac" +
    "one.";
            // 
            // CancelRobienieLaku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 213);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CancelRobienieLaku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelRobienieLaku";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelCancelRobienieLaku;
        private System.Windows.Forms.Button buttonExitCancelRobienieLaku;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label labelCancelRobienieLaku;
    }
}