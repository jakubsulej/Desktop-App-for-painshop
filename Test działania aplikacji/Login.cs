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

namespace PaintshopAppUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            textBoxUserPassword.PasswordChar = '*';
        }

        private int isOldUserInDatabase;

        private void checkCurrentUser(object sender, EventArgs e) //Aktualny user w tabeli do String
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            string aktualnieZalogowanyUser;

            {
                SqlCommand cmd = new SqlCommand("select UZYTKOWNIK from ZALOGOWANYUZYTKOWNIK", connection);
                connection.Open();

                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    aktualnieZalogowanyUser = (read["Uzytkownik"].ToString().Trim());
                    if (aktualnieZalogowanyUser != null)
                    {
                        isOldUserInDatabase = 1;
                    }
                    else
                    {
                        isOldUserInDatabase = 0;
                    }
                }
                read.Close();

            }
        }

        private void loginToSystem(object sender, EventArgs e) //Metoda logowania usera do systemu
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            String query = "Select Role from Login Where Uzytkownik = '" + textBoxUserName.Text.Trim() + "' and Haslo = '" + textBoxUserPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataTable tabelaDanych = new DataTable();
            sda.Fill(tabelaDanych);

            if (tabelaDanych.Rows.Count == 1)
            {
                MainForm objMenuGlowne = new MainForm();
                this.Hide();
                objMenuGlowne.Show();

                String zalogowanyUzytkownik = (tabelaDanych.Rows[0][0]).ToString(); //String pobierający dane z kolumny Role z tabeli Login

                // -------------ZAPISYWANIE TYMCZASOWYCH DANYCH O ZALOGOWANYM UZYTKOWNIKU----------------
                string sql = "Insert into Zalogowanyuzytkownik ([UZYTKOWNIK], [ADMIN]) values(@Uzytkownik,@Admin)";
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, connection))
                        {
                            cmd.Parameters.AddWithValue("@Uzytkownik", textBoxUserName.Text);
                            cmd.Parameters.AddWithValue("@Admin", zalogowanyUzytkownik);

                            connection.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("BŁĄD:" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Sprawdź nazwę użytkownika i hasło");
            }
        }

        private void deleteOldUserDataBase(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            string sqlUser = "Delete from ZALOGOWANYUZYTKOWNIK";
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sqlUser, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("BŁĄD:" + ex.Message);
                }
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e) //Logowanie do menu głównego - Do ogarnięcia uporządkowanie w metody //DO ZROBIENIA == USUWANIE ISTNIEJACEJ BAZY JESLI ISTNIEJE
        {
            SqlConnection polaczenie = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            if (isOldUserInDatabase == 0) //Sprawdzanie czy tabela Zalogowanyuzytkownik jest pusta
            {
                loginToSystem(null, null);
            }
            else
            {
                deleteOldUserDataBase(null, null);
                loginToSystem(null, null);
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
            DataAccess db = new DataAccess();

            db.CheckCurrentUser();

            if (DataAccess.isCurrentUserLogged == true)
            {
                db.DeleteOldUser();
            }
            else
            {
                labelHiddenUser.Text = "0";
            }
        }        
        
        //---------------Sterowanie oknem-------------------
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

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.GetLogin(textBoxUserName.Text.Trim(),textBoxUserPassword.Text.Trim());

            if (DataAccess.loginOutput == true)
            {
                MessageBox.Show("Hura");
                db.SaveCurrentUser();
            }
            else
            {
                MessageBox.Show("Chuj");
            }
        }
    }

}

