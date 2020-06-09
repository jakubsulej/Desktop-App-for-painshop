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
    public partial class CoatDCount : UserControl
    {
        public CoatDCount()
        {
            InitializeComponent();
        }

        private int hours, minutes, seconds;

        string coatFinishTime;
        string coatQuantity;
        public string coatType = "CoatD";

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

        private void numberKg_ValueChanged(object sender, EventArgs e) //Pobieranie wartości z numericUpDown dla KG i obliczanie
        {
            decimal coatQuantityInput = numberKg.Value * 1000; //Oblicza kg na g
            labelBasicCoatQuantity.Text = coatQuantityInput.ToString(); //Wyrzuca wynik

            double k = (double)coatQuantityInput;

            double quantityOfComponentB = k * 0.02;

            labelQuantityOfComponentB.Text = quantityOfComponentB.ToString(); //WARTOSC WYJSCIOWA DLA WLEWANEGO SKLADNIKA

            coatQuantity = labelBasicCoatQuantity.Text;
        }

        private void numberG_ValueChanged(object sender, EventArgs e) //obieranie wartości numericUpDown dla G i obliczanie
        {
            decimal coatQuantityInput = numberG.Value;
            labelBasicCoatQuantity.Text = coatQuantityInput.ToString(); //WARTOSC DLA WLEWANEGO LAKU

            double convertCoatQuantity = (double)coatQuantityInput;

            double obliczanie = convertCoatQuantity * 0.02;

            labelQuantityOfComponentB.Text = obliczanie.ToString(); //WARTOSC WYJSCIOWA DLA WLEWANEGO SKLADNIKA

            coatQuantity = labelBasicCoatQuantity.Text;
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
                checkBox2.Enabled = true;
                numberG.Enabled = false;
                comboBoxUnits.Enabled = false;
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
            }
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                label4.ForeColor = Color.FromArgb(167, 167, 167);
                labelQuantityOfComponentB.ForeColor = Color.FromArgb(167, 167, 167);
                label5.ForeColor = Color.FromArgb(167, 167, 167);

                timerCoat.Start();
                minutes = 0;
                seconds = 5;
            }
            else
            {
                label4.ForeColor = Color.FromArgb(0, 0, 0);
                labelQuantityOfComponentB.ForeColor = Color.FromArgb(0, 0, 0);
                label5.ForeColor = Color.FromArgb(0, 0, 0);
                checkBox3.Enabled = false;
                checkBox3.Checked = false;

                timerCoat.Stop();
            }
        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
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

                timerCoat.Stop();
            }
        }

        private void checkBox4_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                MessageBox.Show(coatQuantity + "g was made at: " + coatFinishTime);
                label8.ForeColor = Color.FromArgb(167, 167, 167);

                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;

                saveCoatDataInDataBase(null, null);

                this.Hide();
                var form2 = new MainForm();
                form2.Closed += (s, args) => this.Hide();
                form2.Show();
            }
            else
            {
                label8.ForeColor = Color.FromArgb(0, 0, 0);
                checkBox4.Enabled = true;
            }
        }

        private void timerCoat_Tick(object sender, EventArgs e)
        {
            if (hours == 0 && minutes == 0 && seconds == 0)
            {
                timerCoat.Stop();
                MessageBox.Show("Coat is ready to use.");

                lblMin.Text = "00 min";
                lblSec.Text = "00 s";
                checkBox3.Enabled = true;
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

        private void CoatD_Load(object sender, EventArgs e)
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
            checkBox4.Enabled = false;

            comboBoxUnits.SelectedIndex = 0; //Definiowanie wybranej domyślnej jednostki
            numberKg.Show();

            coatFinishTime = DateTime.Now.ToLongTimeString(); //Pobieranie aktualnej godziny
            timerCoatFinishTime.Start(); //Start odliczania godzinowego
        }

        private void timerCoatFinishTime_Tick(object sender, EventArgs e)
        {
            timerCoatFinishTime.Start();
            coatFinishTime = DateTime.Now.ToLongTimeString();
        }
    }
}
