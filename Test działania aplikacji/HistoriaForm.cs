﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_działania_aplikacji
{
    public partial class HistoriaForm : Form
    {
        public HistoriaForm()
        {
            InitializeComponent();
        }

        string dataWsteczna;

        public void WczytywanieListView(object sender, EventArgs e)
        {
            listViewHistoria.GridLines = true;
            listViewHistoria.View = View.Details;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            SqlDataAdapter sda = new SqlDataAdapter("select * from HISTORIAROBIENIALAKU", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["ILOSCLAKU"].ToString());
                listitem.SubItems.Add(dr["GODZINA"].ToString());
                listitem.SubItems.Add(dr["USER"].ToString());
                listitem.SubItems.Add(dr["RODZAJLAKU"].ToString());
                listitem.SubItems.Add(dr["DATA"].ToString());
                listViewHistoria.Items.Add(listitem);
            }
        }

        private void usuwanieWierszaTabela(object sender, EventArgs e) //USUWANIE ZAZNACZONYCH DANYCH
        {
            string dataTabela = listViewHistoria.SelectedItems[0].SubItems[4].Text; ;
            string godzinaTabela = listViewHistoria.SelectedItems[0].SubItems[1].Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            string sql = "Delete from HISTORIAROBIENIALAKU where Godzina=@Godzina AND Data=@Data";

            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Godzina", godzinaTabela);
                        cmd.Parameters.AddWithValue("@Data", dataTabela);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("BŁĄD:" + ex.Message);
                }
            }
        }
        private void usuwanie7DniTabela(object sender, EventArgs e) //NIE DZIAŁA!!!!! <====Dodaje tylko aktualną datę minus siedem
        {
            
            
            DateTime aktualnaData = DateTime.Now;

            for (int i = 0; i < 7; i++)
            {
                aktualnaData = aktualnaData.AddDays(-1);
                dataWsteczna = aktualnaData.Date.ToShortDateString();
            }

            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            //string sql = "Delete from HISTORIAROBIENIALAKU where DATA=@Data Order By DATA";

            //{
            //    try
            //    {
            //        using (SqlCommand cmd = new SqlCommand(sql, con))
            //        {
            //            cmd.Parameters.AddWithValue("@Godzina", godzinaTabela);
            //            cmd.Parameters.AddWithValue("@Data", dataTabela);

            //            con.Open();
            //            cmd.ExecuteNonQuery();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("BŁĄD:" + ex.Message);
            //    }
            //}
        }

        private void closeButton_Click(object sender, EventArgs e) //Krzyżyk wyjście z programu
        {
            new ExitWindow().Show();
        }

        private void minimalizeButton_Click(object sender, EventArgs e) //Minimalizacja okna
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonWyjscie_Click(object sender, EventArgs e) //Przycisk boczne menu Wyjście z programu
        {
            new ExitWindow().Show();
        }

        private void buttonUstawienia_Click(object sender, EventArgs e) //Otwarcie nowego okna Ustawienia
        {
            SidePanel.Height = buttonUstawienia.Height;
            SidePanel.Top = buttonUstawienia.Top;

            this.Hide();
            var form2 = new UstawieniaForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void HistoriaForm_Load(object sender, EventArgs e)
        {
            WczytywanieListView (null, null);
            listViewHistoria.View = View.Details;
            listViewHistoria.FullRowSelect = true;

            //URUCHOMIENIE TIMERA DLA AKTUALNEJ GODZINY
            timer.Start();
            labelGodzina.Text = DateTime.Now.ToLongTimeString();
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

        private void buttonUsuwanieHistorii_Click(object sender, EventArgs e)
        {
            usuwanieWierszaTabela(null, null);
            listViewHistoria.Items.Clear();
            listViewHistoria.Refresh();
            WczytywanieListView(null, null);
        }

        private void buttonUsun7Dni_Click(object sender, EventArgs e)
        {
            usuwanie7DniTabela(null, null);
            labelDataWsteczna.Text = dataWsteczna;
        }
    }
}
