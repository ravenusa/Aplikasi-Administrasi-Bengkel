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
    public class PembelianController
    {
        PembelianRepository pembelianRepository;
        public int Create(Pembelian pembelian)
        {
            int result = 0;

            if (string.IsNullOrEmpty(pembelian.hrg_brg_bli))
            {
                MessageBox.Show("Harga harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(pembelian.kd_brg_bli))
            {
                MessageBox.Show("Kode Barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pembelian.tgl_brg_bli))
            {
                MessageBox.Show("Tanggal harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pembelian.supplier_brg_bli))
            {
                MessageBox.Show("Kode Supplier harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pembelian.jml_brg_bli))
            {
                MessageBox.Show("Jumlah harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                pembelianRepository = new PembelianRepository(context);
                result = pembelianRepository.Create(pembelian);
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
        public int Update(Pembelian pembelian)
        {
            int result = 0;

            if (string.IsNullOrEmpty(pembelian.kd_brg_bli))
            {
                MessageBox.Show("NPM harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(pembelian.nm_brg_bli))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(pembelian.jml_brg_bli))
            {
                MessageBox.Show("Angkatan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }



            using (DbContext context = new DbContext())
            {
                pembelianRepository = new PembelianRepository(context);

                result = pembelianRepository.Update(pembelian);
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

        public int Delete(Pembelian pembelian)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                pembelianRepository = new PembelianRepository(context);
                result = pembelianRepository.Delete(pembelian);
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
    public List<Pembelian> ReadAll()
        {
            List<Pembelian> list = new List<Pembelian>();

            using (DbContext context = new DbContext())
            {
                var repository = new PembelianRepository(context);

                list = repository.ReadAll();
            }

            return list;
        }
        public List<Pembelian> ReadByNama(string nama)
        {
            List<Pembelian> list = new List<Pembelian>();
            using (DbContext context = new DbContext())
            {
                pembelianRepository = new PembelianRepository(context);

                list = pembelianRepository.ReadByNama(nama);
            }

            return list;
        }
        public List<Pembelian> ReadByKd(string kd)
        {
            List<Pembelian> list = new List<Pembelian>();
            using (DbContext context = new DbContext())
            {
                pembelianRepository = new PembelianRepository(context);

                list = pembelianRepository.ReadByKd(kd);
            }

            return list;
        }
    }
}
