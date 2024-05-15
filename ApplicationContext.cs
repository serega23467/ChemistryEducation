using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ChemistryEducation
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ChemicalElement> PeriodicTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ChemicalInfo.db");
        }
    }
}
