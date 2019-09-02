using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkApplication.Models
{
	public class Cafeteria
	{
		[Required]
		public int CafeteriaID { get; set; }
		[Required, MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
		public String Name { get; set; }
		[Required]
		public String Location { get; set; }
		public String Expensiveness { get; set; }
		public int AvailableSpaces { get; set; }
	}
}
