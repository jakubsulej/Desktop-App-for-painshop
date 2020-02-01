using System;
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

namespace Test_działania_aplikacji
{
    public partial class UstawieniaForm : Form
    {

        public UstawieniaForm()
        {
            InitializeComponent();
        }

        private void buttonDodajUzytkownika_Click(object sender, EventArgs e) //Dodawanie nowego użytkownika
        {
            string connetionString = null;
            string sql = null;

            // Linijka połączenia z bazą danych Login
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            sql = "insert into Login ([UZYTKOWNIK], [HASLO], [ROLE]) values(@Uzytkownik,@Haslo,@Role)";

            // Tworzenie połączenia z bazą danych
            {
                try
                {
                    // Otwarcie bazy danych
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        // Dodawanie wartości do bazy danych
                        cmd.Parameters.AddWithValue("@Uzytkownik", textBoxNazwaUzytkownika.Text);
                        cmd.Parameters.AddWithValue("@Haslo", textBoxHasloUzytkownika.Text);
                        cmd.Parameters.AddWithValue("@Role", comboBoxRolaUzytkownika.SelectedItem.ToString());

                        // Wiadomość o dodaniu nowej linijki bazy danych
                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                            MessageBox.Show("Dodano Użytkownika");
                        else
                            MessageBox.Show("Nie dodano Użytkownika");
                    }
                }
                catch (Exception ex)
                {
                    // Wyświetlanie błędów
                    MessageBox.Show("BŁĄD:" + ex.Message);
                }
            }
            listViewUzytkownicy.Items.Clear();
            listViewUzytkownicy.Refresh();
            WczytywanieListView(null, null);
        }

        private void buttonAktualizuj_Click(object sender, EventArgs e) //Aktualizacja danych o użytkowniku w TextBox
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");



            //WIĄZANIE TABEL DANYCH

            string connetionString = null;

            string sql = "Update Login set Haslo=@Haslo, Role=@Role Where Uzytkownik=@Uzytkownik";

            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Uzytkownik", textBoxNazwaUzytkownika.Text);
                        cmd.Parameters.AddWithValue("@Haslo", textBoxHasloUzytkownika.Text);
                        cmd.Parameters.AddWithValue("@Role", comboBoxRolaUzytkownika.SelectedItem.ToString());
                        
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("BŁĄD:" + ex.Message);
                }
            }
            listViewUzytkownicy.Items.Clear();
            listViewUzytkownicy.Refresh();
            WczytywanieListView(null, null);
        }

        private void UstawieniaForm_Load(object sender, EventArgs e) //Ładowanie ListView wartościami bazy danych podczas ładowania okna
        {
            WczytywanieListView(null, null);
            listViewUzytkownicy.View = View.Details;
            listViewUzytkownicy.FullRowSelect = true;

            //URUCHOMIENIE TIMERA DLA GODZINY
            timer.Start();
            labelGodzina.Text = DateTime.Now.ToLongTimeString();
        }

        private void buttonWczytajBaze_Click(object sender, EventArgs e) //Przycisk wymuszenie aktualizacji ListView
        {
            listViewUzytkownicy.Items.Clear();
            listViewUzytkownicy.Refresh();
            WczytywanieListView(null, null);
        }
        public void WczytywanieListView(object sender, EventArgs e) //Metoda zapełniania ListView wartościami z bazy danych LOGIN
        {
            listViewUzytkownicy.GridLines = true;
            listViewUzytkownicy.View = View.Details;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("select * from Login", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["UZYTKOWNIK"].ToString());
                listitem.SubItems.Add(dr["HASLO"].ToString());
                listitem.SubItems.Add(dr["ROLE"].ToString());
                listViewUzytkownicy.Items.Add(listitem);
            }
        }

        private void listViewUzytkownicy_MouseClick(object sender, MouseEventArgs e) //Wybór użytkownika i string do textBox z bazy w ListView
        {
            String uzytkownik = listViewUzytkownicy.SelectedItems[0].SubItems[0].Text;
            String haslo = listViewUzytkownicy.SelectedItems[0].SubItems[1].Text;
            String rola = listViewUzytkownicy.SelectedItems[0].SubItems[2].Text;

            textBoxNazwaUzytkownika.Text = uzytkownik.Trim();
            textBoxHasloUzytkownika.Text = haslo.Trim();

            if (rola.Equals("admin"))
            {
                comboBoxRolaUzytkownika.SelectedIndex = 0;
            }
            if (rola.Equals("user"))
            {
                comboBoxRolaUzytkownika.SelectedIndex = 1;
            }
            else
            {
                comboBoxRolaUzytkownika.SelectedIndex = 0;
            }
        }

        private void buttonUsun_Click(object sender, EventArgs e) //Usuwanie użytkownika.
        {
            string connetionString = null;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            string sql = "Delete from Login Where Uzytkownik=@Uzytkownik";

            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Uzytkownik", textBoxNazwaUzytkownika.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("BŁĄD:" + ex.Message);
                }
            }
            listViewUzytkownicy.Items.Clear();
            listViewUzytkownicy.Refresh();
            WczytywanieListView(null, null);
        }

        private void closeButton_Click(object sender, EventArgs e) //Krzyżyk wyjście z programu
        {
            new ExitWindow().Show();
        }

        private void minimalizeButton_Click(object sender, EventArgs e) //Minimalizacja okna
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonWyjscie_Click(object sender, EventArgs e) //Przycisk bocznego menu Wyjście z programu.
        {
            new ExitWindow().Show();
        }

        private void buttonHistoria_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonHistoria.Height;
            SidePanel.Top = buttonHistoria.Top;

            this.Hide();
            var form2 = new HistoriaForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void buttonRobienieLaku_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new MenuGlowne();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelGodzina.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }
    }
}
