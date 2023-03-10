namespace DentalCare.Application.Services
{
    public interface IDentalCareService
    {
        Task Create(Domain.Entities.DentalCare dentalCare);
    }
}