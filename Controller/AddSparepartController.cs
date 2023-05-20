using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using AplikasiBengkelKu.Model.Entity;
using AplikasiBengkelKu.Model.Context;
using AplikasiBengkelKu.Model.Repository;

namespace AplikasiBengkelKu.Controller
{
    public class AddSparepartController
    {
        private AddSparepartRepository AddSparepart;
        public int Create(AddSparepart addSparepart)
        {
            int result = 0;

            if (string.IsNullOrEmpty(addSparepart.Username.ToString()))
            {
                MessageBox.Show("Username harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(addSparepart.nama_barang.ToString()))
            {
                MessageBox.Show("harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                AddSparepart = new AddSparepartRepository(context);
                result = AddSparepart.Create(addSparepart);
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
        public int Delete(AddSparepart addSparepart)
        {
            int result = 0;

            if (string.IsNullOrEmpty(addSparepart.Username.ToString()))
            {
                MessageBox.Show("Username harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                AddSparepart = new AddSparepartRepository(context);
                result = AddSparepart.Delete(addSparepart);
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
        public int Update(AddSparepart addSparepart)
        {
            int result = 0;


            if (string.IsNullOrEmpty(addSparepart.nama_barang.ToString()))
            {
                MessageBox.Show("Nama Barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                AddSparepart = new AddSparepartRepository(context);
                result = AddSparepart.Update(addSparepart);
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
    }
}
