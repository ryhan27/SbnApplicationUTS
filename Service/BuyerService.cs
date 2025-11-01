using SbnApplicationUTS.Data;
using SbnApplicationUTS.Models;

namespace SbnApplicationUTS.Services
{
    public class BuyerService
    {
        private readonly AppDbContext _db;
        public BuyerService(AppDbContext db) => _db = db;
        public List<object> SetDropdown()
        {
            var list = _db.Buyers.OrderBy(m => m.Nama)
                .Select(m => new
                {
                    m.Id,
                    DisplayName = m.Id + " - " + m.Nama
                })
                .ToList<object>();
            return list;
        }

        public Buyer? FindById(int id)
        {
            return _db.Buyers.FirstOrDefault(x => x.Id == id);
        }

        public List<Buyer> SetGrid()
        {
            return 
                _db.Buyers.OrderByDescending(m=> m.ModDate).ToList<Buyer>();
        }

        public async void Update(Buyer buyer)
        {
            _db.Buyers.Update(buyer);
            await _db.SaveChangesAsync();
        }
    }
}
