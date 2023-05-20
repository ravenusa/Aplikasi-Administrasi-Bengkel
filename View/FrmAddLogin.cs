using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplikasiBengkelKu.Model.Entity;
using AplikasiBengkelKu.Controller;

namespace AplikasiBengkelKu.View
{
    public partial class FrmAddLogin : Form
    {
        private AddLoginController addUserLoginController = new AddLoginController();
        private bool isNewData = true;

        private AddUserLogin adduserlogin;
        public FrmAddLogin()
        {
            InitializeComponent();
        }

        // constructor untuk inisialisasi data ketika entri data baru

        private void btnSimpanUser_Click(object sender, EventArgs e)
        {
            if (isNewData) adduserlogin = new AddUserLogin();

            adduserlogin.username = txtUser.Text;
            adduserlogin.pass = txtPass.Text;

            int result = 0;

            if (isNewData)
            {
                result = addUserLoginController.Create(adduserlogin);

                if (result > 0)
                {
                    txtUser.Clear();
                    txtPass.Clear();

                    txtUser.Focus();
                }
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (isNewData) adduserlogin = new AddUserLogin();

            adduserlogin.username = txtUser.Text;
            adduserlogin.pass = txtPass.Text;

            int result = 0;

            if (isNewData)
            {
                result = addUserLoginController.Delete(adduserlogin);

                if (result > 0)
                {
                    txtUser.Clear();
                    txtPass.Clear();

                    txtUser.Focus();
                }
            }
        }
    }
}


        /* if (isNewData) // tambah data baru, panggil method Create
         {
             // panggil operasi CRUD
             result = controller.Create(log);

             if (result > 0) // tambah data berhasil
             {
                 OnCreate(log); // panggil event OnCreate

                 // reset form input, utk persiapan input data berikutnya
                 txtUser.Clear();
                 txtPass.Clear();

                 txtUser.Focus();
             }
         }
         else // edit data, panggil method Update
         {
             // panggil operasi CRUD
             result = controller.Update(log);

             if (result > 0)
             {
                 OnUpdate(log); // panggil event OnUpdate
                 this.Close();
             }
         }*/
