using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Project
{
    public partial class ERP_DashBoard : MetroFramework.Forms.MetroForm
    {
        public ERP_DashBoard()
        {
            InitializeComponent();
        }

        private void ERP_DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void SideNavPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MetroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {
            Form1 fmp = new Form1();
            fmp.ShowDialog();
        }
    }
}
