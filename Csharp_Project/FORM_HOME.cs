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
    public partial class FORM_HOME : MetroFramework.Forms.MetroForm
    {
        public string userType;
        public FORM_HOME()
        {
            InitializeComponent();
 
        }

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_CATEGORIES fmcg = new FORM_MANAGE_CATEGORIES();
            fmcg.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_CUSTOMER fmcm = new FORM_MANAGE_CUSTOMER();
            fmcm.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_ORDER fmo = new FORM_MANAGE_ORDER();
            fmo.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_USER fmus = new FORM_MANAGE_USER();
            fmus.ShowDialog();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_PRODUCT fmp = new FORM_MANAGE_PRODUCT();
            fmp.ShowDialog();
        }

        private void FORM_HOME_Load(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            Form1 fmp = new Form1();
            fmp.ShowDialog();
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            ERP_DashBoard fmp = new ERP_DashBoard();
            fmp.ShowDialog();
        }
    }
}
