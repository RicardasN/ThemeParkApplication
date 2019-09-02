using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThemeParkApplication.Models;
using ThemeParkApplication.Models.CRUD_Interfaces;

namespace ThemeParkApplication.Controllers
{
    public class TicketController : Controller
    {
		private ITicketRepository _ticketRepository;

		public TicketController(ITicketRepository ticketRepository)
		{
			_ticketRepository = ticketRepository;
		}
		// GET: Ticket
		[Route("Ticket")]
		[Route("Ticket/Index")]
		public ActionResult Index()
        {
			if (!User.IsInRole("Admin"))
			{
				IEnumerable<Ticket> Tickets = _ticketRepository.GetAllTickets();
				List<Ticket> userTickets = new List<Ticket>();
				foreach (Models.Ticket ticket in Tickets)
				{
					if (ticket.Username.Equals(User.Identity.Name))
						userTickets.Add(ticket);
				}
				var model = userTickets;
					return View(model);
			}
			else
			{
				var model = _ticketRepository.GetAllTickets();
				return View(model);
			}			
		}

		// GET: Ticket/Details/5
		public ActionResult Details(int id)
        {
            return View();
        }

		// GET: Ticket/Create
		[HttpGet]
		public ActionResult Create()
        {
            return View();
        }

		// POST: Ticket/Create
		[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ticket ticket)
        {
				ticket.PaymentDate = DateTime.Now;
				ticket.Username = User.Identity.Name;
				ticket.PaymentState = true;
				if (ModelState.IsValid)
				{
					Ticket newTicket = _ticketRepository.Add(ticket);
					if(ticket.PaymentState)
					return RedirectToAction("Success");
					else
						return RedirectToAction("failure");

				}
				return View();
        }
		// Ticket/Success
		public ActionResult Success()
		{
			return View();
		}
		// GET: Ticket/Edit/5
		public ActionResult Edit(int id)
        {
            return View();
        }

		// POST: Ticket/Edit/5
		[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ticket/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}