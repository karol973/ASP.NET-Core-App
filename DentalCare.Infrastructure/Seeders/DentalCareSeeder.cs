using DentalCare.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare.Infrastructure.Seeders
{
    public class DentalCareSeeder
    {
        private readonly DentalCareDbContext _dbConctext;

        public DentalCareSeeder(DentalCareDbContext dbContext)
        {
            _dbConctext= dbContext;
        }
        public async Task Seed()
        {
            if(await _dbConctext.Database.CanConnectAsync())
            {
                if (_dbConctext.DentalCareInstitutions.Any())
                {
                    var usmiechStom = new Domain.Entities.DentalCare()
                    {
                        Name ="UsmiechStom",
                        Description = "Profesjonalna placówka stomatologiczna",
                        ContactDetails = new()
                        {
                            City = "Wronki",
                            Street = "Cwiartki 3/4",
                            PostalCode = "64-510",
                            PhoneNumber = "+48882389213"
                        }
                    };
                    usmiechStom.EncodeName();
                    _dbConctext.DentalCareInstitutions.Add(usmiechStom);
                    await _dbConctext.SaveChangesAsync();
                }
            }
        }
    }
}
