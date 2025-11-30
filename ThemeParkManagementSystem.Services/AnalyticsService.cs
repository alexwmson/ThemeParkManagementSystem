using ThemeParkManagementSystem.Entities;

namespace ThemeParkManagementSystem.Services
{
    /// <summary>
    /// AnalyticsService
    /// Author: Javier / Alex
    /// Date: 2025-11-30
    /// Description: Implements analytics calculations for visitors, revenue, and ride wait times

    public class AnalyticsService : IAnalyticsService
    {
        private readonly ITicketServices _ticketService;
        private readonly IRideServices _rideService;

        // Initializes a new instance of the AnalyticsService class with the specified ticket and ride services
        public AnalyticsService(ITicketServices ticketService, IRideServices rideService)
        {
            _ticketService = ticketService;
            _rideService = rideService;
        }

        /// <summary>
        /// Calculates visitor counts, ticket revenue, and ride wait-time statistics
        /// (mean, median, mode, min, max) for the current day, month, and year,
        /// and returns the results in an AnalyticsViewModel.
        
        /// An AnalyticsViewModel containing visitor, revenue, and
        /// wait-time analytics for the current day, month, and year.
        /// </summary>
        public AnalyticsViewModel GetTodayMonthYearAnalytics()
        {
            var analytics = new AnalyticsViewModel();
            DateTime day = DateTime.Today;
            int month = day.Month;
            int year = day.Year;

            List<Ticket> tickets = _ticketService.GetTickets();
            List<Ride> rides = _rideService.GetRides();

            analytics.TotalVisitorsToday = tickets.Count(x => x.DatePurchased.Date == day);
            analytics.TotalVisitorsThisMonth = tickets.Count(x => x.DatePurchased.Month == month && x.DatePurchased.Year == year);
            analytics.TotalVisitorsThisYear = tickets.Count(x => x.DatePurchased.Year == year);

            analytics.TotalRevenueToday = tickets.Where(x => x.DatePurchased.Date == day).Sum(x => x.Price);
            analytics.TotalRevenueThisMonth = tickets.Where(x => x.DatePurchased.Month == month && x.DatePurchased.Year == year).Sum(x => x.Price);
            analytics.TotalRevenueThisYear = tickets.Where(x => x.DatePurchased.Year == year).Sum(x => x.Price);

            List<int> waittimes = rides.Select(r => r.WaitTime).ToList();

            if (waittimes.Count == 0)
            {
                return analytics;
            }

            float min = float.MaxValue, max = 0, mean = 0, median = 0, mode = 0;
            Dictionary<int, int> counts = new Dictionary<int, int>();

            for (int i = 0; i < waittimes.Count; i++)
            {
                if (counts.ContainsKey(waittimes[i]))
                    counts[waittimes[i]]++;
                else
                    counts[waittimes[i]] = 1;

                min = Math.Min(min, waittimes[i]);
                max = Math.Max(max, waittimes[i]);
                mean += waittimes[i];
            }
            mean = (float)Math.Round(mean / waittimes.Count, 2);

            int maxCount = 0;
            foreach (int key in counts.Keys)
            {
                if (counts[key] > maxCount)
                {
                    maxCount = counts[key];
                    mode = key;
                }
            }

            waittimes.Sort();
            if (waittimes.Count % 2 == 0)
                median = (float)Math.Round((waittimes[waittimes.Count / 2 - 1] + waittimes[waittimes.Count / 2]) / 2.0, 2);
            else
                median = waittimes[waittimes.Count / 2];

            analytics.MeanWaitTime = mean;
            analytics.MedianWaitTime = median;
            analytics.ModeWaitTime = mode;
            analytics.MinWaitTime = rides.FirstOrDefault(x => x.WaitTime == min);
            analytics.MaxWaitTime = rides.FirstOrDefault(x => x.WaitTime == max);

            return analytics;
        }
    }
}
