using System;
using Microsoft.AspNetCore.Mvc;
using ThemeParkManagementSystem.Entities;
using ThemeParkManagementSystem.Services;

namespace ThemeParkManagementSystem.Operations.Controllers
{
    /// <summary>
    /// TicketController
    /// Author: Javier / Alex
    /// Date: 2025-11-30
    /// Description: Handles all ticket-related HTTP requests (list, details, create, edit, delete, filter by type)
    /// in the Theme Park Management System presentation layer.
    /// </summary>

    public class TicketController : Controller
    {
        // Service used for ticket operations
        private readonly ITicketServices _ticketServices;

        // Initializes a new instance of the TicketController class
        public TicketController(ITicketServices ticketServices)
        {
            _ticketServices = ticketServices;
        }

        // Displays a list of all tickets
        public IActionResult Index()
        {
            var tickets = _ticketServices.GetTickets();
            return View(tickets);
        }

        // Displays details of a specific ticket by ID
        public IActionResult Details(int id)
        {
            var ticket = _ticketServices.GetTicket(id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // Displays the create ticket form
        public IActionResult Create()
        {
            var model = new Ticket
            {
                DatePurchased = DateTime.Now,
                ValidOn = DateTime.Today
            };

            return View(model);
        }

        // Handles the submission of the create ticket form
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Ticket ticket)
        {
            if (!ModelState.IsValid)
            {
                return View(ticket);
            }

            ticket.Price = TicketPricing.TicketPrices()[ticket.Type];
            _ticketServices.AddTicket(ticket);
            return RedirectToAction(nameof(Index));
        }

        // Displays the edit ticket form
        public IActionResult Edit(int id)
        {
            var ticket = _ticketServices.GetTicket(id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // Handles the submission of the edit ticket form
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Ticket ticket)
        {
            if (id != ticket.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(ticket);
            }

            ticket.Price = TicketPricing.TicketPrices()[ticket.Type];
            _ticketServices.UpdateTicket(ticket);
            return RedirectToAction(nameof(Index));
        }

        // Displays the delete ticket confirmation page
        public IActionResult Delete(int id)
        {
            var ticket = _ticketServices.GetTicket(id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // Handles the deletion of a ticket
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _ticketServices.RemoveTicket(id);
            return RedirectToAction(nameof(Index));
        }

        // Filters tickets by type and displays the filtered list
        public IActionResult FilterByType(TicketTypes type)
        {
            var tickets = _ticketServices.GetTypeTickets(type);
            ViewBag.SelectedType = type;
            return View(tickets);
        }
    }
}
