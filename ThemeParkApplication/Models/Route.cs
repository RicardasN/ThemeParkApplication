using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkApplication.Models
{
	public class Route
	{
		[Required]
		public int RouteID { get; set; }
		public List<RouteAttraction> RouteAttractions { get; set; }
		public List<Cafeteria> RouteCafeterias { get; set; }
		public String ApplicationUser { get; set; }
		public int TempAtractionID { get; set; }
	}
}
