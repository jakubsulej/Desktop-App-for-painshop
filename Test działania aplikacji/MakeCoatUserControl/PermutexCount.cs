using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Test_działania_aplikacji
{
    public partial class PermutexCount : UserControl
    {
        public PermutexCount()
        {
            InitializeComponent();
        }

        private int hours, minutes, seconds;

        string coatPermutexFinnishTime;
        string coatPermutexQuantity;
        string currentlyLoggedUser;

        private void comboBoxUnitsPermutex_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxUnitsPermutex.SelectedItem.ToString() == "kg")
            {
                numberGPermutex.Hide();
                numberKg.Show();
            }
            else
            {
                numberKg.Hide();
                numberGPermutex.Show();
            }
        }

        private void numberKg_ValueChanged_1(object sender, EventArgs e)
        {
            decimal iloscLaku = numberKg.Value * 1000; //Oblicza kg na g
            labelBasicCoatQuantity.Text = iloscLaku.ToString(); //Wyrzuca wynik

            double k = (double)iloscLaku;

            double quantityOfThickener = (k * 0.016) + 12;

            labelQuantityOfThickener.Text = quantityOfThickener.ToString(); //WARTOSC WYJSCIOWA DLA WLEWANEGO SKLADNIKA

            coatPermutexQuantity = labelBasicCoatQuantity.Text;

            double quantityOfComponentB = k * 0.014;

            labelComponentB.Text = quantityOfComponentB.ToString();
            labelComponentC.Text = (quantityOfComponentB + 12).ToString();
        }

        private void numberGPermutex_ValueChanged(object sender, EventArgs e)
        {
            decimal iloscLaku = numberGPermutex.Value;
            labelBasicCoatQuantity.Text = iloscLaku.ToString(); //WARTOSC DLA WLEWANEGO LAKU

            double konwersjaIloscLaku = (double)iloscLaku;

            double obliczanie = (konwersjaIloscLaku * 0.03) + 12;

            labelQuantityOfThickener.Text = obliczanie.ToString(); //WARTOSC WYJSCIOWA DLA WLEWANEGO SKLADNIKA

            coatPermutexQuantity = labelBasicCoatQuantity.Text;
        }

        public void zapisInformacjiWBazieDanych(object sender, EventArgs e) //Metoda zapisu informacji o lakierze w bazie danych
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            //ODCZYT AKTUALNIE ZALOGOWANEGO UŻYTKOWNIKA

            SqlCommand command = new SqlCommand("Select * From ZALOGOWANYUZYTKOWNIK", connection);

            connection.Open();

            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                currentlyLoggedUser = (read["UZYTKOWNIK"].ToString().Trim());
            }

            read.Close();

            connection.Close();

            //ZAPIS W BAZIE DANYCH HISTORIAROBIENIA LAKU WSZYSTKICH INFORMACJI

            string sqlCoatHistory = "Insert into Historiarobienialaku ([ILOSCLAKU], [GODZINA], [USER], [RODZAJLAKU], [DATA]) values(@Ilosclaku, @Godzina, @User, @Rodzajlaku, @Data)";

            string coatName = "Permutex";
            DateTime currentDate = DateTime.Now;
            string justDate = currentDate.ToShortDateString();

            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(sqlCoatHistory, connection))
                    {
                        cmd.Parameters.AddWithValue("@Ilosclaku", coatPermutexQuantity);
                        cmd.Parameters.AddWithValue("@Godzina", coatPermutexFinnishTime);
                        cmd.Parameters.AddWithValue("@User", currentlyLoggedUser);
                        cmd.Parameters.AddWithValue("@Rodzajlaku", coatName);
                        cmd.Parameters.AddWithValue("@Data", justDate);

                        int rowsAdded = cmd.ExecuteNonQuery();
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("BŁĄD:" + ex.Message);
                }
            }
        }

        private void checkBox1Permutex_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1Permutex.Checked)
            {
                label2.ForeColor = Color.FromArgb(167, 167, 167);
                labelBasicCoatQuantity.ForeColor = Color.FromArgb(167, 167, 167);
                label3.ForeColor = Color.FromArgb(167, 167, 167);
                checkBox2Permutex.Enabled = true;
                numberGPermutex.Enabled = false;
                comboBoxUnitsPermutex.Enabled = false;
            }
            else
            {
                label2.ForeColor = Color.FromArgb(0, 0, 0);
                labelBasicCoatQuantity.ForeColor = Color.FromArgb(0, 0, 0);
                label3.ForeColor = Color.FromArgb(0, 0, 0);
                checkBox2Permutex.Enabled = false;
                checkBox2Permutex.Checked = false;
                numberGPermutex.Enabled = true;
                comboBoxUnitsPermutex.Enabled = true;
            }
        }

        private void checkBox2Permutex_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox2Permutex.Checked)
            {
                label4.ForeColor = Color.FromArgb(167, 167, 167);
                labelQuantityOfThickener.ForeColor = Color.FromArgb(167, 167, 167);
                label5.ForeColor = Color.FromArgb(167, 167, 167);

                //Uruchomienie timera
                timerCoat.Start();
                minutes = 0;
                seconds = 5;
            }
            else
            {
                label4.ForeColor = Color.FromArgb(0, 0, 0);
                labelQuantityOfThickener.ForeColor = Color.FromArgb(0, 0, 0);
                label5.ForeColor = Color.FromArgb(0, 0, 0);
                checkBox3Permutex.Enabled = false;
                checkBox3Permutex.Checked = false;

                timerCoat.Stop(); //Zatrzymanie timera
            }
        }

        private void checkBox3Permutex_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3Permutex.Checked)
            {
                label6.ForeColor = Color.FromArgb(167, 167, 167);
                lblMin.ForeColor = Color.FromArgb(167, 167, 167);
                lblSec.ForeColor = Color.FromArgb(167, 167, 167);
                label7.ForeColor = Color.FromArgb(167, 167, 167);
                checkBox4Permutex.Enabled = true;
            }
            else
            {
                label6.ForeColor = Color.FromArgb(0, 0, 0);
                lblMin.ForeColor = Color.FromArgb(0, 0, 0);
                lblSec.ForeColor = Color.FromArgb(0, 0, 0);
                label7.ForeColor = Color.FromArgb(0, 0, 0);
                checkBox4Permutex.Enabled = false;
                checkBox4Permutex.Checked = false;

                timerCoat.Stop();
            }
        }

        private void checkBox4Permutex_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4Permutex.Checked)
            {
                label9.ForeColor = Color.FromArgb(167, 167, 167);
                labelComponentB.ForeColor = Color.FromArgb(167, 167, 167);
                label10.ForeColor = Color.FromArgb(167, 167, 167);
                labelComponentC.ForeColor = Color.FromArgb(167, 167, 167);
                label12.ForeColor = Color.FromArgb(167, 167, 167);
                checkBox5Permutex.Enabled = true;
            }
            else
            {
                label9.ForeColor = Color.FromArgb(0, 0, 0);
                labelComponentB.ForeColor = Color.FromArgb(0, 0, 0);
                label10.ForeColor = Color.FromArgb(0, 0, 0);
                labelComponentC.ForeColor = Color.FromArgb(0, 0, 0);
                label12.ForeColor = Color.FromArgb(0, 0, 0);
                checkBox5Permutex.Enabled = false;
                checkBox5Permutex.Checked = false;
            }
        }

        private void checkBox5Permutex_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5Permutex.Checked)
            {
                MessageBox.Show(coatPermutexQuantity + "g zostało wykonane o godzinie: " + coatPermutexFinnishTime); //Popup informacyjny o ilości oraz godzinie wykonania lakieru
                label8.ForeColor = Color.FromArgb(167, 167, 167);

                checkBox1Permutex.Enabled = false;
                checkBox2Permutex.Enabled = false;
                checkBox3Permutex.Enabled = false;
                checkBox4Permutex.Enabled = false;
                checkBox5Permutex.Enabled = false;

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
                checkBox5Permutex.Enabled = true;
            }
        }

        private void timerCoatFinishTime_Tick(object sender, EventArgs e)
        {
            timerCoatFinishTime.Start();
            coatPermutexFinnishTime = DateTime.Now.ToLongTimeString();
        }

        private void PermutexCount_Load(object sender, EventArgs e)
        {
            if (labelBasicCoatQuantity.Text == "000")
            {
                checkBox1Permutex.Enabled = false;
            }
            else
            {
                checkBox1Permutex.Enabled = true;
            }

            checkBox2Permutex.Enabled = false;
            checkBox3Permutex.Enabled = false;
            checkBox4Permutex.Enabled = false;
            checkBox5Permutex.Enabled = false;

            comboBoxUnitsPermutex.SelectedIndex = 0; //Definiowanie wybranej domyślnej jednostki
            numberKg.Show();

            coatPermutexFinnishTime = DateTime.Now.ToLongTimeString(); //Pobieranie aktualnej godziny
            timerCoatFinishTime.Start(); //Start odliczania godzinowego
        }

        private void timerCoat_Tick(object sender, EventArgs e)
        {
            if (hours == 0 && minutes == 0 && seconds == 0)// sprawdzenie zakończenia odliczania timera
            {
                timerCoat.Stop();
                MessageBox.Show("Lakier jest rozmieszany i gotowy do użycia");

                lblMin.Text = "00 min";
                lblSec.Text = "00 s";
                checkBox3Permutex.Enabled = true;
            }
            else
            {
                if (seconds < 1)// Sprawdzenie czy sekundy są mniejsze niż 1
                {
                    seconds = 59;// Zmiana sekund na 59 jeśli jest mniejsza od 1
                    if (minutes < 1)// Sprawdzenie czy minuty są mniejsze niz 1
                    {
                        minutes = 59;// Zamiana minut na 59 jeśli jest mniejsze od 1
                        if (hours != 0)// Sprawdzenie czy godziny są różne od 0
                            hours -= 1;// on here we remove from the current hour the number 1. its the same if we write hours = hours - 1;
                    }
                    else minutes -= 1;// odejmowanie z obecnych minut 1
                }
                else seconds -= 1;// to samo dla sekund

                if (minutes > 9)
                    lblMin.Text = minutes.ToString() + " min";
                else lblMin.Text = "0" + minutes.ToString() + " min";
                if (seconds > 9)
                    lblSec.Text = seconds.ToString() + " s";
                else lblSec.Text = "0" + seconds.ToString() + " s";
            }
        }
    }
}
