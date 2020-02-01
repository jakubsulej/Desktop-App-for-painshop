using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Test_działania_aplikacji
{
    public partial class SipiolObliczanie : UserControl
    {

        public SipiolObliczanie()
        {
            InitializeComponent();
        }

        private int godziny, min, sek;

        string godzinaLakuText;
        string informacjaOIlosciLaku;
        string zalogowanyUzytkownik;

        private void comboBoxUnits_SelectedIndexChanged(object sender, EventArgs e) //Wybór jednostki wagi
        {
            if (comboBoxUnits.SelectedItem.ToString() == "kg")
            {
                numberG.Hide();
                numberKg.Show();
            } 
            else {
                numberKg.Hide();
                numberG.Show();
            }
        }
        
        private void numberKg_ValueChanged(object sender, EventArgs e) //Pobieranie wartości z numericUpDown dla KG i obliczanie
        {
            decimal iloscLaku = numberKg.Value * 1000; //Oblicza kg na g
            wartoscWyjsciowaIlosciLaku.Text = iloscLaku.ToString(); //Wyrzuca wynik

            double konwersjaIloscLaku = (double)iloscLaku;

            double obliczanie = (konwersjaIloscLaku * 0.03) + 12;

            labelIloscSkladnikaSipiolWV.Text = obliczanie.ToString(); //WARTOSC WYJSCIOWA DLA WLEWANEGO SKLADNIKA

            informacjaOIlosciLaku = wartoscWyjsciowaIlosciLaku.Text;
        }

        private void numberG_ValueChanged(object sender, EventArgs e) //obieranie wartości numericUpDown dla G i obliczanie
        {
            decimal iloscLaku = numberG.Value;
            wartoscWyjsciowaIlosciLaku.Text = iloscLaku.ToString(); //WARTOSC DLA WLEWANEGO LAKU

            double konwersjaIloscLaku = (double)iloscLaku;

            double obliczanie = (konwersjaIloscLaku * 0.03)+12;

            labelIloscSkladnikaSipiolWV.Text = obliczanie.ToString(); //WARTOSC WYJSCIOWA DLA WLEWANEGO SKLADNIKA

            informacjaOIlosciLaku = wartoscWyjsciowaIlosciLaku.Text;
        }

        public void zapisInformacjiWBazieDanych(object sender, EventArgs e) //Metoda zapisu informacji o lakierze w bazie danych
        {
            string sqlHistoria = null;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            //ODCZYT AKTUALNIE ZALOGOWANEGO UŻYTKOWNIKA <====Przerobić w metodę

            SqlCommand command = new SqlCommand("Select * From ZALOGOWANYUZYTKOWNIK", con);

            con.Open();

            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                zalogowanyUzytkownik = (read["UZYTKOWNIK"].ToString().Trim());
            }

            read.Close();

            con.Close();

            //ZAPIS W BAZIE DANYCH HISTORIAROBIENIA LAKU WSZYSTKICH INFORMACJI

            sqlHistoria = "Insert into Historiarobienialaku ([ILOSCLAKU], [GODZINA], [USER], [RODZAJLAKU], [DATA]) values(@Ilosclaku, @Godzina, @User, @Rodzajlaku, @Data)";

            string nazwaLakieru = "Sipiol";
            DateTime obecnaData = DateTime.Now;
            string tylkoData = obecnaData.ToShortDateString();

            // Tworzenie połączenia z bazą danych
            {
                try
                {
                    // Otwarcie bazy danych
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(sqlHistoria, con))
                    {
                        // Dodawanie wartości do bazy danych
                        cmd.Parameters.AddWithValue("@Ilosclaku", informacjaOIlosciLaku);
                        cmd.Parameters.AddWithValue("@Godzina", godzinaLakuText);
                        cmd.Parameters.AddWithValue("@User", zalogowanyUzytkownik);
                        cmd.Parameters.AddWithValue("@Rodzajlaku", nazwaLakieru);
                        cmd.Parameters.AddWithValue("@Data", tylkoData);

                        int rowsAdded = cmd.ExecuteNonQuery();
                    }
                    
                    con.Close();
                }
                catch (Exception ex)
                {
                    // Wyświetlanie błędów
                    MessageBox.Show("BŁĄD:" + ex.Message);
                }
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e) //Pierwszy CheckBox do zaznaczania gotowych zadań
        {
            if (checkBox1.Checked)
            {
                label2.ForeColor = Color.FromArgb(167, 167, 167);
                wartoscWyjsciowaIlosciLaku.ForeColor = Color.FromArgb(167, 167, 167);
                label3.ForeColor = Color.FromArgb(167, 167, 167);
                checkBox2.Enabled = true;

                numberG.Enabled = false; //<======= blokowanie ustawień ilości lakieru
                comboBoxUnits.Enabled = false;
            }
            else
            {
                label2.ForeColor = Color.FromArgb(0, 0, 0);
                wartoscWyjsciowaIlosciLaku.ForeColor = Color.FromArgb(0, 0, 0);
                label3.ForeColor = Color.FromArgb(0, 0, 0);
                checkBox2.Enabled = false;
                checkBox2.Checked = false;
                
                numberG.Enabled = true; // <====== blokowanie ustawień ilości lakieru
                comboBoxUnits.Enabled = true;
            }
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e) //Drugi CheckBox do zaznadania gotowych zadań + Uruchomienie timera
        {
            if (checkBox2.Checked) //zmiana koloru fontu
            {
                label4.ForeColor = Color.FromArgb(167, 167, 167);
                labelIloscSkladnikaSipiolWV.ForeColor = Color.FromArgb(167, 167, 167);
                label5.ForeColor = Color.FromArgb(167, 167, 167);

                //Uruchomienie timera

                timerLaku.Start();
                min = 0;
                sek = 5;
            }
            else
            {
                label4.ForeColor = Color.FromArgb(0, 0, 0);
                labelIloscSkladnikaSipiolWV.ForeColor = Color.FromArgb(0, 0, 0);
                label5.ForeColor = Color.FromArgb(0, 0, 0);
                checkBox3.Enabled = false;
                checkBox3.Checked = false;

                timerLaku.Stop(); //Zatrzymanie timera
            }
        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)//Trzeci CheckBox do zaznaczania gotowych zadań 
        {
            
            if (checkBox3.Checked)
            {
                label6.ForeColor = Color.FromArgb(167, 167, 167);
                lblMin.ForeColor = Color.FromArgb(167, 167, 167);
                lblSec.ForeColor = Color.FromArgb(167, 167, 167);
                label7.ForeColor = Color.FromArgb(167, 167, 167);
                checkBox4.Enabled = true;
            }
            else
            {
                label6.ForeColor = Color.FromArgb(0, 0, 0);
                lblMin.ForeColor = Color.FromArgb(0, 0, 0);
                lblSec.ForeColor = Color.FromArgb(0, 0, 0);
                label7.ForeColor = Color.FromArgb(0, 0, 0);
                checkBox4.Enabled = false;
                checkBox4.Checked = false;

                timerLaku.Stop();
            }
        }

        private void checkBox4_CheckStateChanged(object sender, EventArgs e)
        {
            

            if (checkBox4.Checked)
            {
                MessageBox.Show(informacjaOIlosciLaku + "g zostało wykonane o godzinie: " + godzinaLakuText); //Popup informacyjny o ilości oraz godzinie wykonania lakieru
                label8.ForeColor = Color.FromArgb(167, 167, 167);

                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;

                zapisInformacjiWBazieDanych(null, null);
                //Zamknięcie obecnego okna i powrót do Menu Głównego
                this.Hide();
                var form2 = new MenuGlowne();
                form2.Closed += (s, args) => this.Hide();
                form2.Show();
            }
            else
            {
                label8.ForeColor = Color.FromArgb(0, 0, 0);
                checkBox4.Enabled = true;
            }
        }

        private void timerGodzinaLaku_Tick(object sender, EventArgs e) //Timer aktualnej godziny
        {
            timerGodzinaLaku.Start();
            godzinaLakuText = DateTime.Now.ToLongTimeString();
        }

        private void timerLaku_Tick(object sender, EventArgs e) //Odliczanie w dół timera
        {
            if (godziny == 0 && min == 0 && sek == 0)// sprawdzenie zakończenia odliczania timera
            {
                timerLaku.Stop();
                MessageBox.Show("Lakier jest rozmieszany i gotowy do użycia");

                lblMin.Text = "00 min";
                lblSec.Text = "00 s";
                checkBox3.Enabled = true;
            }
            else
            {
                if (sek < 1)// Sprawdzenie czy sekundy są mniejsze niż 1
                {
                    sek = 59;// Zmiana sekund na 59 jeśli jest mniejsza od 1
                    if (min < 1)// Sprawdzenie czy minuty są mniejsze niz 1
                    {
                        min = 59;// Zamiana minut na 59 jeśli jest mniejsze od 1
                        if (godziny != 0)// Sprawdzenie czy godziny są różne od 0
                            godziny -= 1;// on here we remove from the current hour the number 1. its the same if we write hours = hours - 1;
                    }
                    else min -= 1;// odejmowanie z obecnych minut 1
                }
                else sek -= 1;// to samo dla sekund

                if (min > 9)
                    lblMin.Text = min.ToString() + " min";
                else lblMin.Text = "0" + min.ToString() + " min";
                if (sek > 9)
                    lblSec.Text = sek.ToString() + " s";
                else lblSec.Text = "0" + sek.ToString() + " s";
            }
        }
        
        private void SipiolObliczanie1_Load(object sender, EventArgs e)//Domyślne ustawienia okna 
        {
            if (wartoscWyjsciowaIlosciLaku.Text == "000")
            {
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
            }

            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;

            comboBoxUnits.SelectedIndex = 0; //Definiowanie wybranej domyślnej jednostki
            numberKg.Show();

            godzinaLakuText =  DateTime.Now.ToLongTimeString(); //Pobieranie aktualnej godziny
            timerGodzinaLaku.Start(); //Start odliczania godzinowego
        }
    }
}
