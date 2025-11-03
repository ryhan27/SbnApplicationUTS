//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using SbnApplicationUTS.Data;
using SbnApplicationUTS.Model;

namespace SbnApplicationUTS.Services
{
    public class AssetService
    {
        private readonly AppDbContext _db;
        public AssetService(AppDbContext db) => _db = db;
        public List<object> SetDropdown()
        {
            var list = _db.Assets.OrderBy(m => m.Nama_Asset)
                .Select(m => new
                {
                    m.Id,
                    DisplayName = m.Id + " - " + m.Nama_Asset
                })
                .ToList<object>();
            return list;
        }

        public Asset? FindById(int id)
        {
            return _db.SBNs.FirstOrDefault(x => x.Id == id);
        }

        public List<Asset> SetGrid()
        {
            return
                _db.SBNs.OrderByDescending(m => m.ModDate).ToList<Asset>();
        }

        public async void Update(Asset Asset)
        {
            _db.SBNs.Update(Asset);
            await _db.SaveChangesAsync();
        }
    }
}
