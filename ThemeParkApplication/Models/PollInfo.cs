using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkApplication.Models
{
	public class PollInfo
	{
		[Required]
		public int PollID { get; set; }
		[Required]
		public int PeopleInRowCount { get; set; }
		[Required]
		public DateTime PollingDate { get; set; }
		[Required]
		public float WaitingTime { get; set; }
	}
}
