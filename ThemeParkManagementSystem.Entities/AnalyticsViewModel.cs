namespace ThemeParkManagementSystem.Entities
{
    // ViewModel for analytics data in the Theme Park Management System
    public class AnalyticsViewModel
    {
        public int TotalVisitorsToday { get; set; }
        public int TotalVisitorsThisMonth { get; set; }
        public int TotalVisitorsThisYear { get; set; }

        public float TotalRevenueToday { get; set; }
        public float TotalRevenueThisMonth { get; set; }
        public float TotalRevenueThisYear { get; set; }

        public float MeanWaitTime { get; set; }
        public float MedianWaitTime { get; set; }
        public float ModeWaitTime { get; set; }
        public Ride? MinWaitTime { get; set; }
        public Ride? MaxWaitTime { get; set; }
    }
}
