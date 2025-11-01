
using SbnApplicationUTS.Model;

namespace SbnApplicationUTS.Service
{
    public class SbnService
    {
        private readonly AppDbContext _db;
        public SbnService(AppDbContext db) => _db = db;
        public List<object> SetDropdown()
        {
            var list = _db.SBNs.OrderBy(m => m.Nama_SBN)
                .Select(m => new
                {
                    m.Id,
                    DisplayName = m.BuyerId + " - " + m.Nama_SBN
                })
                .ToList<object>();
            return list;
        }

        public SBN? FindById(int id)
        {
            return _db.SBNs.FirstOrDefault(x => x.Id == id);
        }

        public List<SBN> SetGrid()
        {
            return
                _db.SBNs.OrderByDescending(m => m.ModDate).ToList<SBN>();
        }

        public async void Update(SBN Sbn)
        {
            _db.Buyers.Update(Sbn);
            await _db.SaveChangesAsync();
        }
    }
}
