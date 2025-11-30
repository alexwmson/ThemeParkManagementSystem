using Microsoft.AspNetCore.Mvc;
using ThemeParkManagementSystem.Entities;
using ThemeParkManagementSystem.Services;

namespace ThemeParkManagementSystem.Operations.Controllers
{
    public class AnalyticsController : Controller
    {
        private readonly ITicketServices ticketService;
        private readonly IRideServices rideService;

        public AnalyticsController(ITicketServices _ticketService, IRideServices _rideService)
        {
            ticketService = _ticketService;
            rideService = _rideService;
        }
        [HttpGet]
        public IActionResult Analytics()
        {
            AnalyticsViewModel analytics = new AnalyticsViewModel();
            DateTime day = DateTime.Today;
            int month = day.Month;
            int year = day.Year;

            List<Ticket> tickets = ticketService.GetTickets();
            List<Ride> rides = rideService.GetRides();

            analytics.TotalVisitorsToday = tickets.Count(x => x.DatePurchased.Date == day);
            analytics.TotalVisitorsThisMonth = tickets.Count(x => x.DatePurchased.Month == month && x.DatePurchased.Year == year);
            analytics.TotalVisitorsThisYear = tickets.Count(x => x.DatePurchased.Year == year);

            analytics.TotalRevenueToday = tickets.Where(x => x.DatePurchased.Date == day).Sum(x => x.Price);
            analytics.TotalRevenueThisMonth = tickets.Where(x => x.DatePurchased.Month == month && x.DatePurchased.Year == year).Sum(x => x.Price);
            analytics.TotalRevenueThisYear = tickets.Where(x => x.DatePurchased.Year == year).Sum(x => x.Price);

            List<int> waittimes = rides.Select(r => r.WaitTime).ToList();

            float min = float.MaxValue, max = 0, mean = 0, median = 0, mode = 0;
            Dictionary<int, int> counts = new Dictionary<int, int>();

            for (int i = 0; i < waittimes.Count(); i++)
            {
                if (counts.ContainsKey(waittimes[i]))
                    counts[waittimes[i]]++;
                else
                    counts[waittimes[i]] = 1;

                min = Math.Min(min, waittimes[i]);
                max = Math.Max(max, waittimes[i]);
                mean += waittimes[i];
            }
            mean = (float) Math.Round(mean / waittimes.Count(), 2);

            int maxCount = 0;
            foreach (int key in counts.Keys)
            {
                if (counts[key] > maxCount)
                {
                    maxCount = counts[key];
                    mode = key;
                }
            }

            if (waittimes.Count() % 2 == 0)
                median = (float)Math.Round((double)(waittimes[waittimes.Count() / 2] + waittimes[waittimes.Count() / 2 + 1]) / 2, 2);
            else
                median = waittimes[waittimes.Count() / 2];

            analytics.MeanWaitTime = mean;
            analytics.MedianWaitTime = median;
            analytics.ModeWaitTime = mode;
            analytics.MinWaitTime = rides.FirstOrDefault(x => x.WaitTime == min);
            analytics.MaxWaitTime = rides.FirstOrDefault(x => x.WaitTime == max);

            return View(analytics);
        }
    }
}
