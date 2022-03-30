using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad_OOP_Project_2019
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lblproductname.Text = string.Format("Product name : {0}", Application.ProductName);
            lblproductversion.Text = string.Format("Version : {0}", Application.ProductVersion);
            lblcopyright.Text = "Copyright ©  2020";
        }
    }
}
    

       