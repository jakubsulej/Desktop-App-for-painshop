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

        string pastLogedUser;
        string currentLoggedUser;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");


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
            {
                SqlCommand cmd = new SqlCommand("select UZYTKOWNIK from ZALOGOWANYUZYTKOWNIK", connection);
                connection.Open();

                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    pastLogedUser = (read["Uzytkownik"].ToString().Trim());
                }
                read.Close();

            }
        }

        private void userLoginToSystem(object sender, EventArgs e) //Metoda logowania usera do systemu
        {
            String sqlQuerry = "Select Role from Login Where Uzytkownik = '" + textBoxUserName.Text.Trim() + "' and Haslo = '" + textBoxUserPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlQuerry, connection);
            DataTable userDataTable = new DataTable();
            sda.Fill(userDataTable);

            if (userDataTable.Rows.Count == 1)
            {
                MenuGlowne objMenuGlowne = new MenuGlowne();
                this.Hide();
                objMenuGlowne.Show();

                currentLoggedUser = (userDataTable.Rows[0][0]).ToString(); //String pobierający dane z kolumny Role z tabeli Login

                // -------------ZAPISYWANIE TYMCZASOWYCH DANYCH O ZALOGOWANYM UZYTKOWNIKU----------------
                string sql = "Insert into Zalogowanyuzytkownik ([UZYTKOWNIK], [ADMIN]) values(@Uzytkownik,@Admin)";
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, connection))
                        {
                            cmd.Parameters.AddWithValue("@Uzytkownik", textBoxUserName.Text);
                            cmd.Parameters.AddWithValue("@Admin", currentLoggedUser);

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

        private void saveCurrentLoggedUser(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e) //Logowanie do menu głównego
        {
            if (pastLogedUser == null)
            {
                userLoginToSystem(null, null);
            }
            else
            {
                deleteCurrentLoggedUser(null, null);
                userLoginToSystem(null, null);
            }
        }

        private void deleteCurrentLoggedUser(object sender, EventArgs e) //Usuwanie 
        {
            string sql = "Delete from ZALOGOWANYUZYTKOWNIK";
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
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

        private void textBox2_KeyDown(object sender, KeyEventArgs e) //Użycie buttona logowania za pomocą klawisza enter
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(this, new EventArgs());
            }
        }
    }
}

