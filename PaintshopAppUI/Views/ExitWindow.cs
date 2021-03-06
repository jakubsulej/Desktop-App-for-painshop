﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PaintshopAppUI.Views
{
    public partial class ExitWindow : Form
    {
        int mov;
        int movX;
        int movY;

        public ExitWindow()
        {
            InitializeComponent();
            System.Media.SystemSounds.Beep.Play();
        }

        private void buttonYesExitWindow_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonCancelExitWIndow_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
