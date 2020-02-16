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

namespace Test_działania_aplikacji
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            textBoxUserPassword.PasswordChar = '*';
        }

        private int isOldUserInDatabase;

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

        private void checkCurrentUser(object sender, EventArgs e) //Aktualny user w tabeli do String
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            string aktualnieZalogowanyUser;

            {
                SqlCommand cmd = new SqlCommand("select UZYTKOWNIK from ZALOGOWANYUZYTKOWNIK", con);
                con.Open();

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

        private void logowanieDoSystemu(object sender, EventArgs e) //Metoda logowania usera do systemu
        {
            SqlConnection polaczenie = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            String query = "Select Role from Login Where Uzytkownik = '" + textBoxUserName.Text.Trim() + "' and Haslo = '" + textBoxUserPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, polaczenie);
            DataTable tabelaDanych = new DataTable();
            sda.Fill(tabelaDanych);

            if (tabelaDanych.Rows.Count == 1)
            {
                MenuGlowne objMenuGlowne = new MenuGlowne();
                this.Hide();
                objMenuGlowne.Show();

                String zalogowanyUzytkownik = (tabelaDanych.Rows[0][0]).ToString(); //String pobierający dane z kolumny Role z tabeli Login

                // -------------ZAPISYWANIE TYMCZASOWYCH DANYCH O ZALOGOWANYM UZYTKOWNIKU----------------
                string sql = "Insert into Zalogowanyuzytkownik ([UZYTKOWNIK], [ADMIN]) values(@Uzytkownik,@Admin)";
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, polaczenie))
                        {
                            cmd.Parameters.AddWithValue("@Uzytkownik", textBoxUserName.Text);
                            cmd.Parameters.AddWithValue("@Admin", zalogowanyUzytkownik);

                            polaczenie.Open();
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
            SqlConnection polaczenie = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            string sql = "Delete from ZALOGOWANYUZYTKOWNIK";
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, polaczenie))
                    {
                        polaczenie.Open();
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
                logowanieDoSystemu(null, null);
            }
            else
            {
                deleteOldUserDataBase(null, null);
                logowanieDoSystemu(null, null);
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
            checkCurrentUser(null, null);
            labelHiddenUser.Text = isOldUserInDatabase.ToString();
        }
    }
}

