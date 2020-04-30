using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using DataAccessLibrary.DataAccess;

namespace PaintshopAppUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int mov;
        int movX;
        int movY;

        public bool userAdminAccessPersmission;

        public void CheckCurrentUserPermission()
        {
            CurrentUserDataAccess db = new CurrentUserDataAccess();

            db.GetLoggedUser();

            if (CurrentUserDataAccess.loggedUserRole.Trim() == "admin")
            {
                userAdminAccessPersmission = true;
            }
            else
            {
                userAdminAccessPersmission = false;
            }
        }

        private void ButtonHistoria_Click(object sender, EventArgs e)
        {
            CheckCurrentUserPermission();

            if(userAdminAccessPersmission == true)
            {
                this.Hide();
                var form2 = new LackHistoryForm();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("You dont have admin permission");
            }
        }

        private void ButtonUstawienia_Click(object sender, EventArgs e)
        {
            CheckCurrentUserPermission();

            if (userAdminAccessPersmission == true)
            {
                this.Hide();
                var form2 = new SettingForm();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("You dont have admin permission");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer.Start();
            labelCurrentTime.Text = DateTime.Now.ToLongTimeString();
            CoatACount.Hide();
            CoatBCount1.Hide();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelCurrentTime.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            new ExitWindow().Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            new ExitWindow().Show();
        }

        private void MinimalizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonCoatBQuantity_Click(object sender, EventArgs e)
        {
            CoatBCount1.Show();
            CoatACount.Hide();
            resilonCount1.Hide();
            resilonPlus1.Hide();
        }

        private void buttonCoatAQuantity_Click(object sender, EventArgs e)
        {
            CoatACount.Show();
            CoatBCount1.Hide();
            resilonCount1.Hide();
            resilonPlus1.Hide();
        }

        private void buttonResilon_Click(object sender, EventArgs e)
        {
            resilonCount1.Show();
            resilonPlus1.Hide();
            CoatACount.Hide();
            CoatBCount1.Hide();
        }

        private void buttonResilonPlus_Click(object sender, EventArgs e)
        {
            resilonPlus1.Show();
            resilonCount1.Hide();
            CoatACount.Hide();
            CoatBCount1.Hide();
        }

        private void toppanel2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void toppanel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void toppanel2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void toppanel3_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void toppanel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void toppanel3_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void buttonCoatAQuantity_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(167, 167, 167);
            panel3.BackColor = Color.FromArgb(255, 255, 255);
            panel5.BackColor = Color.FromArgb(255, 255, 255);
            panel6.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void buttonCoatBQuantity_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            panel3.BackColor = Color.FromArgb(167, 167, 167);
            panel5.BackColor = Color.FromArgb(255, 255, 255);
            panel6.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void buttonResilonQuantity_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            panel3.BackColor = Color.FromArgb(255, 255, 255);
            panel5.BackColor = Color.FromArgb(167, 167, 167);
            panel6.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void buttonResilonPlus_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            panel3.BackColor = Color.FromArgb(255, 255, 255);
            panel5.BackColor = Color.FromArgb(255, 255, 255);
            panel6.BackColor = Color.FromArgb(167, 167, 167);
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            panel3.BackColor = Color.FromArgb(255, 255, 255);
            panel5.BackColor = Color.FromArgb(255, 255, 255);
            panel6.BackColor = Color.FromArgb(255, 255, 255);
        }
    }
}