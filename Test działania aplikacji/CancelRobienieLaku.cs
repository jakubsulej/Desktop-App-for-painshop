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
    public partial class CancelRobienieLaku : Form
    {
        public CancelRobienieLaku()
        {
            InitializeComponent();
            System.Media.SystemSounds.Beep.Play();
        }

        private void buttonCancelCancelRobienieLaku_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonExitCancelRobienieLaku_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //var form2 = new MenuGlowne();
            //form2.Closed += (s, args) => this.Close();
            //form2.Show();
            this.Hide();
            this.Close();
            MenuGlowne.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
