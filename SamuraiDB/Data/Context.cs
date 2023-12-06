using Microsoft.EntityFrameworkCore;
using SamuraiDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiDB.Data
{
    internal class Context: DbContext
    {

        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<BattleLog> BattleLogs { get; set; }
        public DbSet<BattleEvent> BattleEvents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
                Server=localhost;
                Database=SamuraiDB;
                Trusted_Connection=true;
                Trust Server Certificate=yes;
                User Id=SamuraiDB;
                password=SamuraiDB");

            //optionsBuilder.UseSqlServer(@"Server=tcp:samuraidbtest.database.windows.net,1433;Initial Catalog=FirstDBTest;Persist Security Info=False;User ID=christos;Password=samuraidbtest123!!!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}

