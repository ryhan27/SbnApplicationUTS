using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbnApplicationUTS.Model
{
    public class SbnMaster
    {
        public int Id { get; set; }
        public string Kode_Sbn { get; set; }
        public string Nama_SBN { get; set; }
        public string Jenis { get; set; }
        public int Harga { get; set; }
        public DateTime CreatedAt { get; set; }




    }
}
