using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalCare.Domain.Interfaces
{
    public interface IDentalCareRepository
    {
        Task Create(Domain.Entities.DentalCare dentalCare);
       
    }
}
