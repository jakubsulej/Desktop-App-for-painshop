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
    public partial class CoatBCount : UserControl
    {
        public CoatBCount()
        {
            InitializeComponent();
        }

        private int hours, minutes, seconds;

        string coatFinishTime;
        string coatQuantity;
        public string coatType = "CoatB";

        private void comboBoxUnitsCoatB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxUnitsCoatB.SelectedItem.ToString() == "kg")
            {
                numberGCoatB.Hide();
                numberKg.Show();
            }
            else
            {
                numberKg.Hide();
                numberGCoatB.Show();
            }
        }

        private void numberKg_ValueChanged_1(object sender, EventArgs e)
        {
            decimal coatQuantityInput = numberKg.Value * 1000; //Oblicza kg na g
            labelBasicCoatQuantity.Text = coatQuantityInput.ToString(); //Wyrzuca wynik

            double k = (double)coatQuantityInput;

            double quantityOfThickener = (k * 0.016) + 12;

            labelQuantityOfThickener.Text = quantityOfThickener.ToString(); //WARTOSC WYJSCIOWA DLA WLEWANEGO SKLADNIKA

            coatQuantity = labelBasicCoatQuantity.Text;

            double quantityOfComponentB = k * 0.014;

            labelComponentB.Text = quantityOfComponentB.ToString();
            labelComponentC.Text = (quantityOfComponentB + 12).ToString();
        }

        private void numberGCoatB_ValueChanged(object sender, EventArgs e)
        {
            decimal coatQuantityInput = numberGCoatB.Value;
            labelBasicCoatQuantity.Text = coatQuantityInput.ToString(); //WARTOSC DLA WLEWANEGO LAKU

            double convertCoatQuantity = (double)coatQuantityInput;

            double counting = (convertCoatQuantity * 0.03) + 12;

            labelQuantityOfThickener.Text = counting.ToString(); //WARTOSC WYJSCIOWA DLA WLEWANEGO SKLADNIKA

            coatQuantity = labelBasicCoatQuantity.Text;
        }

        public void saveCoatHistoryInDataBase(object sender, EventArgs e) //Metoda zapisu informacji o lakierze w bazie danych
        {
            HistoryDataAccess db = new HistoryDataAccess();
            
            db.GetLoggedUser();

            db.AddCoatData(coatQuantity,coatFinishTime,coatType);
        }

        private void checkBox1CoatB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1CoatB.Checked)
            {
                label2.ForeColor = Color.FromArgb(167, 167, 167);
                labelBasicCoatQuantity.ForeColor = Color.FromArgb(167, 167, 167);
                label3.ForeColor = Color.FromArgb(167, 167, 167);
                checkBox2CoatB.Enabled = true;
                numberGCoatB.Enabled = false;
                comboBoxUnitsCoatB.Enabled = false;
            }
            else
            {
                label2.ForeColor = Color.FromArgb(0, 0, 0);
                labelBasicCoatQuantity.ForeColor = Color.FromArgb(0, 0, 0);
                label3.ForeColor = Color.FromArgb(0, 0, 0);
                checkBox2CoatB.Enabled = false;
                checkBox2CoatB.Checked = false;
                numberGCoatB.Enabled = true;
                comboBoxUnitsCoatB.Enabled = true;
            }
        }

        private void checkBox2CoatB_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox2CoatB.Checked)
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
                checkBox3CoatB.Enabled = false;
                checkBox3CoatB.Checked = false;

                timerCoat.Stop(); //Zatrzymanie timera
            }
        }

        private void checkBox3CoatB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3CoatB.Checked)
            {
                label6.ForeColor = Color.FromArgb(167, 167, 167);
                lblMin.ForeColor = Color.FromArgb(167, 167, 167);
                lblSec.ForeColor = Color.FromArgb(167, 167, 167);
                label7.ForeColor = Color.FromArgb(167, 167, 167);
                checkBox4CoatB.Enabled = true;
            }
            else
            {
                label6.ForeColor = Color.FromArgb(0, 0, 0);
                lblMin.ForeColor = Color.FromArgb(0, 0, 0);
                lblSec.ForeColor = Color.FromArgb(0, 0, 0);
                label7.ForeColor = Color.FromArgb(0, 0, 0);
                checkBox4CoatB.Enabled = false;
                checkBox4CoatB.Checked = false;

                timerCoat.Stop();
            }
        }

        private void checkBox4CoatB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4CoatB.Checked)
            {
                label9.ForeColor = Color.FromArgb(167, 167, 167);
                labelComponentB.ForeColor = Color.FromArgb(167, 167, 167);
                label10.ForeColor = Color.FromArgb(167, 167, 167);
                labelComponentC.ForeColor = Color.FromArgb(167, 167, 167);
                label12.ForeColor = Color.FromArgb(167, 167, 167);
                checkBox5CoatB.Enabled = true;
            }
            else
            {
                label9.ForeColor = Color.FromArgb(0, 0, 0);
                labelComponentB.ForeColor = Color.FromArgb(0, 0, 0);
                label10.ForeColor = Color.FromArgb(0, 0, 0);
                labelComponentC.ForeColor = Color.FromArgb(0, 0, 0);
                label12.ForeColor = Color.FromArgb(0, 0, 0);
                checkBox5CoatB.Enabled = false;
                checkBox5CoatB.Checked = false;
            }
        }

        private void checkBox5CoatB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5CoatB.Checked)
            {
                MessageBox.Show(coatQuantity + "g was made at: " + coatFinishTime); //Popup informacyjny o ilości oraz godzinie wykonania lakieru
                label8.ForeColor = Color.FromArgb(167, 167, 167);

                checkBox1CoatB.Enabled = false;
                checkBox2CoatB.Enabled = false;
                checkBox3CoatB.Enabled = false;
                checkBox4CoatB.Enabled = false;
                checkBox5CoatB.Enabled = false;

                saveCoatHistoryInDataBase(null, null);
                //Zamknięcie obecnego okna i powrót do Menu Głównego
                this.Hide();
                var form2 = new MainForm();
                form2.Closed += (s, args) => this.Hide();
                form2.Show();
            }
            else
            {
                label8.ForeColor = Color.FromArgb(0, 0, 0);
                checkBox5CoatB.Enabled = true;
            }
        }

        private void timerCoatFinishTime_Tick(object sender, EventArgs e)
        {
            timerCoatFinishTime.Start();
            coatFinishTime = DateTime.Now.ToLongTimeString();
        }

        private void CoatBCount_Load(object sender, EventArgs e)
        {
            if (labelBasicCoatQuantity.Text == "000")
            {
                checkBox1CoatB.Enabled = false;
            }
            else
            {
                checkBox1CoatB.Enabled = true;
            }

            checkBox2CoatB.Enabled = false;
            checkBox3CoatB.Enabled = false;
            checkBox4CoatB.Enabled = false;
            checkBox5CoatB.Enabled = false;

            comboBoxUnitsCoatB.SelectedIndex = 0; //Definiowanie wybranej domyślnej jednostki
            numberKg.Show();

            coatFinishTime = DateTime.Now.ToLongTimeString(); //Pobieranie aktualnej godziny
            timerCoatFinishTime.Start(); //Start odliczania godzinowego
        }

        private void timerCoat_Tick(object sender, EventArgs e)
        {
            if (hours == 0 && minutes == 0 && seconds == 0)// sprawdzenie zakończenia odliczania timera
            {
                timerCoat.Stop();
                MessageBox.Show("Coat is mixed and ready to use.");

                lblMin.Text = "00 min";
                lblSec.Text = "00 s";
                checkBox3CoatB.Enabled = true;
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
