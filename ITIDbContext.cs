using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment1_C_
{
    public class ITIDbContext : DbContext
    {
        //public DbSet<>

        // Connection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AHMEDSHAABAN;database=CompanyDb;trusted_connection=true;trustServerCertificate=true").UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll);
        }
    }
}
