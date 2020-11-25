using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace lockScreen
{
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                Login();
            }
            catch 
            {

            }
            
        }

        private void Login()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string psw = appSettings["psw"];
                if (txtPsw.Text.Equals(psw))
                {
                    Application.Exit();
                }
            }
            catch
            {

            }
        }
        

        private void frmConnexion_Load(object sender, EventArgs e)
        {
            try
            {
                this.TopMost = true;
                txtPsw.Focus();
            }
            catch
            {

            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch
            {

            }

        }

        private void frmConnexion_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Login();
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch
            {

            }
        }
    }
}
