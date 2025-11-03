using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbnApplicationUTS.Model
{
    public class AssetTransaction
    {
        public int Kode_Asset { get; set; }
        public int Kode_Buyer { get; set; }
        public int Kode_SBN { get; set; }
        public string Nama_SBN { get; set; }
        public string Nama_Buyer { get; set; }
        public string Jenis_sbn { get; set; }
        public DateTime Tanggal_Transaksi { get; set; }
        public string Jumlah { get; set; }
        public int Harga_Unit { get; set; }
        public int Total_Harga { get; set; }

    }
}
