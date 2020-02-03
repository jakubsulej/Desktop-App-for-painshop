namespace Test_działania_aplikacji
{
    partial class HistoriaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoriaForm));
            this.listViewHistoria = new System.Windows.Forms.ListView();
            this.IloscLaku = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Godzina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Uzytkownik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RodzajLakieru = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.minimalizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.toppanel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelGodzina = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.buttonWyjscie = new System.Windows.Forms.Button();
            this.buttonUstawienia = new System.Windows.Forms.Button();
            this.buttonHistoria = new System.Windows.Forms.Button();
            this.buttonRobienieLaku = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTestListy = new System.Windows.Forms.Label();
            this.buttonUsuwanieWierszaHistorii = new System.Windows.Forms.Button();
            this.toppanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewHistoria
            // 
            this.listViewHistoria.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IloscLaku,
            this.Godzina,
            this.Uzytkownik,
            this.RodzajLakieru,
            this.Data});
            this.listViewHistoria.HideSelection = false;
            this.listViewHistoria.Location = new System.Drawing.Point(244, 49);
            this.listViewHistoria.Name = "listViewHistoria";
            this.listViewHistoria.Size = new System.Drawing.Size(700, 354);
            this.listViewHistoria.TabIndex = 0;
            this.listViewHistoria.UseCompatibleStateImageBehavior = false;
            this.listViewHistoria.View = System.Windows.Forms.View.Details;
            // 
            // IloscLaku
            // 
            this.IloscLaku.Text = "Ilosc laku";
            this.IloscLaku.Width = 119;
            // 
            // Godzina
            // 
            this.Godzina.Text = "Godzina";
            this.Godzina.Width = 116;
            // 
            // Uzytkownik
            // 
            this.Uzytkownik.Text = "Użytkownik";
            this.Uzytkownik.Width = 139;
            // 
            // RodzajLakieru
            // 
            this.RodzajLakieru.Text = "Rodzaj lakieru";
            this.RodzajLakieru.Width = 141;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 145;
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
            this.toppanel2.TabIndex = 7;
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
            this.panel1.TabIndex = 8;
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
            this.SidePanel.Location = new System.Drawing.Point(3, 79);
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
            this.buttonUstawienia.Click += new System.EventHandler(this.buttonUstawienia_Click);
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
            // labelTestListy
            // 
            this.labelTestListy.AutoSize = true;
            this.labelTestListy.Location = new System.Drawing.Point(295, 485);
            this.labelTestListy.Name = "labelTestListy";
            this.labelTestListy.Size = new System.Drawing.Size(35, 13);
            this.labelTestListy.TabIndex = 9;
            this.labelTestListy.Text = "label1";
            // 
            // buttonUsuwanieWierszaHistorii
            // 
            this.buttonUsuwanieWierszaHistorii.Location = new System.Drawing.Point(244, 427);
            this.buttonUsuwanieWierszaHistorii.Name = "buttonUsuwanieWierszaHistorii";
            this.buttonUsuwanieWierszaHistorii.Size = new System.Drawing.Size(105, 31);
            this.buttonUsuwanieWierszaHistorii.TabIndex = 10;
            this.buttonUsuwanieWierszaHistorii.Text = "Usuń wiersz";
            this.buttonUsuwanieWierszaHistorii.UseVisualStyleBackColor = true;
            this.buttonUsuwanieWierszaHistorii.Click += new System.EventHandler(this.buttonUsuwanieHistorii_Click);
            // 
            // HistoriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 570);
            this.Controls.Add(this.buttonUsuwanieWierszaHistorii);
            this.Controls.Add(this.labelTestListy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toppanel2);
            this.Controls.Add(this.listViewHistoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoriaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.HistoriaForm_Load);
            this.toppanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewHistoria;
        private System.Windows.Forms.Button minimalizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel toppanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelGodzina;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button buttonWyjscie;
        private System.Windows.Forms.Button buttonUstawienia;
        private System.Windows.Forms.Button buttonHistoria;
        private System.Windows.Forms.Button buttonRobienieLaku;
        private System.Windows.Forms.ColumnHeader IloscLaku;
        private System.Windows.Forms.ColumnHeader Godzina;
        private System.Windows.Forms.ColumnHeader Uzytkownik;
        private System.Windows.Forms.ColumnHeader RodzajLakieru;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelTestListy;
        private System.Windows.Forms.Button buttonUsuwanieWierszaHistorii;
    }
}