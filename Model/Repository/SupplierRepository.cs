using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AplikasiBengkelKu.Model.Entity;
using AplikasiBengkelKu.Model.Context;

namespace AplikasiBengkelKu.Model.Repository
{
   public class SupplierRepository
    {
        private SqlConnection _conn;
        public SupplierRepository(DbContext Context)
        {
            _conn = Context.Conn;
        }
        public int Create(Supplier supplier)
        {
            int result = 0;
            string sql = @"insert into supplier (kode_supplier,kode_pelanggan)
                            values (@kd_supp, @kd_pelang)";
            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@kd_supp", supplier.kd_supplier);
                cmd.Parameters.AddWithValue("@kd_pelang", supplier.kd__pelanggan);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }
        public int Delete(Supplier supplier)
        {
            int result = 0;

            string sql = @"delete from supplier
                           where kode_supplier = @kd_sup";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@kd_sup", supplier.kd_supplier);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }
        public List<Supplier> ReadAll()
        {
            List<Supplier> list = new List<Supplier>();

            try
            {
                string sql = @"select * from supplier";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Supplier spr = new Supplier();
                            spr.kd_supplier = dtr["kode_supplier"].ToString();
                            spr.kd__pelanggan = dtr["kode_pelanggan"].ToString();

                            list.Add(spr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }
    }
}
