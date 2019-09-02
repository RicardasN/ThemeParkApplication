using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkApplication.Models.CRUD_Interfaces
{
	public interface IRouteAttraction
	{
		Boolean RouteContains(Route route, Attraction attraction);
		RouteAttraction Add(Route route, Attraction attraction);
		RouteAttraction Delete(Route route, Attraction attraction);
		List<Attraction> GetAttractions(Route route);

	}
}
