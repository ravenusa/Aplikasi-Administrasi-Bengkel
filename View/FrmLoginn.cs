using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AplikasiBengkelKu.Controller;
namespace AplikasiBengkelKu.View
{
    public partial class FrmLoginn : Form
    {
        public FrmLoginn()
        {
            InitializeComponent();
            txtUserName.Text = "Admin";
            //txtPassword.Text = "12345";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginController controller = new LoginController();

            bool isValidUser = controller.IsValidUser(txtUserName.Text, txtPassword.Text);
            if (isValidUser)
            {
                this.DialogResult = DialogResult.OK;
                this.Visible = false;
                var frm = new FrmUtama();
                frm.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblAnimasi.Left -= 1;
            if (lblAnimasi.Left < -lblAnimasi.Width) lblAnimasi.Left = this.Width;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString();
        }

        private void lblClock_Click(object sender, EventArgs e)
        {

        }
    }
}
