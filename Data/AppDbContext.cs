using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SbnApplicationUTS.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace SbnApplicationUTS.Data
{
    class AppDbContext : DbContext
    {
        public DbSet<BuyerMaster> BuyerMasters { get; set; }
        public DbSet<SbnMaster> SbnMasters { get; set; }
        public DbSet<AssetTransaction> AssetTransactions{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Load configuration directly as per your example
            string connectionString = AppSettings.GetConnectionString("Default");
            optionsBuilder.UseNpgsql(connectionString);                           // Builds the configuration

        }
    }
}
