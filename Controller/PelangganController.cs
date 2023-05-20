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
   public class PelangganController
    {
        private PelangganRepository pelangganRepository;
        public int Create(Pelanggan pelanggan)
        {
            int result = 0;


            if (string.IsNullOrEmpty (pelanggan.kd__pelanggan.ToString()))
            {
                MessageBox.Show("Kode Pelanggan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(pelanggan.nama_pel))
            {
                MessageBox.Show("Nama Pelanggan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                pelangganRepository = new PelangganRepository(context);
                result = pelangganRepository.Create(pelanggan);
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
        public int Delete(Pelanggan pelanggan)
        {
            int result = 0;

            if (string.IsNullOrEmpty(pelanggan.kd__pelanggan.ToString()))
            {
                MessageBox.Show("Username harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                pelangganRepository = new PelangganRepository(context);
                result = pelangganRepository.Delete(pelanggan);
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

        public List<Pelanggan> ReadAll()
        {
            List<Pelanggan> list = new List<Pelanggan>();

            using (DbContext context = new DbContext())
            {
                var repository = new PelangganRepository(context);

                list = repository.ReadAll();
            }

            return list;
        }
    }
}

