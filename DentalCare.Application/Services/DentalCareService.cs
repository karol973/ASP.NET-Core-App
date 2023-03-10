using DentalCare.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare.Application.Services
{
    internal class DentalCareService : IDentalCareService
    {
        private readonly IDentalCareRepository _dentalCareRepository;
        public DentalCareService(IDentalCareRepository dentalCareRepository)
        {
            _dentalCareRepository = dentalCareRepository;
        }
        public async Task Create(Domain.Entities.DentalCare dentalCare)
        {
            dentalCare.EncodeName();
            await _dentalCareRepository.Create(dentalCare);
        }
    }
}
