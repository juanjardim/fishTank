using System;
using fishTankApp.Services;
using Microsoft.AspNet.Mvc;

namespace fishTankApp.Controllers
{
    public class HomeController : Controller
    {
        private IViewModelService viewModelService;
        public HomeController(IViewModelService viewModelService)
        {
            this.viewModelService = viewModelService;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Fish Tank dashboar";
            return View(viewModelService.GetDashboardViewModel());
        }

        public IActionResult Feed(int foodAmount)
        {
            var model = viewModelService.GetDashboardViewModel();
            model.LastFed = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}. Amnout: {foodAmount}";
            return View("Index", model);
        }

    }
}
