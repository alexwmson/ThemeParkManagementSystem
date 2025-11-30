using System;
using Microsoft.AspNetCore.Mvc;
using ThemeParkManagementSystem.Entities;
using ThemeParkManagementSystem.Services;

namespace ThemeParkManagementSystem.Operations.Controllers
{
    /// <summary>
    /// TicketController
    /// Author: Alex
    /// Date: 2025-11-30
    /// Description: Handles all ride-related HTTP requests (list, details, create, edit, delete, filter by wait time)
    /// in the Theme Park Management System presentation layer.
    /// </summary>
    public class RideController : Controller
    {
        // Service used for ride operations
        private readonly IRideServices _rideServices;

        // Initializes a new instance of the RideController class
        public RideController(IRideServices rideServices)
        {
            _rideServices = rideServices;
        }

        // Displays a list of all rides
        public IActionResult Index()
        {
            var rides = _rideServices.GetRides();
            return View(rides);
        }

        // Displays details of a specific ride by ID
        public IActionResult Details(int id)
        {
            var ride = _rideServices.GetRide(id);
            if (ride == null)
            {
                return NotFound();
            }

            return View(ride);
        }

        // Displays the create ride form
        public IActionResult Create()
        {
            var model = new Ride
            {
                NextMaintenance = DateTime.Today
            };

            return View(model);
        }

        // Handles the submission of the create ride form
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

        // Displays the edit ride form for a specific ride by ID
        public IActionResult Edit(int id)
        {
            var ride = _rideServices.GetRide(id);
            if (ride == null)
            {
                return NotFound();
            }

            return View(ride);
        }

        // Handles the submission of the edit ride form
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

        // Displays the delete confirmation page for a specific ride by ID
        public IActionResult Delete(int id)
        {
            var ride = _rideServices.GetRide(id);
            if (ride == null)
            {
                return NotFound();
            }

            return View(ride);
        }

        // Handles the deletion of a specific ride by ID
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _rideServices.RemoveRide(id);
            return RedirectToAction(nameof(Index));
        }

        // Filters rides by wait time and displays the results
        public IActionResult FilterByWaitTime(int waitTime)
        {
            var rides = _rideServices.GetRidesByWaitTime(waitTime);
            ViewBag.WaitTime = waitTime;
            return View(rides);
        }
    }
}
