using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplikasiBengkelKu.Model.Entity;
using AplikasiBengkelKu.Model.Repository;
using AplikasiBengkelKu.Model.Context;

namespace AplikasiBengkelKu.Controller
{
    public class AddLoginController
    {
        private AddLoginRepository adduserrepo;
        public int Create(AddUserLogin adduserLogin)
        {
            int result = 0;

            if (string.IsNullOrEmpty(adduserLogin.username.ToString()))
            {
                MessageBox.Show("Username harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(adduserLogin.pass))
            {
                MessageBox.Show("Password harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                adduserrepo = new AddLoginRepository(context);
                result = adduserrepo.Create(adduserLogin);
            }
            if (result > 0)
            {
                MessageBox.Show("Data berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
        public int Delete(AddUserLogin adduserLogin)
        {
            int result = 0;

            if (string.IsNullOrEmpty(adduserLogin.username.ToString()))
            {
                MessageBox.Show("Username harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                adduserrepo = new AddLoginRepository(context);
                result = adduserrepo.Delete(adduserLogin);
            }
            if (result > 0)
            {
                MessageBox.Show("Data berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}
