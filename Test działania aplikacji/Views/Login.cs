using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Paint_shop_app;
using Dapper;
using DataAccessLibrary.Models;
using DataAccessLibrary.DataAccess;
using static DataAccessLibrary.Tools;

namespace PaintshopAppUI.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            textBoxUserPassword.PasswordChar = '*';
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginDataAccess db = new LoginDataAccess();

            db.GetLogin(textBoxUserName.Text.Trim(), textBoxUserPassword.Text.Trim());

            if (LoginDataAccess.loginOutput == true)
            {
                db.SaveCurrentUser();

                MainForm objMenuGlowne = new MainForm();
                this.Hide();
                objMenuGlowne.Show();
            }
            else
            {
                MessageBox.Show("Check username or password");
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e) //Użycie buttona logowania za pomocą klawisza enter
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(this, new EventArgs());
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoginDataAccess db = new LoginDataAccess();

            db.CheckCurrentUser();

            if (LoginDataAccess.isCurrentUserLogged == true)
            {
                db.DeleteOldUser();
            }
            else
            {
                labelHiddenUser.Text = "0";
            }
        }        
        
        private void buttonLoginCancel_Click(object sender, EventArgs e) //Zamknięcie okna
        {
            Close();
        }

        private void minimalizeButton_Click(object sender, EventArgs e) //Minimalizacja okna
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e) //Zamknięcie okna
        {
            Close();
        }
    }

}

