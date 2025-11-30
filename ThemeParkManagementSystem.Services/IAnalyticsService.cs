using ThemeParkManagementSystem.Entities;

namespace ThemeParkManagementSystem.Services
{
    public interface IAnalyticsService
    {
        AnalyticsViewModel GetTodayMonthYearAnalytics();
    }
}
