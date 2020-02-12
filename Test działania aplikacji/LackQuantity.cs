using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_działania_aplikacji
{
    public partial class LackQuantity : Form
    {
        public LackQuantity()
        {
            InitializeComponent();
        }

        //string coatTypeName;

        //public string TheValue
        //{
        //    get { return coatTypeName; }
        //}

        private void coatUserControl(object sender, EventArgs e)
        {
            //if (TheValue == "sipiol")
            //{
            //    sipiolObliczanie1.Show();
            //    permutexCount1.Hide();
            //    label1.Text = TheValue;
            //}
            //if (TheValue == "permutex")
            //{
            //    permutexCount1.Show();
            //    sipiolObliczanie1.Hide();
            //    label1.Text = TheValue;
            //}
            //else
            //{
            //    sipiolObliczanie1.Hide();
            //    permutexCount1.Hide();
            //    label1.Text = TheValue;
            //}
        }

        private void buttonRobienieLaku_Click(object sender, EventArgs e)
        {
            new CancelRobienieLaku().Show();
        }

        private void buttonHistoria_Click(object sender, EventArgs e)
        {
            new CancelRobienieLaku().Show();
        }

        private void buttonUstawienia_Click(object sender, EventArgs e)
        {
            new CancelRobienieLaku().Show();
        }

        private void buttonWyjscie_Click(object sender, EventArgs e)
        {
            new ExitWindow().Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            new ExitWindow().Show();
        }

        private void minimalizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelCurrentTime.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }

        public void OpenSipiolUserControl()
        {
            sipiolObliczanie1.Show();
        }

        private void LackQuantity_Load(object sender, EventArgs e)
        {
            timer.Start();
            labelCurrentTime.Text = DateTime.Now.ToLongTimeString();
            sipiolObliczanie1.Hide();
            permutexCount1.Hide();

        }
    }
}
