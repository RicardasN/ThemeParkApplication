using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkApplication.Models
{
	public class Review
	{
		[Required]
		public int ReviewID { get; set; }
		[Required]
		public String Text { get; set; }
		[Required, Range(1,5, ErrorMessage = "The entered number must be between 1 and 5 representing number of stars you give to this attraction")]
		public int Rating { get; set; }
		[Required]
		public DateTime ReviewDate { get; set; }
	}
}
