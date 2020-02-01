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

namespace Test_działania_aplikacji
{
    public partial class MenuGlowne : Form
    {
        int mov;
        int movX;
        int movY;

        public MenuGlowne()
        {
            InitializeComponent();
        }

        string adminString;

        private void ButtonRobienieLaku_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonRobienieLaku.Height;
            SidePanel.Top = buttonRobienieLaku.Top;
        }

        private void ButtonHistoria_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonHistoria.Height;
            SidePanel.Top = buttonHistoria.Top;

            odczytZalogowanegoUzytkownikaHistoria(null, null); //Otwarcie nowego okna logowania jeśli USER nie jest adminem
        }

        private void ButtonUstawienia_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonUstawienia.Height;
            SidePanel.Top = buttonUstawienia.Top;

            odczytZalogowanegoUzytkownikaUstawienia(null, null); //Otwarcie nowego okna logowania jeśli USER nie jest adminem
        }

        private void ButtonWyjscie_Click(object sender, EventArgs e)
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

        private void buttonPermutexQuantity_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new LackQuantity();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void buttonSipiolQuantity_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new LackQuantity();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
        
        private void toppanel2_MouseDown(object sender, MouseEventArgs e) //Zmiana miejsca okna dla obu paneli
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

        private void MenuGlowne_Load(object sender, EventArgs e) //AKTUALNY CZAS
        {
            timer.Start();
            labelGodzina.Text = DateTime.Now.ToLongTimeString();

        }

        private void timer_Tick(object sender, EventArgs e) //ODLICZANIE ZEGARA
        {
            labelGodzina.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }

        public void odczytZalogowanegoUzytkownikaHistoria(object sender, EventArgs e) //Metoda Odczyt aktualnie zalogowanego użytkownika dla przycisku Historia
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            {
                SqlCommand cmd = new SqlCommand("select * from ZALOGOWANYUZYTKOWNIK", con);
                con.Open();

                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    adminString = (read["ADMIN"].ToString().Trim());
                }
                read.Close();
            }

            if (adminString == "admin")
            {
                this.Hide();
                var form2 = new HistoriaForm();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Brak dostępu! Wymaga uprawnień administratora.");
            }
        }

        public void odczytZalogowanegoUzytkownikaUstawienia(object sender, EventArgs e) //Metoda Odczyt aktualnie zalogowanego użytkownika dla przycisku Ustawienia
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            {
                SqlCommand cmd = new SqlCommand("select * from ZALOGOWANYUZYTKOWNIK", con);
                con.Open();

                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    adminString = (read["UZYTKOWNIK"].ToString().Trim());
                }
                read.Close();
            }

            if (adminString == "admin")
            {
                this.Hide();
                var form2 = new UstawieniaForm();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Brak dostępu! Wymaga uprawnień administratora.");
            }

        }
    }
}