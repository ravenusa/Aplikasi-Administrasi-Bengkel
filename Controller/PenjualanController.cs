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
   public class PenjualanController
    {
        PenjualanRepository penjualanRepository;
        public int Create(Penjualan penjualan)
        {
            int result = 0;

            if (string.IsNullOrEmpty(penjualan.hrg_brg_jual))
            {
                MessageBox.Show("Harga harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(penjualan.kd_brg_jual))
            {
                MessageBox.Show("Kode Barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(penjualan.tgl_brg_jual))
            {
                MessageBox.Show("Tanggal harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(penjualan.kd_pelanggan))
            {
                MessageBox.Show("Kode Pelanggan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(penjualan.jml_brg_jual))
            {
                MessageBox.Show("Jumlah harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                penjualanRepository = new PenjualanRepository(context);
                result = penjualanRepository.Create(penjualan);
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
        public int Update(Penjualan penjualan)
        {
            int result = 0;

            if (string.IsNullOrEmpty(penjualan.kd_brg_jual))
            {
                MessageBox.Show("NPM harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(penjualan.nm_brg_jual))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(penjualan.jml_brg_jual))
            {
                MessageBox.Show("Angkatan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }



            using (DbContext context = new DbContext())
            {
                penjualanRepository = new PenjualanRepository(context);

                result = penjualanRepository.Update(penjualan);
            }

            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data mahasiswa gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Penjualan penjualan)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                penjualanRepository = new PenjualanRepository(context);
                result = penjualanRepository.Delete(penjualan);
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
        public List<Penjualan> ReadAll()
        {
            List<Penjualan> list = new List<Penjualan>();

            using (DbContext context = new DbContext())
            {
                var repository = new PenjualanRepository(context);

                list = repository.ReadAll();
            }

            return list;
        }
        public List<Penjualan> ReadByNama(string nama)
        {
            List<Penjualan> list = new List<Penjualan>();
            using (DbContext context = new DbContext())
            {
                penjualanRepository = new PenjualanRepository(context);

                list = penjualanRepository.ReadByNama(nama);
            }

            return list;
        }
        public List<Penjualan> ReadByKd(string kd)
        {
            List<Penjualan> list = new List<Penjualan>();
            using (DbContext context = new DbContext())
            {
                penjualanRepository = new PenjualanRepository(context);

                list = penjualanRepository.ReadByKd(kd);
            }

            return list;
        }
    }
}
