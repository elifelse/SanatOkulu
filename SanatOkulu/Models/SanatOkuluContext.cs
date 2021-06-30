using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatOkulu.Models
{
    public class SanatOkuluContext : DbContext
    {
        public SanatOkuluContext() : base("name=BaglantiCumlem")
        {
            // Initialize Strategy (İleride bunun yerine migrationlar kullanılacak)
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SanatOkuluContext>());
        }

        public DbSet<Sanatci> Sanatcilar { get; set; }
        public DbSet<Eser> Eserler { get; set; }
    }
}
