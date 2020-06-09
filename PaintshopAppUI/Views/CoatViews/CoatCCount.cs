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
using DataAccessLibrary.DataAccess;

namespace PaintshopAppUI.Views.CoatViews
{
    public partial class CoatCCount : UserControl
    {
        public CoatCCount()
        {
            InitializeComponent();
        }

        private int hours, minutes, seconds;

        string coatFinishTime;
        string coatQuantity;
        public string coatType = "CoatC";

        private void comboBoxUnits_SelectedIndexChanged(object sender, EventArgs e) //Wybór jednostki wagi
        {
            if (comboBoxUnits.SelectedItem.ToString() == "kg")
            {
                numberG.Hide();
                numberKg.Show();
            }
            else
            {
                numberKg.Hide();
                numberG.Show();
            }
        }

        private void numberG_ValueChanged(object sender, EventArgs e) //obieranie wartości numericUpDown dla G i obliczanie
        {
            decimal iloscLaku = numberG.Value;
            labelBasicCoatQuantity.Text = iloscLaku.ToString(); //WARTOSC DLA WLEWANEGO LAKU
            coatQuantity = iloscLaku.ToString();
        }

        private void numberKg_ValueChanged(object sender, EventArgs e)
        {
            decimal iloscLaku = numberKg.Value * 1000; //Oblicza kg na g
            labelBasicCoatQuantity.Text = iloscLaku.ToString(); //Wyrzuca wynik
            coatQuantity = iloscLaku.ToString();
        }

        public void saveCoatDataInDataBase(object sender, EventArgs e) //Metoda zapisu informacji o lakierze w bazie danych
        {
            HistoryDataAccess db = new HistoryDataAccess();

            db.GetLoggedUser();

            db.AddCoatData(coatQuantity, coatFinishTime, coatType);
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e) //Pierwszy CheckBox do zaznaczania gotowych zadań
        {
            if (checkBox1.Checked)
            {
                label2.ForeColor = Color.FromArgb(167, 167, 167);
                labelBasicCoatQuantity.ForeColor = Color.FromArgb(167, 167, 167);
                label3.ForeColor = Color.FromArgb(167, 167, 167);
                numberG.Enabled = false;
                comboBoxUnits.Enabled = false;

                //Uruchomienie timera
                timerCoat.Start();
                minutes = 0;
                seconds = 5;
            }
            else
            {
                label2.ForeColor = Color.FromArgb(0, 0, 0);
                labelBasicCoatQuantity.ForeColor = Color.FromArgb(0, 0, 0);
                label3.ForeColor = Color.FromArgb(0, 0, 0);
                checkBox2.Enabled = false;
                checkBox2.Checked = false;
                numberG.Enabled = true;
                comboBoxUnits.Enabled = true;

                timerCoat.Stop(); //Zatrzymanie timera
            }
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e) //Drugi CheckBox do zaznadania gotowych zadań + Uruchomienie timera
        {
            if (checkBox2.Checked)
            {
                checkBox3.Enabled = true;
            }
            else
            {
                checkBox2.Enabled = false;
                checkBox2.Checked = false;
            }
        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)//Trzeci CheckBox do zaznaczania gotowych zadań 
        {
            if (checkBox3.Checked)
            {
                MessageBox.Show(coatQuantity + "g was made at: " + coatFinishTime); //Popup informacyjny o ilości oraz godzinie wykonania lakieru
                label8.ForeColor = Color.FromArgb(167, 167, 167);

                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;

                saveCoatDataInDataBase(null, null);
                //Zamknięcie obecnego okna i powrót do Menu Głównego
                this.Hide();
                var form2 = new MainForm();
                form2.Closed += (s, args) => this.Hide();
                form2.Show();
            }
            else
            {
                label8.ForeColor = Color.FromArgb(0, 0, 0);
                checkBox3.Enabled = true;
            }
        }

        private void timerCoatFinishTime_Tick(object sender, EventArgs e)
        {
            timerCoatFinishTime.Start();
            coatFinishTime = DateTime.Now.ToLongTimeString();
        }

        private void CoatCCount_Load(object sender, EventArgs e)
        {
            if (labelBasicCoatQuantity.Text == "000")
            {
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
            }

            checkBox2.Enabled = false;
            checkBox3.Enabled = false;

            comboBoxUnits.SelectedIndex = 0; //Definiowanie wybranej domyślnej jednostki
            numberKg.Show();

            coatFinishTime = DateTime.Now.ToLongTimeString(); //Pobieranie aktualnej godziny
            timerCoatFinishTime.Start(); //Start odliczania godzinowego
        }

        private void timerCoat_Tick(object sender, EventArgs e)
        {
            if (hours == 0 && minutes == 0 && seconds == 0)// sprawdzenie zakończenia odliczania timera
            {
                timerCoat.Stop();
                MessageBox.Show("Coat is ready to use.");

                lblMin.Text = "00 min";
                lblSec.Text = "00 s";
                checkBox2.Enabled = true;
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
