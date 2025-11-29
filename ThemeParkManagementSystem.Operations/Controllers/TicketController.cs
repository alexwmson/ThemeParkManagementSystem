using System;
using Microsoft.AspNetCore.Mvc;
using ThemeParkManagementSystem.Entities;
using ThemeParkManagementSystem.Services;

namespace ThemeParkManagementSystem.Operations.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketServices _ticketServices;

        public TicketController(ITicketServices ticketServices)
        {
            _ticketServices = ticketServices;
        }

        // GET: /Ticket
        public IActionResult Index()
        {
            var tickets = _ticketServices.GetTickets();
            return View(tickets);
        }

        // GET: /Ticket/Details/5
        public IActionResult Details(int id)
        {
            var ticket = _ticketServices.GetTicket(id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // GET: /Ticket/Create
        public IActionResult Create()
        {
            var model = new Ticket
            {
                DatePurchased = DateTime.Now,
                ValidOn = DateTime.Today
            };

            return View(model);
        }

        // POST: /Ticket/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Ticket ticket)
        {
            if (!ModelState.IsValid)
            {
                return View(ticket);
            }

            _ticketServices.AddTicket(ticket);
            return RedirectToAction(nameof(Index));
        }

        // GET: /Ticket/Edit/5
        public IActionResult Edit(int id)
        {
            var ticket = _ticketServices.GetTicket(id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // POST: /Ticket/Edit/5
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

            _ticketServices.UpdateTicket(ticket);
            return RedirectToAction(nameof(Index));
        }

        // GET: /Ticket/Delete/5
        public IActionResult Delete(int id)
        {
            var ticket = _ticketServices.GetTicket(id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // POST: /Ticket/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _ticketServices.RemoveTicket(id);
            return RedirectToAction(nameof(Index));
        }

        // GET: /Ticket/FilterByType?type=Adult
        public IActionResult FilterByType(TicketTypes type)
        {
            var tickets = _ticketServices.GetTypeTickets(type);
            ViewBag.SelectedType = type;
            return View(tickets);
        }
    }
}
