using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkApplication.Models
{
	public class WorkingHours
	{
		[Required]
		public int Id { get; set; }
		[Required]
		public DateTime StartingHours { get; set; }
		[Required]
		public DateTime ClosingHours { get; set; }
		public String DayOfWeek { get; set; }
	}
}
