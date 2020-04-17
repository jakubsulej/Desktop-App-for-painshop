using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintshopAppUI
{
    public partial class CancelRobienieLaku : Form
    {
        public CancelRobienieLaku()
        {
            InitializeComponent();
        }

        private void buttonCancelCancelRobienieLaku_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonExitCancelRobienieLaku_Click(object sender, EventArgs e)
        {
            var form2 = new MainForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CancelRobienieLaku_Load(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
        }
    }
}
