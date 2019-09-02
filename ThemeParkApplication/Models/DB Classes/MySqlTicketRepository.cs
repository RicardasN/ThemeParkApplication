using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThemeParkApplication.Data;
using ThemeParkApplication.Models.CRUD_Interfaces;

namespace ThemeParkApplication.Models.DB_Classes
{
	public class MySqlTicketRepository : ITicketRepository
	{
		private readonly ApplicationDbContext context;
		public MySqlTicketRepository(ApplicationDbContext context)
		{
			this.context = context;
		}

		public Ticket Add(Ticket ticket)
		{
			context.Tickets.Add(ticket);
			context.SaveChanges();
			return ticket;
		}

		public IEnumerable<Ticket> GetAllTickets()
		{
			return context.Tickets;
		}

		public Ticket GetTicket(int id)
		{
			return context.Tickets.Find(id);
		}

		public Ticket Update(Ticket updatedTicket)
		{
			var ticket = context.Tickets.Attach(updatedTicket);
			ticket.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			context.SaveChanges();
			return updatedTicket;
		}

		Ticket ITicketRepository.Delete(int id)
		{
			Ticket ticket = context.Tickets.Find(id);
			if (ticket != null)
			{
				context.Tickets.Remove(ticket);
				context.SaveChanges();
			}
			return ticket;
		}
	}
}
