using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkApplication.Models.CRUD_Interfaces
{
	public interface ITicketRepository
	{

		Ticket GetTicket(int id);
		IEnumerable<Ticket> GetAllTickets();
		Ticket Add(Ticket attraction);
		Ticket Update(Ticket changedAttraction);
		Ticket Delete(int id);
	}
}
