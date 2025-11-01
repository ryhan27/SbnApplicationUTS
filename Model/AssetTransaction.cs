using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbnApplicationUTS.Model
{
    public class AssetTransaction
    {
        public int Id_aset { get; set; }
        public string Name { get; set; }
        public string Jenis_sbn { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Jumlah { get; set; }
        public int Harga { get; set; }
        public int Total { get; set; }
        public bool Jenis_transaksi { get; set; }

    }
}
