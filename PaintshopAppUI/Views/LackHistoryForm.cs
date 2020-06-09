using DataAccessLibrary.DataAccess;
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
using DataAccessLibrary.Models;

namespace PaintshopAppUI.Views
{
    public partial class LackHistoryForm : Form
    {
        List<HistoryModel> history = new List<HistoryModel>();

        public LackHistoryForm()
        {
            InitializeComponent();
        }

        public void PopulateListView(object sender, EventArgs e)
        {
            listViewHistory.GridLines = true;
            listViewHistory.View = View.Details;

            HistoryDataAccess db = new HistoryDataAccess();

            history = db.GetHistory();

            foreach (HistoryModel data in history)
            {
                ListViewItem item = new ListViewItem(data.CoatQuantity.ToString());
                item.SubItems.Add(data.CoatTime);
                item.SubItems.Add(data.User);
                item.SubItems.Add(data.CoatType);
                item.SubItems.Add(data.CoatDate);
                listViewHistory.Items.Add(item);
            }
        }

        private void DeleteRowDataBase(object sender, EventArgs e) //USUWANIE ZAZNACZONYCH DANYCH
        {
            if (listViewHistory.SelectedItems.Count > 0) //Zabezpieczenie przed brakiem wyboru wiersza z ListView
            {
                string date = listViewHistory.SelectedItems[0].SubItems[4].Text;
                string coat = listViewHistory.SelectedItems[0].SubItems[3].Text;
                string user = listViewHistory.SelectedItems[0].SubItems[2].Text;
                string hour = listViewHistory.SelectedItems[0].SubItems[1].Text;

                HistoryDataAccess db = new HistoryDataAccess();

                db.DeleteCoatData(date, coat, user, hour);
            }
            else
            {
                MessageBox.Show("You didnt select ant row!");
            }

            listViewHistory.Items.Clear();
            listViewHistory.Refresh();
            PopulateListView(null, null);
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

        private void buttonDelete7Days_Click(object sender, EventArgs e)
        {
            HistoryDataAccess db = new HistoryDataAccess();
            
            db.DeleteCoatData7Days();
            
            listViewHistory.Items.Clear();
            listViewHistory.Refresh();
            PopulateListView(null, null);
        }

        private void buttonSaveCSV_Click(object sender, EventArgs e) //Zaisz jako CSV
        {
            DateTime currentDate = DateTime.Now;
            string justDate = currentDate.ToShortDateString();

            //Zadeklarowanie nowego pliku
            SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Select place to save History data",
                FileName = "history_paintshop_" + justDate + ".csv",
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
