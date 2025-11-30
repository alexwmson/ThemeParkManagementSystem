using ThemeParkManagementSystem.Entities;

namespace ThemeParkManagementSystem.Services
{
    /// <summary>
    /// IAnalyticsService
    /// Author: Javier / Alex
    /// Date: 2025-11-30
    /// Description: Defines operations for calculating analytics metrics for tickets and rides.
    /// </summary>
    public interface IAnalyticsService
    {
        // Gets analytics for today, this month, and this year and ride wait times
        AnalyticsViewModel GetTodayMonthYearAnalytics();
    }
}
