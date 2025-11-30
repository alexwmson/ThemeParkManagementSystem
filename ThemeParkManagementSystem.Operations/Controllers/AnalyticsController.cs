using Microsoft.AspNetCore.Mvc;
using ThemeParkManagementSystem.Entities;
using ThemeParkManagementSystem.Services;

namespace ThemeParkManagementSystem.Operations.Controllers
{
    // Controller for handling analytics views in the Theme Park Management System
    public class AnalyticsController : Controller
    {
        private readonly IAnalyticsService _analyticsService;

        public AnalyticsController(IAnalyticsService analyticsService)
        {
            _analyticsService = analyticsService;
        }

        [HttpGet]
        public IActionResult Analytics()
        {
            AnalyticsViewModel analytics = _analyticsService.GetTodayMonthYearAnalytics();
            return View(analytics);
        }
    }
}
