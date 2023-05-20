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
    public class LaporanContoller
    {
        LaporanRepository laporanRepository;
        public List<Full_Laporan> ReadAll()
        {
            List<Full_Laporan> list = new List<Full_Laporan>();

            using (DbContext context = new DbContext())
            {
                var repository = new LaporanRepository(context);

                list = repository.ReadAll();
            }

            return list;
        }
        public List<Full_Laporan> ReadByUser(string nama)
        {
            List<Full_Laporan> list = new List<Full_Laporan>();
            using (DbContext context = new DbContext())
            {
                laporanRepository = new LaporanRepository(context);

                list = laporanRepository.ReadByUser(nama);
            }

            return list;
        }
        public List<Full_Laporan> ReadByNamaBarang(string nb)
        {
            List<Full_Laporan> list = new List<Full_Laporan>();
            using (DbContext context = new DbContext())
            {
                laporanRepository = new LaporanRepository(context);

                list = laporanRepository.ReadByNamaBarang(nb);
            }

            return list;
        }
        public List<Full_Laporan> ReadByKd(string kd)
        {
            List<Full_Laporan> list = new List<Full_Laporan>();
            using (DbContext context = new DbContext())
            {
                laporanRepository = new LaporanRepository(context);

                list = laporanRepository.ReadByKdSupp(kd);
            }

            return list;
        }
        public List<Full_Laporan> ReadByJnsBarang(string jnsb)
        {
            List<Full_Laporan> list = new List<Full_Laporan>();
            using (DbContext context = new DbContext())
            {
                laporanRepository = new LaporanRepository(context);

                list = laporanRepository.ReadByJnsBarang(jnsb);
            }

            return list;
        }
        public List<Full_Laporan> ReadByKdSupp(string kdSupp)
        {
            List<Full_Laporan> list = new List<Full_Laporan>();
            using (DbContext context = new DbContext())
            {
                laporanRepository = new LaporanRepository(context);

                list = laporanRepository.ReadByKdSupp(kdSupp);
            }

            return list;
        }
         public List<Full_Laporan> ReadByHarga(string hrg)
        {
            List<Full_Laporan> list = new List<Full_Laporan>();
            using (DbContext context = new DbContext())
            {
                laporanRepository = new LaporanRepository(context);

                list = laporanRepository.ReadByHarga(hrg);
            }

            return list;
        }
    }
}
