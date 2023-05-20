using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiBengkelKu.View
{
    public partial class FrmReff : Form
    {
        public FrmReff()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblKredit.Left -= 2;
            if (lblKredit.Left < -lblKredit.Width) lblKredit.Left = this.Width;
        }
    }
}
