using System;
using Microsoft.AspNetCore.Mvc;
using ThemeParkManagementSystem.Entities;
using ThemeParkManagementSystem.Services;

namespace ThemeParkManagementSystem.Operations.Controllers
{
    public class RideController : Controller
    {
        private readonly IRideServices _rideServices;

        public RideController(IRideServices rideServices)
        {
            _rideServices = rideServices;
        }

        // GET: /Ride
        public IActionResult Index()
        {
            var rides = _rideServices.GetRides();
            return View(rides);
        }

        // GET: /Ride/Details/5
        public IActionResult Details(int id)
        {
            var ride = _rideServices.GetRide(id);
            if (ride == null)
            {
                return NotFound();
            }

            return View(ride);
        }

        // GET: /Ride/Create
        public IActionResult Create()
        {
            var model = new Ride
            {
                NextMaintenance = DateTime.Today
            };

            return View(model);
        }

        // POST: /Ride/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Ride ride)
        {
            if (!ModelState.IsValid)
            {
                return View(ride);
            }

            _rideServices.AddRide(ride);
            return RedirectToAction(nameof(Index));
        }

        // GET: /Ride/Edit/5
        public IActionResult Edit(int id)
        {
            var ride = _rideServices.GetRide(id);
            if (ride == null)
            {
                return NotFound();
            }

            return View(ride);
        }

        // POST: /Ride/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Ride ride)
        {
            if (id != ride.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(ride);
            }

            _rideServices.UpdateRide(ride);
            return RedirectToAction(nameof(Index));
        }

        // GET: /Ride/Delete/5
        public IActionResult Delete(int id)
        {
            var ride = _rideServices.GetRide(id);
            if (ride == null)
            {
                return NotFound();
            }

            return View(ride);
        }

        // POST: /Ride/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _rideServices.RemoveRide(id);
            return RedirectToAction(nameof(Index));
        }

        // GET: /Ride/FilterByWaitTime?waittime=30
        public IActionResult FilterByWaitTime(int waittime)
        {
            var rides = _rideServices.GetRidesByWaitTime(waittime);
            ViewBag.WaitTime = waittime;
            return View(rides);
        }
    }
}
