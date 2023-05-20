using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using AplikasiBengkelKu.Model.Context;
using AplikasiBengkelKu.Model.Repository;

namespace AplikasiBengkelKu.Controller
{
   public class LoginController
    {
        private LoginRepository repo;
        public bool IsValidUser(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("User name harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            bool isValidUser = false;

            using (DbContext context = new DbContext())
            {
                repo = new LoginRepository(context);

                isValidUser = repo.IsValidUser(userName, password);
            }

            if (!isValidUser)
            {
                MessageBox.Show("User name atau password salah !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }
    }
}
