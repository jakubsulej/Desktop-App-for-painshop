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
using PaintshopAppUI.Views.JigViews;

namespace PaintshopAppUI.Views
{
    public partial class SettingForm : Form
    {
        List<PersonModel> people = new List<PersonModel>();

        List<JigModel> jigs = new List<JigModel>();

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
                MessageBox.Show("User name " + textBoxUserName.Text + " already exist. Please declare another user name.");
            }
            else
            {
                MessageBox.Show("User has been sucesfully created.");
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

            timer.Start();
            labelCurrentTime.Text = DateTime.Now.ToLongTimeString();

            displayJigLabel(null, null);
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

        private void displayJigLabel(object sender, EventArgs e)
        {
            JigsDataAccess db = new JigsDataAccess();

            jigs = db.DisplayJigLabels();

            foreach (JigModel jig in jigs)
            {
                if (jig.JigNumber == 1)
                {
                    labelJig1.Text = jig.JigName;
                }
                if (jig.JigNumber == 2)
                {
                    labelJig2.Text = jig.JigName;
                }
                if (jig.JigNumber == 3)
                {
                    labelJig3.Text = jig.JigName;
                }
                if (jig.JigNumber == 4)
                {
                    labelJig4.Text = jig.JigName;
                }
                if (jig.JigNumber == 5)
                {
                    labelJig5.Text = jig.JigName;
                }
                if (jig.JigNumber == 6)
                {
                    labelJig6.Text = jig.JigName;
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            displayJigLabel(null, null);
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
        }

        private void buttonJig2_Click(object sender, EventArgs e)
        {
            new JigsSelector2().Show();
        }

        private void buttonJig3_Click(object sender, EventArgs e)
        {
            new JigsSelector3().Show();
        }

        private void buttonJig4_Click(object sender, EventArgs e)
        {
            new JigsSelector4().Show();
        }

        private void buttonJig5_Click(object sender, EventArgs e)
        {
            new JigsSelector5().Show();
        }

        private void buttonJig6_Click(object sender, EventArgs e)
        {
            new JigsSelector6().Show();
        }
    }
}
