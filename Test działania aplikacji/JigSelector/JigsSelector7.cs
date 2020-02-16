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

namespace Test_działania_aplikacji
{
    public partial class JigsSelector7 : Form
    {
        public JigsSelector7()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JigsSelector1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            string sql = "Delete from JIGLIST Where JIGNUMBER = '7'";

            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("BŁĄD:" + ex.Message);
                }
            }
        }

        private void buttonJig1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            string sql = "insert into JIGLIST ([JIGNUMBER], [JIGNAME]) values(@Jignumber,@Jigname)";

            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Jignumber", "7");
                        cmd.Parameters.AddWithValue("@Jigname", "F33DS1");

                        // Wiadomość o dodaniu nowej linijki bazy danych
                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                            Close();
                        else
                            MessageBox.Show("Nie dodano Wózka");
                    }
                }
                catch (Exception ex)
                {
                    // Wyświetlanie błędów
                    MessageBox.Show("BŁĄD:" + ex.Message);
                }
            }
        }

        private void buttonJig2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            string sql = "insert into JIGLIST ([JIGNUMBER], [JIGNAME]) values(@Jignumber,@Jigname)";

            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Jignumber", "7");
                        cmd.Parameters.AddWithValue("@Jigname", "F33DS2");

                        // Wiadomość o dodaniu nowej linijki bazy danych
                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                            Close();
                        else
                            MessageBox.Show("Nie dodano Wózka");
                    }
                }
                catch (Exception ex)
                {
                    // Wyświetlanie błędów
                    MessageBox.Show("BŁĄD:" + ex.Message);
                }
            }
        }

        private void buttonJig3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            string sql = "insert into JIGLIST ([JIGNUMBER], [JIGNAME]) values(@Jignumber,@Jigname)";

            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Jignumber", "7");
                        cmd.Parameters.AddWithValue("@Jigname", "VWFSI485");

                        // Wiadomość o dodaniu nowej linijki bazy danych
                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                            Close();
                        else
                            MessageBox.Show("Nie dodano Wózka");
                    }
                }
                catch (Exception ex)
                {
                    // Wyświetlanie błędów
                    MessageBox.Show("BŁĄD:" + ex.Message);
                }
            }
        }

        private void buttonJig4_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            string sql = "insert into JIGLIST ([JIGNUMBER], [JIGNAME]) values(@Jignumber,@Jigname)";

            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Jignumber", "7");
                        cmd.Parameters.AddWithValue("@Jigname", "Targa");

                        // Wiadomość o dodaniu nowej linijki bazy danych
                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                            Close();
                        else
                            MessageBox.Show("Nie dodano Wózka");
                    }
                }
                catch (Exception ex)
                {
                    // Wyświetlanie błędów
                    MessageBox.Show("BŁĄD:" + ex.Message);
                }
            }
        }

        private void buttonJig5_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            string sql = "insert into JIGLIST ([JIGNUMBER], [JIGNAME]) values(@Jignumber,@Jigname)";

            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Jignumber", "7");
                        cmd.Parameters.AddWithValue("@Jigname", "R231HD");

                        // Wiadomość o dodaniu nowej linijki bazy danych
                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                            Close();
                        else
                            MessageBox.Show("Nie dodano Wózka");
                    }
                }
                catch (Exception ex)
                {
                    // Wyświetlanie błędów
                    MessageBox.Show("BŁĄD:" + ex.Message);
                }
            }
        }

        private void buttonJig6_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\UzytkownicyDataBase.mdf;Integrated Security=True;Connect Timeout=30;");

            string sql = "insert into JIGLIST ([JIGNUMBER], [JIGNAME]) values(@Jignumber,@Jigname)";

            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Jignumber", "7");
                        cmd.Parameters.AddWithValue("@Jigname", "VWTH");

                        // Wiadomość o dodaniu nowej linijki bazy danych
                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                            Close();
                        else
                            MessageBox.Show("Nie dodano Wózka");
                    }
                }
                catch (Exception ex)
                {
                    // Wyświetlanie błędów
                    MessageBox.Show("BŁĄD:" + ex.Message);
                }
            }
        }
    }
}
