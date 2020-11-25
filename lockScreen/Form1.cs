using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace lockScreen
{
    public partial class freezeScreen : Form
    {
        //private static int ecranNumber = 0;
       
        public freezeScreen()
        {
            try
            {
                //ecranNumber++;
                InitializeComponent();
                //this.lblMsg.Text = "Screen number:"+ecranNumber.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;
                var cp = base.CreateParams;
                cp.ExStyle |= 0x80;  // Turn on WS_EX_TOOLWINDOW
                cp.ClassStyle |= CS_NOCLOSE;
                return cp;
            }

        }

        private void freezeScreen_Load(object sender, EventArgs e)
        {
            try
            {
                this.ShowInTaskbar = false;
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Opacity = 0.70;
                this.TopMost = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void freezeScreen_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.H)
                {
                    frmConnexion frm = new frmConnexion();
                    frm.ShowDialog();

                }
                if (e.Alt && e.KeyCode == Keys.F4)
                {
                   
                }
                if (e.KeyCode == Keys.LWin || e.KeyCode == Keys.RWin)
                {
                    MessageBox.Show("Tentative de piratage de compte, un email est entrain d'être envoyé à Adnane!!!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Application.Restart();
                }
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }
        }

        private void freezeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.TaskManagerClosing)
                {
              
                    //Application.Restart();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Thread.Sleep(2000);
        }

        private void freezeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason != CloseReason.ApplicationExitCall)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Thread.Sleep(2000);
        }

        private void freezeScreen_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                lblTime.Text = DateTime.Now.ToLongTimeString().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
