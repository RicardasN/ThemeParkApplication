using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkApplication.Models
{
	public class Message
	{
		[Required]
		public int MessageID { get; set; }
		public string Username{get; set;}
		[Required]
		public String Text { get; set; }
		public DateTime SentTime { get; set; }

	}
}
