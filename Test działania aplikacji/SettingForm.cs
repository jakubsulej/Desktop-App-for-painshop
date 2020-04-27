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
using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;

namespace PaintshopAppUI
{
    public partial class SettingForm : Form
    {
        List<PersonModel> people = new List<PersonModel>();

        public SettingForm()
        {
            InitializeComponent();
        }

        public void AddPerson()
        {
            PeopleDataAccess db = new PeopleDataAccess();

            db.AddPerson(textBoxUserName.Text, textBoxUserPassword.Text, comboBoxUserAdminStatus.SelectedItem.ToString());

            if(PeopleDataAccess.errorMessage == true)
            {
                MessageBox.Show("User name: " + textBoxUserName.Text + " already exist. Please declare another user name.");
            }
            else
            {
                MessageBox.Show("User had been sucesfull added.");
            }
        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            AddPerson();

            listViewUsers.Items.Clear();
            listViewUsers.Refresh();

            PopulateListView(null, null);
        }

        private void buttonUpdatePerson_Click(object sender, EventArgs e)
        {
            PeopleDataAccess db = new PeopleDataAccess();

            db.UpdatePerson(textBoxUserName.Text, textBoxUserPassword.Text, comboBoxUserAdminStatus.SelectedItem.ToString());

            listViewUsers.Items.Clear();
            listViewUsers.Refresh();
            PopulateListView(null, null);
        }

        private void UstawieniaForm_Load(object sender, EventArgs e)
        {
            PopulateListView(null, null);
            listViewUsers.View = View.Details;
            listViewUsers.FullRowSelect = true;

            //URUCHOMIENIE TIMERA DLA GODZINY
            timer.Start();
            labelCurrentTime.Text = DateTime.Now.ToLongTimeString();

            //ODCZYT Z BAZY DANYCH AKTUALNYCH WÓZKÓW
            displayJigLabels(null, null);
        }

        private void buttonForceUpdateListView_Click(object sender, EventArgs e)
        {
            listViewUsers.Items.Clear();
            listViewUsers.Refresh();
            PopulateListView(null, null);
        } 

        public void PopulateListView(object sender, EventArgs e)
        {
            listViewUsers.GridLines = true;
            listViewUsers.View = View.Details; 

            PeopleDataAccess db = new PeopleDataAccess();

            people = db.GetPeople();

            foreach(PersonModel person in people)
            {
                ListViewItem item = new ListViewItem(person.UserName);
                item.SubItems.Add(person.Password);
                item.SubItems.Add(person.Role);
                listViewUsers.Items.Add(item);
            }
        }

        private void listViewUsers_MouseClick(object sender, MouseEventArgs e)
        {
            String user = listViewUsers.SelectedItems[0].SubItems[0].Text;
            String password = listViewUsers.SelectedItems[0].SubItems[1].Text;
            String status = listViewUsers.SelectedItems[0].SubItems[2].Text;

            textBoxUserName.Text = user.Trim();
            textBoxUserPassword.Text = password.Trim();

            if (status.Equals("admin"))
            {
                comboBoxUserAdminStatus.SelectedIndex = 0;
            }
            if (status.Equals("user"))
            {
                comboBoxUserAdminStatus.SelectedIndex = 1;
            }
            else
            {
                comboBoxUserAdminStatus.SelectedIndex = 0;
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            PeopleDataAccess db = new PeopleDataAccess();

            db.DeletePerson(textBoxUserName.Text, textBoxUserPassword.Text, comboBoxUserAdminStatus.SelectedItem.ToString());

            listViewUsers.Items.Clear();
            listViewUsers.Refresh();
            PopulateListView(null, null);
        }

        private void displayJigLabels(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            string jigName;

            connection.Open();
            {
                SqlCommand cmdLabel1 = new SqlCommand("select JIGNAME from JIGLIST where JIGNUMBER ='1'", connection);

                SqlDataReader read = cmdLabel1.ExecuteReader();

                while (read.Read())
                {
                    jigName = (read["JIGNAME"].ToString().Trim());
                    labelJig1.Text = jigName.Trim();
                }
                read.Close();
            }

            {
                SqlCommand cmdLabel2 = new SqlCommand("select JIGNAME from JIGLIST where JIGNUMBER ='2'", connection);

                SqlDataReader read = cmdLabel2.ExecuteReader();

                while (read.Read())
                {
                    jigName = (read["JIGNAME"].ToString().Trim());
                    labelJig2.Text = jigName.Trim();
                }
                read.Close();
            }

            {
                SqlCommand cmdLabel3 = new SqlCommand("select JIGNAME from JIGLIST where JIGNUMBER ='3'", connection);

                SqlDataReader read = cmdLabel3.ExecuteReader();

                while (read.Read())
                {
                    jigName = (read["JIGNAME"].ToString().Trim());
                    labelJig3.Text = jigName.Trim();
                }
                read.Close();
            }

            {
                SqlCommand cmdLabel4 = new SqlCommand("select JIGNAME from JIGLIST where JIGNUMBER ='4'", connection);

                SqlDataReader read = cmdLabel4.ExecuteReader();

                while (read.Read())
                {
                    jigName = (read["JIGNAME"].ToString().Trim());
                    labelJig4.Text = jigName.Trim();
                }
                read.Close();
            }

            {
                SqlCommand cmdLabel5 = new SqlCommand("select JIGNAME from JIGLIST where JIGNUMBER ='5'", connection);

                SqlDataReader read = cmdLabel5.ExecuteReader();

                while (read.Read())
                {
                    jigName = (read["JIGNAME"].ToString().Trim());
                    labelJig5.Text = jigName.Trim();
                }
                read.Close();
            }

            {
                SqlCommand cmdLabel6 = new SqlCommand("select JIGNAME from JIGLIST where JIGNUMBER ='6'", connection);

                SqlDataReader read = cmdLabel6.ExecuteReader();

                while (read.Read())
                {
                    jigName = (read["JIGNAME"].ToString().Trim());
                    labelJig6.Text = jigName.Trim();
                }
                read.Close();
            }

            {
                SqlCommand cmdLabel7 = new SqlCommand("select JIGNAME from JIGLIST where JIGNUMBER ='7'", connection);

                SqlDataReader read = cmdLabel7.ExecuteReader();

                while (read.Read())
                {
                    jigName = (read["JIGNAME"].ToString().Trim());
                    labelJig7.Text = jigName.Trim();
                }
                read.Close();
            }

            {
                SqlCommand cmdLabel8 = new SqlCommand("select JIGNAME from JIGLIST where JIGNUMBER ='8'", connection);

                SqlDataReader read = cmdLabel8.ExecuteReader();

                while (read.Read())
                {
                    jigName = (read["JIGNAME"].ToString().Trim());
                    labelJig8.Text = jigName.Trim();
                }
                read.Close();
            }

            {
                SqlCommand cmdLabel9 = new SqlCommand("select JIGNAME from JIGLIST where JIGNUMBER ='9'", connection);

                SqlDataReader read = cmdLabel9.ExecuteReader();

                while (read.Read())
                {
                    jigName = (read["JIGNAME"].ToString().Trim());
                    labelJig9.Text = jigName.Trim();
                }
                read.Close();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            displayJigLabels(null, null);
        }

        private void closeButton_Click(object sender, EventArgs e) //Krzyżyk wyjście z programu
        {
            new ExitWindow().Show();
        }

        private void minimalizeButton_Click(object sender, EventArgs e) //Minimalizacja okna
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonExit_Click(object sender, EventArgs e) //Przycisk bocznego menu Wyjście z programu.
        {
            new ExitWindow().Show();
        }

        private void ButtonHistory_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonHistory.Height;
            SidePanel.Top = buttonHistory.Top;

            this.Hide();
            var form2 = new LackHistoryForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void ButtonMakeCoat_Click(object sender, EventArgs e)
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

        private void buttonJig1_Click(object sender, EventArgs e)
        {
            new JigsSelector1().Show();
            displayJigLabels(null, null);
        }

        private void buttonJig2_Click(object sender, EventArgs e)
        {
            new JigsSelector2().Show();
            displayJigLabels(null, null);
        }

        private void buttonJig3_Click(object sender, EventArgs e)
        {
            new JigsSelector3().Show();
            displayJigLabels(null, null);
        }

        private void buttonJig4_Click(object sender, EventArgs e)
        {
            new JigsSelector4().Show();
            displayJigLabels(null, null);
        }

        private void buttonJig5_Click(object sender, EventArgs e)
        {
            new JigsSelector5().Show();
            displayJigLabels(null, null);
        }

        private void buttonJig6_Click(object sender, EventArgs e)
        {
            new JigsSelector6().Show();
            displayJigLabels(null, null);
        }

        private void buttonJig7_Click(object sender, EventArgs e)
        {
            new JigsSelector7().Show();
            displayJigLabels(null, null);
        }

        private void buttonJig8_Click(object sender, EventArgs e)
        {
            new JigsSelector8().Show();
            displayJigLabels(null, null);
        }

        private void buttonJig9_Click(object sender, EventArgs e)
        {
            new JigsSelector9().Show();
            displayJigLabels(null, null);
        }
    }
}
