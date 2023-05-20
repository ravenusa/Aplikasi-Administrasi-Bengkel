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
   public class SparepartController
    {
        SparepartRepository sparepartRepository;
        public int Create(Sparepart sparepart)
        {
            int result = 0;

            if (string.IsNullOrEmpty(sparepart.Username))
            {
                MessageBox.Show("Username harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(sparepart.nama_barang))
            {
                MessageBox.Show("Nama Barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(sparepart.kd_barang))
            {
                MessageBox.Show("Kode Barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(sparepart.jenis_barang))
            {
                MessageBox.Show("Jenis Barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(sparepart.harga))
            {
                MessageBox.Show("Harga harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(sparepart.kd_supplier))
            {
                MessageBox.Show("Kode Supplier harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(sparepart.kd_pelanggan))
            {
                MessageBox.Show("Kode Pelanggan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(sparepart.kd_barang_jual))
            {
                MessageBox.Show("Kode Barang Jual harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(sparepart.kd_barang_beli))
            {
                MessageBox.Show("Kode Barang Beli harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(sparepart.jumlah))
            {
                MessageBox.Show("Jumlah Barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                sparepartRepository = new SparepartRepository(context);
                result = sparepartRepository.Create(sparepart);
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
        public int Update(Sparepart sparepart)
        {
            int result = 0;

            if (string.IsNullOrEmpty(sparepart.kd_barang))
            {
                MessageBox.Show("NPM harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(sparepart.nama_barang))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                sparepartRepository = new SparepartRepository(context);

                result = sparepartRepository.Update(sparepart);
            }

            if (result > 0)
            {
                MessageBox.Show("Data berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Sparepart sparepart)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                sparepartRepository = new SparepartRepository(context);
                result = sparepartRepository.Delete(sparepart);
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
        public List<Sparepart> ReadAll()
        {
            List<Sparepart> list = new List<Sparepart>();

            using (DbContext context = new DbContext())
            {
                var repository = new SparepartRepository(context);

                list = repository.ReadAll();
            }

            return list;
        }
        public List<Sparepart> ReadByNama(string nama)
        {
            List<Sparepart> list = new List<Sparepart>();
            using (DbContext context = new DbContext())
            {
                sparepartRepository = new SparepartRepository(context);

                list = sparepartRepository.ReadByNama(nama);
            }

            return list;
        }
        public List<Sparepart> ReadByNamaBarang(string nb)
        {
            List<Sparepart> list = new List<Sparepart>();
            using (DbContext context = new DbContext())
            {
                sparepartRepository = new SparepartRepository(context);

                list = sparepartRepository.ReadByNamaBarang(nb);
            }

            return list;
        }
        public List<Sparepart> ReadByKd(string kd)
        {
            List<Sparepart> list = new List<Sparepart>();
            using (DbContext context = new DbContext())
            {
                sparepartRepository = new SparepartRepository(context);

                list = sparepartRepository.ReadByKd(kd);
            }

            return list;
        }
        public List<Sparepart> ReadByJnsBarang(string jnsb)
        {
            List<Sparepart> list = new List<Sparepart>();
            using (DbContext context = new DbContext())
            {
                sparepartRepository = new SparepartRepository(context);

                list = sparepartRepository.ReadByJnsBarang(jnsb);
            }

            return list;
        }
        public List<Sparepart> ReadByKdSupp(string kdSupp)
        {
            List<Sparepart> list = new List<Sparepart>();
            using (DbContext context = new DbContext())
            {
                sparepartRepository = new SparepartRepository(context);

                list = sparepartRepository.ReadByKdSupp(kdSupp);
            }

            return list;
        }
    }
}