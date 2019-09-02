using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThemeParkApplication.Data;
using ThemeParkApplication.Models.CRUD_Interfaces;

namespace ThemeParkApplication.Models.DB_Classes
{
	public class MySqlRouteAttraction : IRouteAttraction
	{
		public RouteAttraction Add(Route route, Attraction attraction)
		{
			using (var context = ApplicationDbContext.Get)
			{
				RouteAttraction newtemp = new RouteAttraction() { RouteId = route.RouteID, Route = route, AtractionId = attraction.AttractionID, Attraction = attraction };
				context.RouteAttractions.Add(newtemp);
				context.SaveChanges();
				return newtemp;
			}
		}

		public RouteAttraction Delete(Route route, Attraction attraction)
		{
			using (var context = ApplicationDbContext.Get)
			{
				RouteAttraction routeAttraction = context.RouteAttractions.Find(route.RouteID, attraction.AttractionID);
				if (routeAttraction != null)
				{
					context.RouteAttractions.Remove(routeAttraction);
					context.SaveChanges();
				}
				return routeAttraction;
			}
		}

		public List<Attraction> GetAttractions(Route route)
		{
			using (var context = ApplicationDbContext.Get)
			{
				IEnumerable<RouteAttraction> ids = context.RouteAttractions.Where(a => a.RouteId == route.RouteID).OrderBy(x => x.Index);
				List<Attraction> routeAttractions = new List<Attraction>();

				foreach (RouteAttraction routeAttraction in ids)
				{
					routeAttractions.Add(routeAttraction.Attraction);
				}


				return routeAttractions;
			}
		}

		//public List<Attraction> GetAttractions(Route route)
		//{
		//	using (var context = ApplicationDbContext.Get)
		//	{
		//		IEnumerable<RouteAttraction> ids = context.RouteAttractions.Where(a => a.RouteId == route.RouteID);
		//		List<Attraction> routeAttractions = new List<Attraction>();
		//		foreach (RouteAttraction routeAttraction in ids)
		//		{
		//			routeAttractions.Add(routeAttraction.Attraction);
		//		}
		//		return routeAttractions;
		//	}
		//}

		public bool RouteContains(Route route, Attraction attraction)
		{
			bool contains = false;
			using (var context = ApplicationDbContext.Get)
			{
				List<RouteAttraction> routeAttraction = context.RouteAttractions.Where(a=> a.AtractionId==attraction.AttractionID && a.RouteId==route.RouteID).ToList();
				if (routeAttraction.Count > 0)
					return true;
			}
			return contains;
		}
	}
}
