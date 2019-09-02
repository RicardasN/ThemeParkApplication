using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkApplication.Models
{
	public class Attraction
	{
		[Required]
		public int AttractionID { get; set; }
		[Required, MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
		public String Name { get; set; }
		[Required]
		public String Location { get; set; }
		public String Description { get; set; }
		[Range(1, 5, ErrorMessage = "The entered number must be between 1 and 5 representing number of stars")]
		public float Rating { get; set; }
		[Required]
		public String ImageSrc { get; set; }
		
		public Boolean IsOpen { get; set; }
		//foreign key
		[ForeignKey("WorkingHours")]
		public WorkingHours VisitingHours { get; set; }

	}
}
