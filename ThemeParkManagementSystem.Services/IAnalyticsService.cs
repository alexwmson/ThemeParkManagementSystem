using ThemeParkManagementSystem.Entities;

namespace ThemeParkManagementSystem.Services
{
    // Interface defining analytics-related services in the Theme Park Management System
    public interface IAnalyticsService
    {
        AnalyticsViewModel GetTodayMonthYearAnalytics();
    }
}
