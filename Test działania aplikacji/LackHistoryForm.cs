using System;
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

namespace PaintshopAppUI
{
    public partial class LackHistoryForm : Form
    {
        public LackHistoryForm()
        {
            InitializeComponent();
        }

        public void PopulateListView(object sender, EventArgs e)
        {
            listViewHistory.GridLines = true;
            listViewHistory.View = View.Details;

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            SqlDataAdapter sda = new SqlDataAdapter("select * from HISTORIAROBIENIALAKU", connection);
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
                listViewHistory.Items.Add(listitem);
            }
        }

        private void DeleteRowDataBase(object sender, EventArgs e) //USUWANIE ZAZNACZONYCH DANYCH
        {
            if (listViewHistory.SelectedItems.Count > 0) //Zabezpieczenie przed brakiem wyboru wiersza z ListView
            {
                string dataTabela = listViewHistory.SelectedItems[0].SubItems[4].Text;
                string godzinaTabela = listViewHistory.SelectedItems[0].SubItems[1].Text;

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
            else
            {
                MessageBox.Show("Nie wybrano wiersza do usunięcia!");
            }
        }

        private void closeButton_Click(object sender, EventArgs e) //Krzyżyk wyjście z programu
        {
            new ExitWindow().Show();
        }

        private void minimalizeButton_Click(object sender, EventArgs e) //Minimalizacja okna
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e) //Przycisk boczne menu Wyjście z programu
        {
            new ExitWindow().Show();
        }

        private void buttonSettings_Click(object sender, EventArgs e) //Otwarcie nowego okna Ustawienia
        {
            this.Hide();
            var form2 = new SettingForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void HistoriaForm_Load(object sender, EventArgs e)
        {
            PopulateListView (null, null);
            listViewHistory.View = View.Details;
            listViewHistory.FullRowSelect = true;

            //URUCHOMIENIE TIMERA DLA AKTUALNEJ GODZINY
            timer.Start();
            labelCurrentTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void buttonMakeCoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new MainForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelCurrentTime.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }

        private void buttonDeleteHistory_Click(object sender, EventArgs e)
        {
            DeleteRowDataBase(null, null);
            listViewHistory.Items.Clear();
            listViewHistory.Refresh();
            PopulateListView(null, null);
        }

        private void buttonUsun7Dni_Click(object sender, EventArgs e)
        {
            listViewHistory.Items.Clear();
            listViewHistory.Refresh();
            PopulateListView(null, null);
        }

        private void buttonZapiszCSV_Click(object sender, EventArgs e) //Zaisz jako CSV
        {
            DateTime currentDate = DateTime.Now;
            string justDate = currentDate.ToShortDateString();

            //Zadeklarowanie nowego pliku
            SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Wybierz miejsce zapisania pliku",
                FileName = "historia_lakiernia_" + justDate + ".csv",
                Filter = "CSV (*.csv)|*.csv",
                FilterIndex = 0,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            //show the dialog + display the results in a msgbox unless cancelled

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                string[] headers = listViewHistory.Columns
                           .OfType<ColumnHeader>()
                           .Select(header => header.Text.Trim())
                           .ToArray();

                string[][] items = listViewHistory.Items
                            .OfType<ListViewItem>()
                            .Select(lvi => lvi.SubItems
                                .OfType<ListViewItem.ListViewSubItem>()
                                .Select(si => si.Text).ToArray()).ToArray();

                string table = string.Join(",", headers) + Environment.NewLine;
                foreach (string[] a in items)
                {
                    table += string.Join(",", a) + Environment.NewLine;
                }
                table = table.TrimEnd('\r', '\n');
                System.IO.File.WriteAllText(sfd.FileName, table);
            }
        }
    }
}
