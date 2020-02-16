namespace Test_działania_aplikacji
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.IloscLaku = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Godzina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Uzytkownik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RodzajLakieru = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.minimalizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.toppanel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonMakeCoat = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonDeleteRow = new System.Windows.Forms.Button();
            this.buttonDeleteLast7Days = new System.Windows.Forms.Button();
            this.buttonSafeAsCSV = new System.Windows.Forms.Button();
            this.toppanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewHistory
            // 
            this.listViewHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IloscLaku,
            this.Godzina,
            this.Uzytkownik,
            this.RodzajLakieru,
            this.Data});
            this.listViewHistory.HideSelection = false;
            this.listViewHistory.Location = new System.Drawing.Point(244, 49);
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(732, 354);
            this.listViewHistory.TabIndex = 0;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.Details;
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
            this.panel1.TabIndex = 8;
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
            this.SidePanel.Location = new System.Drawing.Point(3, 79);
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
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
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
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
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
            this.buttonMakeCoat.Click += new System.EventHandler(this.buttonMakeCoat_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonDeleteRow
            // 
            this.buttonDeleteRow.Location = new System.Drawing.Point(244, 427);
            this.buttonDeleteRow.Name = "buttonDeleteRow";
            this.buttonDeleteRow.Size = new System.Drawing.Size(105, 31);
            this.buttonDeleteRow.TabIndex = 10;
            this.buttonDeleteRow.Text = "Usuń wiersz";
            this.buttonDeleteRow.UseVisualStyleBackColor = true;
            this.buttonDeleteRow.Click += new System.EventHandler(this.buttonDeleteHistory_Click);
            // 
            // buttonDeleteLast7Days
            // 
            this.buttonDeleteLast7Days.Location = new System.Drawing.Point(366, 427);
            this.buttonDeleteLast7Days.Name = "buttonDeleteLast7Days";
            this.buttonDeleteLast7Days.Size = new System.Drawing.Size(136, 31);
            this.buttonDeleteLast7Days.TabIndex = 11;
            this.buttonDeleteLast7Days.Text = "Usuń ostatnie 7 dni";
            this.buttonDeleteLast7Days.UseVisualStyleBackColor = true;
            this.buttonDeleteLast7Days.Click += new System.EventHandler(this.buttonUsun7Dni_Click);
            // 
            // buttonSafeAsCSV
            // 
            this.buttonSafeAsCSV.Location = new System.Drawing.Point(523, 427);
            this.buttonSafeAsCSV.Name = "buttonSafeAsCSV";
            this.buttonSafeAsCSV.Size = new System.Drawing.Size(136, 31);
            this.buttonSafeAsCSV.TabIndex = 12;
            this.buttonSafeAsCSV.Text = "Zapisz do CSV";
            this.buttonSafeAsCSV.UseVisualStyleBackColor = true;
            this.buttonSafeAsCSV.Click += new System.EventHandler(this.buttonZapiszCSV_Click);
            // 
            // HistoriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 570);
            this.Controls.Add(this.buttonSafeAsCSV);
            this.Controls.Add(this.buttonDeleteLast7Days);
            this.Controls.Add(this.buttonDeleteRow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toppanel2);
            this.Controls.Add(this.listViewHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoriaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.HistoriaForm_Load);
            this.toppanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewHistory;
        private System.Windows.Forms.Button minimalizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel toppanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonMakeCoat;
        private System.Windows.Forms.ColumnHeader IloscLaku;
        private System.Windows.Forms.ColumnHeader Godzina;
        private System.Windows.Forms.ColumnHeader Uzytkownik;
        private System.Windows.Forms.ColumnHeader RodzajLakieru;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonDeleteRow;
        private System.Windows.Forms.Button buttonDeleteLast7Days;
        private System.Windows.Forms.Button buttonSafeAsCSV;
    }
}