using Microsoft.AspNetCore.Mvc;
using Rungroopwebapp.Data;
using RunUnity.Interfaces;
using RunUnity.ViewModels;

namespace RunUnity.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IDashboardRepository _dashboardRepository;

        public DashboardController(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository;
        }
        public  async Task<IActionResult> Index()
        {


            var userRaces = await _dashboardRepository.GetAllUserRaces();
            var userClubs = await _dashboardRepository.GetAllUserClubs();
            var dashboardviewmodel = new DashboardViewModel()
            {
                Races = userRaces,
                Clubs = userClubs

            };
            return View(dashboardviewmodel);


        }
    }
}
