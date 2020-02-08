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
            textBox2.PasswordChar = '*';
        }

        new String aktualnieZalogowanyUser;

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

            {
                SqlCommand cmd = new SqlCommand("select UZYTKOWNIK from ZALOGOWANYUZYTKOWNIK", con);
                con.Open();

                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    aktualnieZalogowanyUser = (read["Uzytkownik"].ToString().Trim());
                    label1.Text = "Aktualnie zalogowany: " + aktualnieZalogowanyUser;
                }
                read.Close();

            }
        }

        private void logowanieDoSystemu(object sender, EventArgs e)
        {
            SqlConnection polaczenie = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");


        }

        private void buttonLogin_Click(object sender, EventArgs e) //Logowanie do menu głównego - Do ogarnięcia uporządkowanie w metody //DO ZROBIENIA == USUWANIE ISTNIEJACEJ BAZY JESLI ISTNIEJE
        {
            SqlConnection polaczenie = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            if (aktualnieZalogowanyUser == null) //Sprawdzanie czy tabela Zalogowanyuzytkownik jest pusta
            {
                String query = "Select Role from Login Where Uzytkownik = '" + textBox1.Text.Trim() + "' and Haslo = '" + textBox2.Text.Trim() + "'";
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
                                cmd.Parameters.AddWithValue("@Uzytkownik", textBox1.Text);
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
            else
            {
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
            checkCurrentUser(null, null); //label do sprawdzania, czy baza danych jest pusta <=== Nie działa
        }
    }
}

