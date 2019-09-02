using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkApplication.Models
{
	public class Ticket
	{
		[Required]
		public int TicketID { get; set; }
		[Required]
		public Boolean PaymentState { get; set; }
		public String Username { get; set; }
		[Required]
		public Bank Bank { get; set; }
		[Required]
		public TicketType Type { get; set; }
		[Required]
		public DateTime PaymentDate { get; set; }
	}
}
