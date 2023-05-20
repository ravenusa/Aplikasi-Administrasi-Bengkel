using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using AplikasiBengkelKu.View;

namespace AplikasiBengkelKu
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var frmLogin = new FrmLoginn();
            frmLogin.ShowDialog();
             /*if (frmLogin.ShowDialog() == DialogResult.OK)
             {

                  Application.Run(new FrmUtama());
             }
             else
                 Application.Exit();*/
        }
    }
}
