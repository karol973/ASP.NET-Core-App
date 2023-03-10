using DentalCare.Domain.Interfaces;
using DentalCare.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare.Infrastructure.Repositories
{
    internal class DentalCareRepository : IDentalCareRepository
    {
        private readonly DentalCareDbContext _dbContext;
        public DentalCareRepository(DentalCareDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Create(Domain.Entities.DentalCare dentalCare)
        {
            _dbContext.Add(dentalCare);
            await _dbContext.SaveChangesAsync();  
        }
    }
}
