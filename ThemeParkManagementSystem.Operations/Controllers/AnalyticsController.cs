using Microsoft.AspNetCore.Mvc;
using ThemeParkManagementSystem.Entities;
using ThemeParkManagementSystem.Services;

namespace ThemeParkManagementSystem.Operations.Controllers
{
    /// <summary>
    /// AnalyticsController
    /// Author: Alex
    /// Date: 2025-11-30
    /// Description: Provides analytics views for visitors, revenue, and ride wait times.
    /// Delegates analytics calculations to the analytics service.
    /// </summary>
    
    public class AnalyticsController : Controller
    {
        // Service that calculates analytics from tickets and rides
        private readonly IAnalyticsService _analyticsService;

        // Initicalizes a new instance of the AnalyticsController class
        public AnalyticsController(IAnalyticsService analyticsService)
        {
            _analyticsService = analyticsService;
        }

        //Displays analytics view
        [HttpGet]
        public IActionResult Analytics()
        {
            AnalyticsViewModel analytics = _analyticsService.GetTodayMonthYearAnalytics();
            return View(analytics);
        }
    }
}
