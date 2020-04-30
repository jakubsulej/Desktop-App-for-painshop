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

namespace PaintshopAppUI
{
    public partial class JigsSelector4 : Form
    {
        public JigsSelector4()
        {
            InitializeComponent();
        }

        int jigNumber = 4;

        private void closeButton_Click(object sender, EventArgs e)
        {
            CloseThisPopupForm(null, null);
        }

        private void CloseThisPopupForm(object sender, EventArgs e)
        {
            Close();
        }

        private void JigsSelector1_Load(object sender, EventArgs e)
        {
            JigsDataAccess db = new JigsDataAccess();

            db.DeleteJigType(jigNumber);
        }

        private void buttonJig1_Click(object sender, EventArgs e)
        {
            string jigName = "F33DS1";
            JigsDataAccess db = new JigsDataAccess();

            db.SetJigType(jigNumber, jigName);

            CloseThisPopupForm(null, null);
        }

        private void buttonJig2_Click(object sender, EventArgs e)
        {
            string jigName = "F33DS2";
            JigsDataAccess db = new JigsDataAccess();

            db.SetJigType(jigNumber, jigName);

            CloseThisPopupForm(null, null);
        }

        private void buttonJig3_Click(object sender, EventArgs e)
        {
            string jigName = "VWFSI485";
            JigsDataAccess db = new JigsDataAccess();

            db.SetJigType(jigNumber, jigName);

            CloseThisPopupForm(null, null);
        }

        private void buttonJig4_Click(object sender, EventArgs e)
        {
            string jigName = "Targa";
            JigsDataAccess db = new JigsDataAccess();

            db.SetJigType(jigNumber, jigName);

            CloseThisPopupForm(null, null);
        }

        private void buttonJig5_Click(object sender, EventArgs e)
        {
            string jigName = "R231HD";
            JigsDataAccess db = new JigsDataAccess();

            db.SetJigType(jigNumber, jigName);

            CloseThisPopupForm(null, null);
        }

        private void buttonJig6_Click(object sender, EventArgs e)
        {
            string jigName = "VWTH";
            JigsDataAccess db = new JigsDataAccess();

            db.SetJigType(jigNumber, jigName);

            CloseThisPopupForm(null, null);
        }
    }
}
