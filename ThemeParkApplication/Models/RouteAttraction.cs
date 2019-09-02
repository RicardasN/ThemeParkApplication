using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkApplication.Models
{
	public class RouteAttraction
	{
		public int AtractionId { get; set; }
		public Attraction Attraction { get; set; }

		public int RouteId { get; set; }
		public Route Route { get; set; }
		public int Index { get; set; }
	}
}
