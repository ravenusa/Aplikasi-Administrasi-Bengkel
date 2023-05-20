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
   public class SupplierController
    {
            private SupplierRepository supplierRepository;
            public int Create(Supplier supplier)
            {
                int result = 0;

                if (string.IsNullOrEmpty(supplier.kd_supplier))
                {
                    MessageBox.Show("Kode Supplier harus diisi !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
                }

                if (string.IsNullOrEmpty(supplier.kd__pelanggan))
                {
                    MessageBox.Show("Kode Pelanggan harus diisi !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
                }

                using (DbContext context = new DbContext())
                {
                    supplierRepository = new SupplierRepository(context);
                    result = supplierRepository.Create(supplier);
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
            public int Delete(Supplier supplier)
            {
                int result = 0;

                if (string.IsNullOrEmpty(supplier.kd_supplier))
                {
                    MessageBox.Show("Kode Supplier harus diisi !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
                }

                using (DbContext context = new DbContext())
                {
                    supplierRepository = new SupplierRepository(context);
                    result = supplierRepository.Delete(supplier);
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

        public List<Supplier> ReadAll()
        {
            List<Supplier> list = new List<Supplier>();

            using (DbContext context = new DbContext())
            {
                var repository = new SupplierRepository(context);

                list = repository.ReadAll();
            }

            return list;
        }
    }
}
