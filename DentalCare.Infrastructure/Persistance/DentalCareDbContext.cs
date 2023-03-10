using DentalCare.Domain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DentalCare.Infrastructure.Persistance
{
    public class DentalCareDbContext:DbContext
    {
        public DentalCareDbContext(DbContextOptions<DentalCareDbContext> options) : base(options)
        {

        }
        public DbSet<Domain.Entities.DentalCare> DentalCareInstitutions { get; set; }

        //conntection string
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Database = DentalCareDb; Trusted_Connection = True; ");
        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Entities.DentalCare>()
                .OwnsOne(c => c.ContactDetails);

        }
    }
}
