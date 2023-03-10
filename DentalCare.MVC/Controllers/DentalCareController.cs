using DentalCare.Domain.Interfaces;
using DentalCare.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace DentalCare.MVC.Controllers
{
    public class DentalCareController : Controller
    {
        private readonly IDentalCareService _dentalCareService;
      
            public DentalCareController (IDentalCareService dentalCareService)
            {
               _dentalCareService=dentalCareService;
            }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Create(Domain.Entities.DentalCare dentalCare)
        {
            await _dentalCareService.Create(dentalCare);
            return RedirectToAction(nameof(Create)); // TO DO: change   
        }
    }
}
