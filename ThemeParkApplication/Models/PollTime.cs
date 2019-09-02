using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkApplication.Models
{
	public class PollTime
	{
		[Required]
		public int PollTimeID { get; set; }
		[Required]
		public DateTime PollingLength { get; set; }
	}
}
